using MySql.Data.MySqlClient;
using SIGOS.Banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SIGOS.Telas
{
    public partial class TelaConsultaOS : Form
    {
        // Controla se a tela ainda está carregando os componentes iniciais
        private bool carregando = true;

        // Lista fixa dos status permitidos pela estrutura da tabela ordens_servico
        private static readonly string[] StatusOS =
        {
            "ABERTA",
            "DIAGNOSTICO",
            "AGUARDANDO_APROVACAO",
            "EM_EXECUCAO",
            "CONCLUIDA",
            "CANCELADA"
        };

        public TelaConsultaOS()
        {
            InitializeComponent();

            // Garante que o evento Load da tela dispare ao abrir o formulário
            this.Load -= TelaConsultaOS_Load;
            this.Load += TelaConsultaOS_Load;

            // Liga os cliques dos botões da tela (ajuste os nomes se no Designer.cs estiverem diferentes)
            btnSalvarServico.Click -= btnPesquisar_Click;
            btnSalvarServico.Click += btnPesquisar_Click;

            btnLimparFormularioServico.Click -= btnLimparFiltros_Click;
            btnLimparFormularioServico.Click += btnLimparFiltros_Click;

            btnAlterarStatus.Click -= btnAlterarStatus_Click;
            btnAlterarStatus.Click += btnAlterarStatus_Click;
        }

        // Cria uma instância de ConexaoBanco e garante que a conexão comece fechada
        private MySqlConnection ObterConexao()
        {
            ConexaoBanco conexao = new ConexaoBanco();
            if (conexao.conn.State != ConnectionState.Closed)
                conexao.conn.Close();
            return conexao.conn;
        }

        // Executa consultas SQL  e devolve o resultado em um DataTable
        private DataTable Consultar(string sql, List<MySqlParameter> parametros)
        {
            using (var con = ObterConexao())
            using (var cmd = new MySqlCommand(sql, con))
            {
                if (parametros != null && parametros.Count > 0)
                    cmd.Parameters.AddRange(parametros.ToArray());

                var dt = new DataTable();
                using (var da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                return dt;
            }
        }

        // Carrega filtros, define valores padrão e realiza a primeira busca ao abrir a tela
        private void TelaConsultaOS_Load(object sender, EventArgs e)
        {
            try
            {
                CarregarClientesFiltro();
                CarregarCombosStatus();
                LimparFiltros();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao carregar filtros: " + ex.Message,
                    "SIGOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                carregando = false;
            }

            PesquisarOS();
        }

        // Preenche o combo de filtro de clientes com os registros ordenados por nome
        private void CarregarClientesFiltro()
        {
            cbClienteOs.DisplayMember = "nome";
            cbClienteOs.ValueMember = "id";
            cbClienteOs.DataSource = Consultar("SELECT id, nome FROM clientes ORDER BY nome", null);
            cbClienteOs.SelectedIndex = -1;
        }

        // Preenche o combo de filtro de status (com opção "Todos") e o combo de alteração de status
        private void CarregarCombosStatus()
        {
            cbStatusOs.Items.Clear();
            cbStatusOs.Items.Add("Todos");
            cbStatusOs.Items.AddRange(StatusOS);
            cbStatusOs.SelectedIndex = 0;

            cbNovoStatusOs.Items.Clear();
            cbNovoStatusOs.Items.AddRange(StatusOS);
            cbNovoStatusOs.SelectedIndex = -1;
        }

        // Monta a consulta filtrando por número da OS, período, cliente e status, e atualiza a grade
        private void PesquisarOS()
        {
            // Impede pesquisa quando a data inicial ultrapassa a data final
            if (dtpAberturaOS.Value.Date > dtpFimOS.Value.Date)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpAberturaOS.Focus();
                return;
            }

            // Junta ordens_servico com clientes e equipamentos para exibir informações legíveis na grade
            var sql = new StringBuilder(@"
                SELECT
                    os.id AS 'Nº OS',
                    c.nome AS 'Cliente',
                    CONCAT(e.tipo, ' - ', e.marca, ' ', e.modelo) AS 'Equipamento',
                    os.prioridade AS 'Prioridade',
                    os.status AS 'Status',
                    os.data_abertura AS 'Data Abertura',
                    os.total AS 'Total'
                FROM ordens_servico os
                INNER JOIN clientes c ON c.id = os.cliente_id
                INNER JOIN equipamentos e ON e.id = os.equipamento_id
                WHERE DATE(os.data_abertura) BETWEEN @dtIni AND @dtFim");

            var parametros = new List<MySqlParameter>
            {
                new MySqlParameter("@dtIni", dtpAberturaOS.Value.Date),
                new MySqlParameter("@dtFim", dtpFimOS.Value.Date)
            };

            // Filtra por número da OS quando o campo Número da OS é preenchido (troque 'txtNumeroOS' se tiver outro nome)
            if (!string.IsNullOrWhiteSpace(txtPrecoUnitarioServico.Text))
            {
                if (!int.TryParse(txtPrecoUnitarioServico.Text.Trim(), out int numeroOs))
                {
                    MessageBox.Show("Informe um número de OS válido.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecoUnitarioServico.Focus();
                    return;
                }

                sql.Append(" AND os.id = @idOs");
                parametros.Add(new MySqlParameter("@idOs", numeroOs));
            }

            // Aplica o filtro de cliente apenas quando há um item válido selecionado
            if (cbClienteOs.SelectedIndex >= 0 &&
                cbClienteOs.SelectedValue != null &&
                !(cbClienteOs.SelectedValue is DataRowView))
            {
                sql.Append(" AND os.cliente_id = @clienteId");
                parametros.Add(new MySqlParameter("@clienteId", Convert.ToInt32(cbClienteOs.SelectedValue)));
            }

            // Ignora o índice 0 ("Todos") e filtra quando um status específico é escolhido
            if (cbStatusOs.SelectedIndex > 0 && !string.IsNullOrWhiteSpace(cbStatusOs.Text))
            {
                sql.Append(" AND os.status = @status");
                parametros.Add(new MySqlParameter("@status", cbStatusOs.Text.Trim()));
            }

            sql.Append(" ORDER BY os.id DESC");

            // Exibe as ordens de serviço encontradas no DataGridView
            dgvOs.DataSource = Consultar(sql.ToString(), parametros);
        }

        // Restaura os campos de filtro e seleção para o estado inicial
        private void LimparFiltros()
        {
            bool anterior = carregando;
            carregando = true;
            try
            {
                txtPrecoUnitarioServico.Clear();
                cbClienteOs.SelectedIndex = -1;
                cbStatusOs.SelectedIndex = 0;
                dtpAberturaOS.Value = DateTime.Today.AddDays(-30);
                dtpFimOS.Value = DateTime.Today;
                cbNovoStatusOs.SelectedIndex = -1;
            }
            finally
            {
                carregando = anterior;
            }
        }

        // Atualiza o status da OS selecionada na grade e registra a mudança em historico_os
        // Define quais mudanças de status são permitidas (fluxo do enunciado)
        private bool TransicaoPermitida(string atual, string novo)
        {
            // OS concluída ou cancelada não pode mais ser alterada
            if (atual == "CONCLUIDA" || atual == "CANCELADA")
                return false;

            // Cancelar é permitido em qualquer etapa
            if (novo == "CANCELADA")
                return true;

            // Nos demais casos, só avança para o próximo status da lista
            int posAtual = Array.IndexOf(StatusOS, atual);
            int posNovo = Array.IndexOf(StatusOS, novo);

            return posNovo == posAtual + 1;
        }

        // Abre uma janela simples para o usuário digitar um texto (justificativa, solução...)
        private string PedirTexto(string titulo, string mensagem)
        {
            TelaTexto tela = new TelaTexto(titulo, mensagem);

            string resultado = null;

            if (tela.ShowDialog() == DialogResult.OK)
            {
                resultado = tela.TextoDigitado;
            }

            tela.Dispose();
            return resultado;
        }

        // Confere se a OS pode ser concluída: diagnóstico, serviços registrados e valor calculado
        private string ValidarConclusao(int idOs)
        {
            var parametros = new List<MySqlParameter>
    {
        new MySqlParameter("@idOs", idOs)
    };

            DataTable dt = Consultar(@"
        SELECT os.diagnostico,
               (SELECT COUNT(*) FROM itens_os WHERE ordem_servico_id = os.id) AS qtd,
               (SELECT IFNULL(SUM(quantidade * preco_unitario), 0)
                  FROM itens_os WHERE ordem_servico_id = os.id) AS total
        FROM ordens_servico os
        WHERE os.id = @idOs", parametros);

            if (dt.Rows.Count == 0)
                return "OS não encontrada.";

            DataRow linha = dt.Rows[0];

            if (string.IsNullOrWhiteSpace(Convert.ToString(linha["diagnostico"])))
                return "Não é possível concluir: a OS não tem diagnóstico.";

            if (Convert.ToInt32(linha["qtd"]) == 0)
                return "Não é possível concluir: nenhum serviço foi registrado na OS.";

            if (Convert.ToDecimal(linha["total"]) <= 0)
                return "Não é possível concluir: o valor da OS não foi calculado.";

            return "";
        }

        private void AtualizarStatusOSSelecionada()
        {
            if (dgvOs.CurrentRow == null || dgvOs.CurrentRow.Cells["Nº OS"].Value == null)
            {
                MessageBox.Show("Selecione uma ordem de serviço na grade.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbNovoStatusOs.SelectedIndex < 0 || string.IsNullOrWhiteSpace(cbNovoStatusOs.Text))
            {
                MessageBox.Show("Selecione o novo status.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbNovoStatusOs.Focus();
                return;
            }

            int idOs = Convert.ToInt32(dgvOs.CurrentRow.Cells["Nº OS"].Value);
            string statusAnterior = Convert.ToString(dgvOs.CurrentRow.Cells["Status"].Value);
            string statusNovo = cbNovoStatusOs.Text.Trim();

            if (string.Equals(statusAnterior, statusNovo, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("A OS já está com esse status.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!TransicaoPermitida(statusAnterior, statusNovo))
            {
                MessageBox.Show("Mudança de status não permitida.\n" +
                    "Siga o fluxo: ABERTA, DIAGNOSTICO, AGUARDANDO_APROVACAO, EM_EXECUCAO, CONCLUIDA.\n" +
                    "Uma OS concluída ou cancelada não pode ser alterada.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string justificativa = "Alteração de status via consulta";
            string solucao = null;

            if (statusNovo == "CANCELADA")
            {
                justificativa = PedirTexto("Cancelamento", "Informe a justificativa do cancelamento:");

                if (string.IsNullOrWhiteSpace(justificativa))
                {
                    MessageBox.Show("O cancelamento exige uma justificativa.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (statusNovo == "CONCLUIDA")
            {
                string erro = ValidarConclusao(idOs);

                if (erro != "")
                {
                    MessageBox.Show(erro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                solucao = PedirTexto("Conclusão", "Informe a solução aplicada:");

                if (string.IsNullOrWhiteSpace(solucao))
                {
                    MessageBox.Show("Informe a solução aplicada para concluir a OS.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            using (var con = ObterConexao())
            {
                try
                {
                    con.Open();
                    // Usa transação para manter ordens_servico e historico_os consistentes
                    using (var tran = con.BeginTransaction())
                    {
                        try
                        {
                            // Atualiza o status, recalcula o total a partir dos itens e
                            // preenche data_conclusao quando o status passa a CONCLUIDA
                            using (var cmdUpd = new MySqlCommand(
                                @"UPDATE ordens_servico
                          SET status = @statusNovo,
                              total = (SELECT IFNULL(SUM(quantidade * preco_unitario), 0)
                                       FROM itens_os WHERE ordem_servico_id = @idOs),
                              solucao = IF(@solucao IS NULL, solucao, @solucao),
                              data_conclusao = CASE WHEN @statusNovo = 'CONCLUIDA' THEN NOW() ELSE data_conclusao END
                          WHERE id = @idOs", con, tran))
                            {
                                cmdUpd.Parameters.AddWithValue("@statusNovo", statusNovo);
                                cmdUpd.Parameters.AddWithValue("@idOs", idOs);
                                cmdUpd.Parameters.AddWithValue("@solucao", (object)solucao ?? DBNull.Value);
                                cmdUpd.ExecuteNonQuery();
                            }
                            // Registra a alteração no histórico com o usuário logado na sessão
                            using (var cmdHist = new MySqlCommand(
                                @"INSERT INTO historico_os
                            (ordem_servico_id, status_anterior, status_novo,
                             usuario_id, data_alteracao, justificativa)
                          VALUES
                            (@os, @ant, @novo, @usr, NOW(), @just)", con, tran))
                            {
                                cmdHist.Parameters.AddWithValue("@os", idOs);
                                cmdHist.Parameters.AddWithValue("@ant", statusAnterior);
                                cmdHist.Parameters.AddWithValue("@novo", statusNovo);
                                cmdHist.Parameters.AddWithValue("@usr", Sessao.IdUsuario);
                                cmdHist.Parameters.AddWithValue("@just", justificativa);
                                cmdHist.ExecuteNonQuery();
                            }
                            tran.Commit();
                            MessageBox.Show("Status da OS nº " + idOs + " atualizado para " + statusNovo + "!",
                                "SIGOS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cbNovoStatusOs.SelectedIndex = -1;
                            PesquisarOS();
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
                    MessageBox.Show("Erro ao atualizar status: " + ex.Message,
                        "SIGOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Executa a busca com os filtros atuais ao clicar em Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarOS();
        }

        // Limpa os filtros e recarrega a lista de ordens de serviço
        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            LimparFiltros();
            PesquisarOS();
        }

        // Aplica o novo status selecionado à ordem de serviço escolhida na grade
        private void btnAlterarStatus_Click(object sender, EventArgs e)
        {
            AtualizarStatusOSSelecionada();
        }

        private void lblAdicionarItens_Click(object sender, EventArgs e)
        {
        }

        // Abre o menu principal e fecha a tela atual de consulta
        private void btnSalvarServico_Click(object sender, EventArgs e)
        {
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btnMenuPrincipal_Click_1(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}