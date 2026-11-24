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
    public class HistoricoOS
    {
        private int id;
        private int ordemServicoId;
        private int usuarioId;
        private string statusAnterior;
        private string statusNovo;
        private string justificativa;
        private DateTime dataAlteracao;

        public int Id
        {
            get { return id; } 
            set {id = value; }   
        }
        public int OrdemServicoId
        {
            get { return ordemServicoId; }
            set { ordemServicoId = value; }
        }
        public int UsuarioId
        {
            get { return usuarioId; }
            set { usuarioId = value; }
        }
        public string StatusAnterior
        {
            get { return statusAnterior; }
            set { statusAnterior = value; }

        }
        public string StatusNovo
        {
            get { return statusNovo; }  
            set { statusNovo = value; }
        }
        public DateTime DataAlteracao
        {
            get { return dataAlteracao; }
            set { dataAlteracao = value; }
                
        }

        public DataTable PesquisarHistorico(int ordemServicoId)
        {
            ConexaoBanco banco = new ConexaoBanco();

            string sql = "SELECT * FROM historico_os " +
                "WHERE ordem_servico_id = " + ordemServicoId;

            MySqlDataReader dados = banco.TransacaoBusca(sql);

            DataTable tabela = new DataTable();

            tabela.Load(dados);

            return tabela;
        }
    }
}
