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
    public class Equipamento
    {
        private int id;
        private int clienteId;
        private string tipo;
        private string marca;
        private string modelo;
        private string numeroSerie;
        private string defeitoInformado;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int ClienteId
        {
            get { return clienteId; }
            set { clienteId = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }
        public string DefeitoInformado
        {
            get { return defeitoInformado; }
            set { defeitoInformado = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string ValidarCadastroEquipamento()
        {
            if (string.IsNullOrWhiteSpace(marca))
                return "Informe a marca.";

            if (string.IsNullOrWhiteSpace(tipo))
                return "Informe o tipo.";                      

            if (string.IsNullOrWhiteSpace(modelo))
                return "Informe o modelo.";

            return "";
        }

        public bool Cadastrar()
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql = "INSERT INTO equipamentos " + "(cliente_id, tipo, marca, modelo, numero_serie, defeito_informado) VALUES (" +
                this.ClienteId + "," +"'" + this.Tipo + "'," + "'" + this.Marca + "'," +
                "'" + this.Modelo + "'," + "'" + this.NumeroSerie + "'," + "'" + this.DefeitoInformado + "')";

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

            string sql ="UPDATE equipamentos SET " + "cliente_id=" + this.ClienteId + "," + "tipo='" + this.Tipo + "'," +
                "marca='" + this.Marca + "'," + "modelo='" + this.Modelo + "'," + "numero_serie='" + this.NumeroSerie + "'," +
                "defeito_informado='" + this.DefeitoInformado + "'" + " WHERE id=" + this.Id;

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

            string sql = "DELETE FROM equipamentos WHERE id=" + this.Id;

            if (banco.TransacaoExcluirRegistro(sql))
            {
                banco.CommitBanco();
                return true;
            }

            return false;
        }

        public DataTable PesquisarEquipamento(string pesquisa)
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql ="SELECT * FROM equipamentos " +"WHERE marca LIKE '%" + pesquisa + "%'" + " OR modelo LIKE '%" + pesquisa + "%'";

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();

            tabela.Load(dados);

            return tabela;
        }

    }
}
