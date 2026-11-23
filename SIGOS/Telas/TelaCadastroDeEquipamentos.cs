using MySql.Data.MySqlClient;
using SIGOS.Banco;
using SIGOS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGOS.Telas
{
    public partial class TelaCadastroDeEquipamentos : Form
    {
        public TelaCadastroDeEquipamentos()
        {
            InitializeComponent();
            CarregarClientesCombo();
            CarregarEquipamentos();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btnSalvarEquipamento_Click(object sender, EventArgs e)
        {
            Equipamento equipamento = new Equipamento();

            equipamento.ClienteId = Convert.ToInt32(cbCliente.SelectedValue);
            equipamento.Tipo = cbTipo.Text;
            equipamento.Marca = txtMarca.Text;
            equipamento.Modelo = txtModelo.Text;
            equipamento.NumeroSerie = txtNumeroDeSerie.Text;
            equipamento.DefeitoInformado = txtDefeitoInformado.Text;

            string erro = equipamento.ValidarCadastroEquipamento();

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            if (equipamento.Cadastrar())
            {
                MessageBox.Show("Equipamento cadastrado com sucesso!");
                CarregarEquipamentos();
            }
        }

        private void btnEditarEquipamento_Click(object sender, EventArgs e)
        {
            Equipamento equipamento = new Equipamento();

            equipamento.Id = idEquipamentoSelecionado;
            equipamento.ClienteId = Convert.ToInt32(cbCliente.SelectedValue);
            equipamento.Tipo = cbTipo.Text;
            equipamento.Marca = txtMarca.Text;
            equipamento.Modelo = txtModelo.Text;
            equipamento.NumeroSerie = txtNumeroDeSerie.Text;
            equipamento.DefeitoInformado = txtDefeitoInformado.Text;

            string erro = equipamento.ValidarCadastroEquipamento();

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            if (equipamento.Editar())
            {
                MessageBox.Show("Equipamento atualizado");
                CarregarEquipamentos();
            }
        }

        private void btnExcluirEquipamento_Click(object sender, EventArgs e)
        {
            if (idEquipamentoSelecionado <= 0)
            {
                MessageBox.Show("Selecione um equipamento.");
                return;
            }

            DialogResult resposta = MessageBox.Show("Deseja realmente excluir este equipamento?","Confirmação",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Equipamento equipamento = new Equipamento();

                equipamento.Id = idEquipamentoSelecionado;

                if (equipamento.Excluir())
                {
                    MessageBox.Show("Equipamento excluído com sucesso!");
                    CarregarEquipamentos();
                }
            }
        }

        private void btnLimparFormulario_Click(object sender, EventArgs e)
        {

        }

        private int idEquipamentoSelecionado;
        private void dgvEquipamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idEquipamentoSelecionado =Convert.ToInt32(dgvEquipamento.Rows[e.RowIndex].Cells["id"].Value);

                cbCliente.SelectedValue =dgvEquipamento.Rows[e.RowIndex].Cells["cliente_id"].Value;

                cbTipo.Text =dgvEquipamento.Rows[e.RowIndex].Cells["tipo"].Value.ToString();

                txtMarca.Text =dgvEquipamento.Rows[e.RowIndex].Cells["marca"].Value.ToString();

                txtModelo.Text =dgvEquipamento.Rows[e.RowIndex].Cells["modelo"].Value.ToString();

                txtNumeroDeSerie.Text =dgvEquipamento.Rows[e.RowIndex].Cells["numero_serie"].Value.ToString();

                txtDefeitoInformado.Text =dgvEquipamento.Rows[e.RowIndex].Cells["defeito_informado"].Value.ToString();
            }
        }
        private void CarregarEquipamentos()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql = "SELECT * FROM equipamentos";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();

            tabela.Load(dados);

            dgvEquipamento.DataSource = tabela;
        }

        private void CarregarClientesCombo()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql = "SELECT id, nome FROM clientes";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();

            tabela.Load(dados);

            cbCliente.DataSource = tabela;
            cbCliente.DisplayMember = "nome";
            cbCliente.ValueMember = "id";
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
