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

namespace SIGOS.Telas
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ConexaoBanco banco = new ConexaoBanco();
            string sql = "SELECT * FROM usuarios " +"WHERE login = '" +
                txtUsuario.Text + "'" +" AND senha_hash = '" + txtSenha.Text +
                "'" +" AND ativo = 1";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            if (dados != null && dados.Read())
            {
                MessageBox.Show("Bem vindo ao SIGOS");
                TelaMenuPrincipal menu = new TelaMenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos");
            }

            //TelaMenuPrincipal telaMenuPrincipal = new TelaMenuPrincipal();
            //telaMenuPrincipal.Show();
        }
    }
}
