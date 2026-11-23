using MySql.Data.MySqlClient;
using SIGOS.Banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGOS.Classes
{
    public class ItensOS
    {
        private int id;
        private int ordemServicoId;
        private int servicoId;
        private decimal quantidade;
        private decimal precoUnitario;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int OrdemServicoId
        {
            get { return ordemServicoId; }
            set { ordemServicoId = value; }
        }
        public int ServicoId
        {
            get { return servicoId; }
            set { servicoId = value; }

        }
        public decimal Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public decimal PrecoUnitario
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }

        public bool Adicionar()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql ="INSERT INTO itens_os " + "(ordem_servico_id, servico_id, quantidade, preco_unitario) " +
                "VALUES (" +this.OrdemServicoId + "," + this.ServicoId + "," +
                this.Quantidade.ToString().Replace(",", ".") + "," +
                this.PrecoUnitario.ToString().Replace(",", ".") +")";

            if (banco.TransacaoInserirRegistro(sql))
            {
                banco.CommitBanco();
                return true;
            }

            return false;
        }

        public bool Excluir()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql ="DELETE FROM itens_os WHERE id = " + this.Id;

            if (banco.TransacaoExcluirRegistro(sql))
            {
                banco.CommitBanco();
                return true;
            }

            return false;
        }

        public DataTable PesquisarItensOS(int ordemServico)
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql =@"SELECT ios.id,s.descricao,ios.quantidade,ios.preco_unitario,
            (ios.quantidade * ios.preco_unitario) AS subtotal FROM itens_os ios INNER JOIN servicos s
            ON ios.servico_id = s.id WHERE ios.ordem_servico_id = " + ordemServico;

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();

            tabela.Load(dados);

            return tabela;
        }
    }
}
