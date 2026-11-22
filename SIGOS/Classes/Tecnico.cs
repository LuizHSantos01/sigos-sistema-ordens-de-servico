using MySql.Data.MySqlClient;
using SIGOS.Banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SIGOS.Classes
{
    public class Tecnico
    {
        private int id;
        private string nome;
        private string especialidade;
        private string telefone;
        private bool ativo;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Especialidade
        { 
            get { return especialidade; }
            set { especialidade = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        //
        //Validacoes
        //
        public string ValidarCadastroTecnico()
        {
            if (string.IsNullOrWhiteSpace(nome))
                return "Informe o nome.";

            if (string.IsNullOrWhiteSpace(telefone))
                return "Informe o telefone.";

            if (string.IsNullOrWhiteSpace(especialidade))
                return "Informe a especialidade.";

            //Validacao de [Ativo] feita em TelaCadastroDeClientes

            return "";
        }

        //
        //Crud
        //

        public bool Cadastrar()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string ativo;
            if (this.Ativo == true)
            {
                ativo = "1";
            }
            else
            {
                ativo = "0";
            }

            string sql =
                "INSERT INTO tecnicos " + "(nome, especialidade, telefone, ativo) VALUES (" +
                "'" + this.Nome + "'," + "'" + this.Especialidade + "'," +
                "'" + this.Telefone + "'," + ativo + ")";

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

            string ativo = "0";

            if (this.Ativo == true)
            {
                ativo = "1";
            }

            string sql =
                "UPDATE tecnicos SET " +"nome='" + this.Nome + "'," +
                "especialidade='" + this.Especialidade + "'," + "telefone='" + this.Telefone + "'," +
                "ativo=" + ativo + " WHERE id=" + this.Id;

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

            string sql = "DELETE FROM tecnicos WHERE id=" + this.Id;

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

            string sql = "SELECT * FROM tecnicos " + "WHERE nome LIKE '%" + pesquisa + "%'";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();

            tabela.Load(dados);

            return tabela;
        }

    }
}

