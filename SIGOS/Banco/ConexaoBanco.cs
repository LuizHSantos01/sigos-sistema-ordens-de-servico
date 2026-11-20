using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIGOS.Banco
{
    public class ConexaoBanco
    {
        //
        //Classes sql para manipular o banco
        //
        public MySqlConnection conn = null;
        private MySqlCommand cmd = null;
        private MySqlTransaction trans = null;
        private MySqlDataReader reader = null;

        //
        // Construtor
        //
        public ConexaoBanco()
        {
            try
            {
                string config ="datasource=localhost;" + "username=root;" + "password=;" 
                    + "database=sigosdb;" + "AllowZeroDateTime=true;";

                this.conn = new MySqlConnection(config);
                this.cmd = this.conn.CreateCommand();
                this.conn.Open();

                if (this.conn.State == System.Data.ConnectionState.Open)
                {
                    this.trans = this.conn.BeginTransaction();

                    this.cmd.Connection = this.conn;
                    this.cmd.CommandTimeout = 99999;
                    this.cmd.Transaction = this.trans;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro na criação/abertura do banco de dados.\n" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exception:\n" + ex.Message);
                if (this.conn != null){this.conn.Close();this.conn = null;}
            }
        }

        //
        // Select
        //
        public MySqlDataReader TransacaoBusca(string sql)
        {
            try
            {
                this.cmd = new MySqlCommand(sql, this.conn);
                this.reader = this.cmd.ExecuteReader();
                return this.reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
                if (this.conn != null) { this.conn.Close(); this.conn = null; }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
                if (this.conn != null) { this.conn.Close(); this.conn = null; }
                return null;
            }
        }

        //
        //Insert
        //
        public bool TransacaoInserirRegistro(string sql)
        {
            try
            {
                this.cmd = new MySqlCommand(sql, this.conn);
                int res = this.cmd.ExecuteNonQuery();
                return (res > 0);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
                if (this.conn != null) { this.conn.Close(); }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
                if (this.conn != null) { this.conn.Close(); }
                return false;
            }
        }

        //
        //Update
        //

        public bool TransacaoAlterarRegistro(string sql)
        {
            try
            {
                this.cmd = new MySqlCommand(sql, this.conn);
                int res = this.cmd.ExecuteNonQuery();
                return (res > 0);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
                if (this.conn != null) { this.conn.Close(); }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
                if (this.conn != null) { this.conn.Close(); }
                return false;
            }
        }

        //
        //Delete
        //

        public bool TransacaoExcluirRegistro(string sql)
        {
            try
            {
                this.cmd = new MySqlCommand(sql, this.conn);
                int res = this.cmd.ExecuteNonQuery();
                return (res > 0);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro:\n" +ex.Message);
                if (this.conn != null) { this.conn.Close(); }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:\n" + ex.Message);
                if (this.conn != null) { this.conn.Close(); }
                return false;
            }
        }

        public void CommitBanco()
        {
            if (this.trans != null)
                this.trans.Commit();
        }
    }
}