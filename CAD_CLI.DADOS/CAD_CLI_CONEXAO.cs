using System;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;

namespace CAD_CLI.DADOS
{
    /// <summary>
    /// Classe de conexão
    /// </summary>
    class CAD_CLI_CONEXAO : DataContext
    {
        /// <summary>
        /// String de conexão
        /// </summary>
        public static string connectionString = "Server=*servidor*;Database=*nome_db*;Trusted_Connection=True;";
        /// <summary>
        /// String de conexão
        /// </summary>
        public CAD_CLI_CONEXAO() : base("Server=*servidor*;Database=*nome_db*;Trusted_Connection=True;") { }


        /// <summary>
        /// Função para bulkcopy de DataTable.
        /// </summary>
        /// <param name="NomeTabela"></param>
        /// <param name="Dt"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_DT_BULKCOPY(string NomeTabela, DataTable Dt)
        {
            try
            {
                using (var db = new CAD_CLI.DADOS.CAD_CLI_CONEXAO())
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(db.Connection.ConnectionString))
                    {
                        sqlBulkCopy.DestinationTableName = NomeTabela;
                        sqlBulkCopy.WriteToServer(Dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Função para executar uma procedure sem retorno.
        /// </summary>
        /// <param name="NomeProcedure"></param>
        /// <param name="Prms"></param>
        /// <exception cref="Exception"></exception>
        public void EXECUTA_SP_SEM_RETORNO(string NomeProcedure, SqlParameter[] Prms)
        {
            CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI.DADOS.CAD_CLI_CONEXAO();
            SqlConnection conn = new SqlConnection(db.Connection.ConnectionString);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(NomeProcedure, conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                if (Prms != null)
                {
                    cmd.Parameters.AddRange(Prms);
                }
                //cmd.Parameters.AddRange(Prms);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Função para executar uma procedure com retorno.
        /// </summary>
        /// <param name="NomeProcedure"></param>
        /// <param name="Prms"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable EXECUTA_SP_RETORNA_TABLE(string NomeProcedure, SqlParameter[] Prms = null)
        {
            CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI.DADOS.CAD_CLI_CONEXAO();
            SqlConnection conn = new SqlConnection(db.Connection.ConnectionString);
            try
            {
                conn.Open();

                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand(NomeProcedure, conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (Prms != null)
                    {
                        da.SelectCommand.Parameters.AddRange(Prms);
                    }

                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Função para executar uma procedure com retorno.
        /// </summary>
        /// <param name="NomeProcedure"></param>
        /// <param name="Prms"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataSet EXECUTA_SP_RETORNA_DATASET(string NomeProcedure, SqlParameter[] Prms = null)
        {
            CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI.DADOS.CAD_CLI_CONEXAO();
            SqlConnection conn = new SqlConnection(db.Connection.ConnectionString);
            try
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand(NomeProcedure, conn)
                    {
                        CommandType = CommandType.StoredProcedure,

                        CommandTimeout = 2100000000
                    };
                    if (Prms != null)
                    {
                        da.SelectCommand.Parameters.AddRange(Prms);
                    }

                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Função para executar uma procedure sem retorno.
        /// </summary>
        /// <param name="Comando"></param>
        public void EXECUTA_COMANDO_SQL(string Comando)
        {
            CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI.DADOS.CAD_CLI_CONEXAO();
            SqlConnection conn = new SqlConnection(db.Connection.ConnectionString);
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(Comando, conn)
                {
                    CommandType = CommandType.Text
                };
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Função para executar um comando com retorno.
        /// </summary>
        /// <param name="Comando"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataTable EXECUTA_COMANDO_RETORNA_TABLE(string Comando)
        {
            try
            {
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(new CAD_CLI.DADOS.CAD_CLI_CONEXAO().Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(Comando, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Função para executar um comando com retorno.
        /// </summary>
        /// <param name="Comando"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public DataSet EXECUTA_COMANDO_RETORNA_DATASET(string ComandoSql)
        {
            try
            {
                DataSet ds = new DataSet();

                using (SqlConnection connection = new SqlConnection(new CAD_CLI.DADOS.CAD_CLI_CONEXAO().Connection.ConnectionString))
                using (SqlCommand cmd = new SqlCommand(ComandoSql, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(ds);
                }

                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
