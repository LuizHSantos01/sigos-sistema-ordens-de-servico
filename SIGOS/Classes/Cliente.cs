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
    public class Cliente
    {
        private int id;
        private string nome;
        private string documento;
        private string telefone;
        private string email;
        private string endereco;
        private bool ativo;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public bool Ativo
        {
            get { return ativo; }
            set { ativo = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        //
        //Validações
        //
        public string ValidarCadastroCliente()
        {
            if (string.IsNullOrWhiteSpace(nome))
                return "Informe o nome.";

            if (string.IsNullOrWhiteSpace(documento))
                return "Informe o CPF/CNPJ.";

            if (string.IsNullOrWhiteSpace(telefone))
                return "Informe o telefone.";

            if (string.IsNullOrWhiteSpace(email))
                return "Informe o email.";

            if (string.IsNullOrWhiteSpace(endereco))
                return "Informe o endereço.";

            //Validacao de [Ativo] feita em TelaCadastroDeClientes

            return "";
        }
        //
        //CRUD
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
                "INSERT INTO clientes " +
                "(nome, documento, telefone, email, endereco, ativo) VALUES (" +
                "'" + this.Nome + "'," + "'" + this.Documento + "'," +
                "'" + this.Telefone + "'," + "'" + this.Email + "'," +
                "'" + this.Endereco + "'," + ativo + ")";

            if (banco.TransacaoInserirRegistro(sql))
            {
                banco.CommitBanco();
                return true;
            }

            return false;
        }

        public bool Editar()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string ativo = "0";

            if (this.Ativo == true)
            {
                ativo = "1";
            }

            string sql =
                "UPDATE clientes SET " +"nome='" + this.Nome + "'," +
                "documento='" + this.Documento + "'," + "telefone='" + this.Telefone + "'," +
                "email='" + this.Email + "'," + "endereco='" + this.Endereco + "'," +
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

            string sql =
                "DELETE FROM clientes WHERE id = " + this.Id;

            if (banco.TransacaoExcluirRegistro(sql))
            {
                banco.CommitBanco();
                return true;
            }

            return false;
        }
        //
        //Tabela
        //
        public DataTable Pesquisar(string pesquisa)
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql ="SELECT * FROM clientes " + "WHERE documento LIKE '%" + pesquisa + "%'";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();
            tabela.Load(dados);

            return tabela;
        }
    }

}
