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

            if (banco.conn == null)
            {
                return;
            }

            string sql = "SELECT id FROM usuarios " + "WHERE login = @login AND senha_hash = SHA2(@senha, 256) AND ativo = 1";

            MySqlCommand cmd = new MySqlCommand(sql, banco.conn);
            cmd.Parameters.AddWithValue("@login", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            MySqlDataReader dados = cmd.ExecuteReader();

            if (dados.Read())
            {
                Sessao.IdUsuario = Convert.ToInt32(dados["id"]);
                dados.Close();

                MessageBox.Show("Bem vindo ao SIGOS");
                TelaMenuPrincipal menu = new TelaMenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                dados.Close();
                MessageBox.Show("Usuario ou senha incorretos");
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
