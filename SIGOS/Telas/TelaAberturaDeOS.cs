using MySql.Data.MySqlClient;
using SIGOS.Banco;
using System;
using System.Data;
using System.Windows.Forms;

namespace SIGOS.Telas
{
    public partial class TelaAberturaDeOS : Form
    {
        // Evita que o evento do ComboBox dispare enquanto a tela ainda está carregando
        private bool carregando = true;

        public TelaAberturaDeOS()
        {
            InitializeComponent();

            btnSalvarOS.Click += btnSalvarOS_Click;
            btnLimparFormularioTecnico.Click += btnLimparFormularioTecnico_Click;
        }

        private MySqlConnection ObterConexao()
        {
            ConexaoBanco conexao = new ConexaoBanco();
            if (conexao.conn.State != ConnectionState.Closed)
                conexao.conn.Close();
            return conexao.conn;
        }

        private void TelaAberturaDeOS_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarClientes();
                CarregarTecnicos();
                CarregarPrioridades();
                CarregarStatusInicial();
                LimparFormulario();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message,
                    "SIGOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                carregando = false;
            }
        }

        private DataTable Consultar(string sql, params MySqlParameter[] parametros)
        {
            using (var con = ObterConexao())
            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddRange(parametros);
                var dt = new DataTable();
                new MySqlDataAdapter(cmd).Fill(dt);
                return dt;
            }
        }

        private void CarregarClientes()
        {
            cbClienteOS.DataSource = Consultar("SELECT id, nome FROM clientes ORDER BY nome");
            cbClienteOS.DisplayMember = "nome";
            cbClienteOS.ValueMember = "id";
            cbClienteOS.SelectedIndex = -1;
        }

        private void CarregarTecnicos()
        {
            cbTecnicoOS.DataSource = Consultar("SELECT id, nome FROM tecnicos ORDER BY nome");
            cbTecnicoOS.DisplayMember = "nome";
            cbTecnicoOS.ValueMember = "id";
            cbTecnicoOS.SelectedIndex = -1;
        }

        private void CarregarPrioridades()
        {
            cbPrioridadeOS.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrioridadeOS.Items.Clear();
            cbPrioridadeOS.Items.AddRange(new object[] { "Baixa", "Média", "Alta", "Urgente" });
            cbPrioridadeOS.SelectedIndex = -1;
        }

        private void CarregarStatusInicial()
        {
            // Toda Ordem de Serviço nova nasce "Aberta"; o usuário não escolhe outro status aqui
            cbStatusOS.Items.Clear();
            cbStatusOS.Items.Add("Aberta");
            cbStatusOS.SelectedIndex = 0;
            cbStatusOS.Enabled = false;
        }

        //Equipamentos filtrados pelo cliente

        private void cbClienteOS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carregando) return;

            if (cbClienteOS.SelectedIndex < 0 || cbClienteOS.SelectedValue == null || cbClienteOS.SelectedValue is DataRowView)
            {
                cbEquipamentoOS.DataSource = null;
                return;
            }

            try
            {
                int idCliente = Convert.ToInt32(cbClienteOS.SelectedValue);

                cbEquipamentoOS.DataSource = Consultar(
                    @"SELECT id, CONCAT(tipo, ' - ', marca, ' ', modelo) AS descricao
                      FROM equipamentos WHERE cliente_id = @cli ORDER BY tipo, marca",
                    new MySqlParameter("@cli", idCliente));

                cbEquipamentoOS.DisplayMember = "descricao";
                cbEquipamentoOS.ValueMember = "id";
                cbEquipamentoOS.SelectedIndex = -1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao carregar equipamentos: " + ex.Message,
                    "SIGOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescricaoOS_TextChanged(object sender, EventArgs e)
        {
            // (não tem ação por enquanto)
        }

        //Parte de validação

        private bool ValidarCampos()
        {
            if (cbClienteOS.SelectedIndex < 0 || cbClienteOS.SelectedValue == null || cbClienteOS.SelectedValue is DataRowView)
            { Aviso("Selecione o cliente.", cbClienteOS); return false; }

            if (cbEquipamentoOS.SelectedIndex < 0 || cbEquipamentoOS.SelectedValue == null || cbEquipamentoOS.SelectedValue is DataRowView)
            { Aviso("Selecione o equipamento.", cbEquipamentoOS); return false; }

            if (cbTecnicoOS.SelectedIndex < 0 || cbTecnicoOS.SelectedValue == null || cbTecnicoOS.SelectedValue is DataRowView)
            { Aviso("Selecione o técnico responsável.", cbTecnicoOS); return false; }

            if (cbPrioridadeOS.SelectedIndex < 0)
            { Aviso("Selecione a prioridade.", cbPrioridadeOS); return false; }

            if (string.IsNullOrWhiteSpace(txtDescricaoOS.Text))
            { Aviso("Descreva o problema.", txtDescricaoOS); return false; }

            if (dtpAberturaOS.Value.Date > DateTime.Today)
            { Aviso("A data de abertura não pode ser futura.", dtpAberturaOS); return false; }

            return true;
        }

        private void Aviso(string msg, Control campo)
        {
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            campo.Focus();
        }

        //Salvar Ordem de Serviço

        private void btnSalvarOS_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int idCliente = Convert.ToInt32(cbClienteOS.SelectedValue);
            int idEquip = Convert.ToInt32(cbEquipamentoOS.SelectedValue);
            int idTecnico = Convert.ToInt32(cbTecnicoOS.SelectedValue);
            string prioridade = cbPrioridadeOS.Text.Trim().ToUpperInvariant().Replace("É", "E");

            using (var con = ObterConexao())
            {
                try
                {
                    con.Open();
                    using (var tran = con.BeginTransaction())
                    {
                        try
                        {
                            // Nessa parte garante que o equipamento pertence ao cliente
                            var cmdChk = new MySqlCommand(
                                "SELECT COUNT(*) FROM equipamentos WHERE id = @eq AND cliente_id = @cli",
                                con, tran);
                            cmdChk.Parameters.AddWithValue("@eq", idEquip);
                            cmdChk.Parameters.AddWithValue("@cli", idCliente);

                            if (Convert.ToInt32(cmdChk.ExecuteScalar()) == 0)
                            {
                                tran.Rollback();
                                MessageBox.Show("O equipamento não pertence ao cliente selecionado.",
                                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Insere a Ordem de Serviço
                            var cmdOs = new MySqlCommand(
                                @"INSERT INTO ordens_servico
                                    (cliente_id, equipamento_id, tecnico_id, usuario_abertura_id,
                                     data_abertura, prioridade, status, diagnostico, desconto, total)
                                  VALUES
                                    (@cli, @eq, @tec, @usr, @data, @prio, 'ABERTA', @desc, 0.00, 0.00)",
                                con, tran);
                            cmdOs.Parameters.AddWithValue("@cli", idCliente);
                            cmdOs.Parameters.AddWithValue("@eq", idEquip);
                            cmdOs.Parameters.AddWithValue("@tec", idTecnico);
                            cmdOs.Parameters.AddWithValue("@usr", Sessao.IdUsuario);
                            cmdOs.Parameters.AddWithValue("@data", dtpAberturaOS.Value.Date);
                            cmdOs.Parameters.AddWithValue("@prio", prioridade);
                            cmdOs.Parameters.AddWithValue("@desc", txtDescricaoOS.Text.Trim());
                            cmdOs.ExecuteNonQuery();

                            long idOs = cmdOs.LastInsertedId;

                            // Grava o histórico inicial
                            var cmdHist = new MySqlCommand(
                                @"INSERT INTO historico_os
                                    (ordem_servico_id, status_anterior, status_novo,
                                     usuario_id, data_alteracao, justificativa)
                                  VALUES
                                    (@os, NULL, 'ABERTA', @usr, NOW(), 'Abertura da OS')",
                                con, tran);
                            cmdHist.Parameters.AddWithValue("@os", idOs);
                            cmdHist.Parameters.AddWithValue("@usr", Sessao.IdUsuario);
                            cmdHist.ExecuteNonQuery();

                            tran.Commit();

                            //
                            MessageBox.Show("OS nº " + idOs + " aberta com sucesso!","SIGOS",
                                MessageBoxButtons.OK,MessageBoxIcon.Information);

                            TelaItensOS telaItens =new TelaItensOS((int)idOs);

                            telaItens.Show();

                            this.Hide();
                            //

                            MessageBox.Show("OS nº " + idOs + " aberta com sucesso!",
                                "SIGOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparFormulario();
                        }
                        catch
                        {
                            tran.Rollback();
                            throw;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao salvar a OS: " + ex.Message,
                        "SIGOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //LIMPAR

        private void LimparFormulario()
        {
            cbClienteOS.SelectedIndex = -1;
            cbEquipamentoOS.DataSource = null;
            cbTecnicoOS.SelectedIndex = -1;
            cbPrioridadeOS.SelectedIndex = -1;
            cbStatusOS.SelectedIndex = 0;
            dtpAberturaOS.Value = DateTime.Today;
            txtDescricaoOS.Clear();
            cbClienteOS.Focus();
        }

        private void btnLimparFormularioTecnico_Click(object sender, EventArgs e)
        {
            LimparFormulario();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}