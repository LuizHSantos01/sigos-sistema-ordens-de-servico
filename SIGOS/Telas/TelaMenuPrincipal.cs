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

namespace SIGOS.Telas
{
    public partial class TelaMenuPrincipal : Form
    {
        public TelaMenuPrincipal()
        {
            InitializeComponent();
        }

        //
        // Botões de navegação do menu
        //
        private void btnTelaClientes_Click(object sender, EventArgs e)
        {
            TelaCadastroDeClientes tela = new TelaCadastroDeClientes();
            tela.Show();
            this.Hide();
        }

        private void btnTelaTecnicos_Click(object sender, EventArgs e)
        {
            TelaCadastroDeTecnicos tela = new TelaCadastroDeTecnicos();
            tela.Show();
            this.Hide();
        }

        private void btnTelaEquipamentos_Click(object sender, EventArgs e)
        {
            TelaCadastroDeEquipamentos tela = new TelaCadastroDeEquipamentos();
            tela.Show();
            this.Hide();
        }

        private void btnTelaServicos_Click(object sender, EventArgs e)
        {
            TelaCadastroDeServicos tela = new TelaCadastroDeServicos();
            tela.Show();
            this.Hide();
        }

        private void btnTelaAbrirOS_Click(object sender, EventArgs e)
        {
            TelaAberturaDeOS tela = new TelaAberturaDeOS();
            tela.Show();
            this.Hide();
        }

        private void btnTelaConsulta_Click(object sender, EventArgs e)
        {
            TelaConsultaOS tela = new TelaConsultaOS();
            tela.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TelaHistoricoOS tela = new TelaHistoricoOS();
            tela.Show();
            this.Hide();
        }

        //
        //Botão de teste de conexão
        //
        private void btnTestarConexaoBanco_Click(object sender, EventArgs e)
        {
            ConexaoBanco banco = new ConexaoBanco();

            if (banco.conn != null &&
                banco.conn.State == System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Conectado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possível conectar.");
            }
        }
    }
}
