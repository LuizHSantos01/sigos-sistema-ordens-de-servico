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
    public partial class TelaCadastroDeClientes : Form
    {

        public TelaCadastroDeClientes()
        {
            InitializeComponent();
            CarregarClientes();
        }
        private int idClienteSelecionado;
        //
        //Crud
        //
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = txtNomeRazaoSocialCliente.Text;
            cliente.Documento = txtCPFCNPJCliente.Text;
            cliente.Telefone = txtContatoCliente.Text;
            cliente.Email = txtEmailCliente.Text;
            cliente.Endereco = txtEnderecoCliente.Text;
            cliente.Ativo = cbStatusCliente.Text == "Ativo";

            string erro = cliente.ValidarCadastroCliente();

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            if (cliente.Cadastrar())
                MessageBox.Show("Cliente cadastrado com sucesso!");

            CarregarClientes();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Id = idClienteSelecionado;

            cliente.Nome = txtNomeRazaoSocialCliente.Text;
            cliente.Documento = txtCPFCNPJCliente.Text;
            cliente.Telefone = txtContatoCliente.Text;
            cliente.Email = txtEmailCliente.Text;
            cliente.Endereco = txtEnderecoCliente.Text;
            cliente.Ativo = cbStatusCliente.Text == "Ativo";

            string erro = cliente.ValidarCadastroCliente();

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            if (cliente.Editar())
            {
                MessageBox.Show("Informações do cliente atualizadas");
                CarregarClientes();
            }
            else
            {
                MessageBox.Show("Erro ao editar cliente.");
            }

            CarregarClientes();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (idClienteSelecionado <= 0)
            {
                MessageBox.Show("Selecione um cliente na tabela.");
                return;
            }

            DialogResult resposta = MessageBox.Show("Deseja realmente excluir este cliente?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Cliente cliente = new Cliente();

                cliente.Id = idClienteSelecionado;

                if (cliente.Excluir())
                {
                    MessageBox.Show("Cliente excluído com sucesso!");

                    txtNomeRazaoSocialCliente.Clear();
                    txtCPFCNPJCliente.Clear();
                    txtContatoCliente.Clear();
                    txtEmailCliente.Clear();
                    txtEnderecoCliente.Clear();
                    cbStatusCliente.Text = "";
                    idClienteSelecionado = 0;

                    CarregarClientes();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cliente.");
                }
            }
        }

        //
        //Tabela
        //

        //Atualiza os dados da tabela
        private void CarregarClientes()
        {           
            ConexaoBanco banco = new ConexaoBanco();

            string sql = "SELECT * FROM clientes";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();
            tabela.Load(dados);

            dgvClientes.DataSource = tabela;
        }

        //Funcionalidade de clique para seleção nas linhas da tabela
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idClienteSelecionado = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["id"].Value);

                txtNomeRazaoSocialCliente.Text =dgvClientes.Rows[e.RowIndex].Cells["nome"].Value.ToString();

                txtCPFCNPJCliente.Text =dgvClientes.Rows[e.RowIndex].Cells["documento"].Value.ToString();

                txtContatoCliente.Text =dgvClientes.Rows[e.RowIndex].Cells["telefone"].Value.ToString();

                txtEmailCliente.Text =dgvClientes.Rows[e.RowIndex].Cells["email"].Value.ToString();

                txtEnderecoCliente.Text =dgvClientes.Rows[e.RowIndex].Cells["endereco"].Value.ToString();

                bool ativo = Convert.ToBoolean(dgvClientes.Rows[e.RowIndex].Cells["ativo"].Value);

                if (ativo)
                {
                    cbStatusCliente.Text = "Ativo";
                }
                else
                {
                    cbStatusCliente.Text = "Inativo";
                }

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            dgvClientes.DataSource =
                cliente.Pesquisar(txtPesquisar.Text);
        }
    }
}
