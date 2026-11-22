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
    public partial class TelaCadastroDeTecnicos : Form
    {
        public TelaCadastroDeTecnicos()
        {
            InitializeComponent();
            CarregarTecnicos();
        }

        private void lblNomeTecnico_Click(object sender, EventArgs e)
        {

        }

        private void CarregarTecnicos()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql = "SELECT * FROM tecnicos";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();

            tabela.Load(dados);

            dgvTecnico.DataSource = tabela;
        }

        
        private int idTecnicoSelecionado;
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            menu.Show();
            this.Close();
        }
        
        private void btnSalvarTecnico_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();

            tecnico.Nome = txtNomeTecnico.Text;
            tecnico.Especialidade = txtEspecialidadeTecnico.Text;
            tecnico.Telefone = txtTelefoneTecnico.Text;
            tecnico.Ativo = cbStatusTecnico.Text == "Ativo";

            string erro = tecnico.ValidarCadastroTecnico();

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            if (tecnico.Cadastrar())
            {
                MessageBox.Show("Técnico cadastrado com sucesso!");
                CarregarTecnicos();
            }
        }

        private void btnEditarTecnico_Click(object sender, EventArgs e)
        {
            Tecnico tecnico = new Tecnico();

            tecnico.Id = idTecnicoSelecionado;
            tecnico.Nome = txtNomeTecnico.Text;
            tecnico.Especialidade = txtEspecialidadeTecnico.Text;
            tecnico.Telefone = txtTelefoneTecnico.Text;
            tecnico.Ativo = cbStatusTecnico.Text == "Ativo";

            string erro = tecnico.ValidarCadastroTecnico();

            if (erro != "")
            {
                MessageBox.Show(erro);
                return;
            }

            if (tecnico.Alterar())
            {
                MessageBox.Show("Técnico alterado com sucesso!");
                CarregarTecnicos();
            }
        }

        private void btnExcluirTecnico_Click(object sender, EventArgs e)
        {
            if (idTecnicoSelecionado <= 0)
            {
                MessageBox.Show("Selecione um técnico.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este técnico?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Tecnico tecnico = new Tecnico();

                tecnico.Id = idTecnicoSelecionado;

                if (tecnico.Excluir())
                {
                    MessageBox.Show("Técnico excluído com sucesso!");
                    CarregarTecnicos();
                }
            }
        }

        private void btnLimparFormulario_Click(object sender, EventArgs e)
        {

        }

        private void dgvTecnico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idTecnicoSelecionado =
                    Convert.ToInt32(dgvTecnico.Rows[e.RowIndex].Cells["id"].Value);

                txtNomeTecnico.Text =
                    dgvTecnico.Rows[e.RowIndex].Cells["nome"].Value.ToString();

                txtEspecialidadeTecnico.Text =
                    dgvTecnico.Rows[e.RowIndex].Cells["especialidade"].Value.ToString();

                txtTelefoneTecnico.Text =
                    dgvTecnico.Rows[e.RowIndex].Cells["telefone"].Value.ToString();

                bool ativo =
                    Convert.ToBoolean(dgvTecnico.Rows[e.RowIndex].Cells["ativo"].Value);

                if (ativo)
                {
                    cbStatusTecnico.Text = "Ativo";
                }
                else
                {
                    cbStatusTecnico.Text = "Inativo";
                }
            }
        }
    }
}
