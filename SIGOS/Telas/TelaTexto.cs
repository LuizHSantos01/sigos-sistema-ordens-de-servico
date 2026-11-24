using System;
using System.Windows.Forms;

namespace SIGOS.Telas
{
    public partial class TelaTexto : Form
    {
        public string TextoDigitado { get; private set; }

        public TelaTexto(string titulo, string mensagem)
        {
            InitializeComponent();
            this.Text = titulo;
            lblMensagem.Text = mensagem;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            TextoDigitado = txtTexto.Text.Trim();
        }
    }
}