using MySql.Data.MySqlClient;
using SIGOS.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIGOS.Classes;

namespace SIGOS.Telas
{
    public partial class TelaHistoricoOS : Form
    {
        public TelaHistoricoOS()
        {
            InitializeComponent();
            CarregarHistorico();
        }

        private void CarregarHistorico()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql = "SELECT * FROM historico_os";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();

            tabela.Load(dados);

            dgvHistoricoOs.DataSource = tabela;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNumeroDaOS.Text.Trim() == "")
            {
                CarregarHistorico();
                return;
            }

            int numeroOS;

            if (!int.TryParse(txtNumeroDaOS.Text, out numeroOS))
            {
                MessageBox.Show("Informe apenas o número da OS.");
                return;
            }

            HistoricoOS historico = new HistoricoOS();

            dgvHistoricoOs.DataSource = historico.PesquisarHistorico(numeroOS);
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            menu.Show();
            this.Close();
        }
    }
}
