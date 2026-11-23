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
    public class Servico
    {
        private int id;
        private string descricao;
        private decimal preco;
        private bool ativo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public string ValidarCadastroServico()
        {
            if (string.IsNullOrWhiteSpace(descricao))
            {
                return "Informe a descrição do servico";
            }

            if (preco < 0) 
            { 
                return "Preço inválido."; 
            }               

            return "";
        }

        public bool Cadastrar()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string ativo;

            if (this.Ativo)
                ativo = "1";
            else
                ativo = "0";

            string sql ="INSERT INTO servicos " +"(descricao, preco, ativo) VALUES (" +
                "'" + this.Descricao + "'," + this.Preco.ToString().Replace(",", ".") + "," +
                ativo + ")";

            if (banco.TransacaoInserirRegistro(sql))
            {
                banco.CommitBanco();
                return true;
            }

            return false;
        }

        public bool Alterar()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string ativo;

            if (this.Ativo)
                ativo = "1";
            else
                ativo = "0";

            string sql ="UPDATE servicos SET " +"descricao='" + this.Descricao + "'," +
                "preco=" + this.Preco.ToString().Replace(",", ".") + "," + "ativo=" + ativo +
                " WHERE id=" + this.Id;

            if (banco.TransacaoAlterarRegistro(sql))
            {
                banco.CommitBanco();
                return true;
            }

            return false;
        }

        public bool Excluir()
        {
            ConexaoBanco banco = new ConexaoBanco();
            string sql ="DELETE FROM servicos WHERE id=" + this.Id;

            if (banco.TransacaoExcluirRegistro(sql))
            {
                banco.CommitBanco();
                return true;
            }

            return false;
        }

        public DataTable Pesquisar(string pesquisa)
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql ="SELECT * FROM servicos " + "WHERE descricao LIKE '%" + pesquisa + "%'";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();

            tabela.Load(dados);

            return tabela;
        }
    }
}
