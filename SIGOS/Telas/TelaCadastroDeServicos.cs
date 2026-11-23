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
    public partial class TelaCadastroDeServicos : Form
    {
        public TelaCadastroDeServicos()
        {
            InitializeComponent();
            CarregarServicos();
        }

        private void CarregarServicos()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql = "SELECT * FROM servicos";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();

            tabela.Load(dados);

            dgvTecnico.DataSource = tabela;
        }
        private void lblDadosPessoaisEmpresa_Click(object sender, EventArgs e)
        {

        }
        
        private int idServicoSelecionado;

        private void dgvTecnico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idServicoSelecionado =Convert.ToInt32(dgvTecnico.Rows[e.RowIndex].Cells["id"].Value);

                txtDescricaoServico.Text =dgvTecnico.Rows[e.RowIndex].Cells["descricao"].Value.ToString();

                txtPrecoUnitarioServico.Text =dgvTecnico.Rows[e.RowIndex].Cells["preco"].Value.ToString();

                bool ativo =Convert.ToBoolean(dgvTecnico.Rows[e.RowIndex].Cells["ativo"].Value);

                if (ativo)
                {
                    cbStatusServico.Text = "Ativo";
                }
                else
                {
                    cbStatusServico.Text = "Inativo";
                }
                ;
            }
        }

        private void btnSalvarServico_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();

            servico.Descricao = txtDescricaoServico.Text;
            servico.Preco = Convert.ToDecimal(txtPrecoUnitarioServico.Text);
            servico.Ativo = cbStatusServico.Text == "Ativo";

            string erro = servico.ValidarCadastroServico();

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            if (servico.Cadastrar())
            {
                MessageBox.Show("Serviço cadastrado com sucesso!");
                CarregarServicos();
            }
        }

        private void btnEditarServico_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();

            servico.Id = idServicoSelecionado;
            servico.Descricao = txtDescricaoServico.Text;
            servico.Preco = Convert.ToDecimal(txtPrecoUnitarioServico.Text);
            servico.Ativo = cbStatusServico.Text == "Ativo";

            string erro = servico.ValidarCadastroServico();

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            if (servico.Alterar())
            {
                MessageBox.Show("Serviço alterado com sucesso!");
                CarregarServicos();
            }
        }

        private void btnExcluirServico_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();

            servico.Id = idServicoSelecionado;

            if (servico.Excluir())
            {
                MessageBox.Show("Serviço excluído com sucesso!");
                CarregarServicos();
            }
        }

        private void btnLimparFormulario_Click(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();

            dgvTecnico.DataSource =
                servico.Pesquisar(txtPesquisar.Text);
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}
