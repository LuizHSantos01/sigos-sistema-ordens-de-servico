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
    public partial class TelaCadastroDeClientes : Form
    {
        public TelaCadastroDeClientes()
        {
            InitializeComponent();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            TelaMenuPrincipal menu = new TelaMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void btnSalvarCliente_Click(object sender, EventArgs e)
        {
            ConexaoBanco banco = new ConexaoBanco();

            string ativo = "1";

            if (cbStatusCliente.Text == "Inativo")
                ativo = "0";

            string sql =
                "INSERT INTO clientes " +
                "(nome, documento, telefone, email, endereco, ativo) " +
                "VALUES (" +
                "'" + txtNomeRazaoSocialCliente.Text + "'," +
                "'" + txtCPFCNPJCliente.Text + "'," +
                "'" + txtContatoCliente.Text + "'," +
                "'" + txtEmailCliente.Text + "'," +
                "'" + txtEnderecoCliente.Text + "'," +
                ativo + ")";

            if (banco.TransacaoInserirRegistro(sql))
            {
                banco.CommitBanco();

                MessageBox.Show("cliente cadastrado");
            }
            else
            {
                MessageBox.Show("cliente não cadastrado");
            }
        }
    }
}
