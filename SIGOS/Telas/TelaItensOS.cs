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
    public partial class TelaItensOS : Form
    {
        public TelaItensOS()
        {
            InitializeComponent();
            CarregarServicos();
        }

        private int idOS;
        private int idItemSelecionado;

        public TelaItensOS(int ordemServicoId)
        {
            InitializeComponent();
            idOS = ordemServicoId;
            CarregarServicos();
        }

        private void CarregarServicos()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql ="SELECT id, descricao, preco " +"FROM servicos " + "WHERE ativo = 1";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();

            tabela.Load(dados);

            cbServico.DataSource = tabela;
            cbServico.DisplayMember = "descricao";
            cbServico.ValueMember = "id";
        }
        private void CarregarItens()
        {
            ItensOS item = new ItensOS();

            dgvItensServico.DataSource =
                item.PesquisarItensOS(idOS);

            AtualizarTotal();
        }
        private void AtualizarTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow linha in dgvItensServico.Rows)
            {
                if (linha.Cells["subtotal"].Value != null)
                {
                    total += Convert.ToDecimal(linha.Cells["subtotal"].Value);
                }
            }
            txtTotalOS.Text = total.ToString("N2");
        }

        private void btnAdicionarServico_Click(object sender, EventArgs e)
        {
            ItensOS item = new ItensOS();
            item.OrdemServicoId = idOS;
            item.ServicoId =Convert.ToInt32(cbServico.SelectedValue);
            item.Quantidade =Convert.ToDecimal(txtQuantidadeServico.Text);
            item.PrecoUnitario =Convert.ToDecimal(txtPrecoUnitario.Text);

            if (item.Adicionar())
            {
                CarregarItens();
            }
        }

        private void cbServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbServico.SelectedValue == null || cbServico.SelectedValue is DataRowView) 
            {
                return;
            }

            DataRowView linha =(DataRowView)cbServico.SelectedItem;

            txtPrecoUnitario.Text =linha["preco"].ToString();
        }

        private void dgvItensServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idItemSelecionado =Convert.ToInt32(dgvItensServico.Rows[e.RowIndex].Cells["id"].Value);
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            ItensOS item = new ItensOS();
            item.Id = idItemSelecionado;
            if (item.Excluir())
            {
                CarregarItens();
            }
        }
    }
}
