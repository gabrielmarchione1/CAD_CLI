using CAD_CLI.DADOS;
using CAD_CLI.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_CLI.NEGOCIOS
{
    /// <summary>
    /// Classe CRUD Négocios.
    /// </summary>
    public class CRUD_NEG
    {
        private readonly CAD_CLI.DADOS.CRUD_DADOS ObjDAD = new CAD_CLI.DADOS.CRUD_DADOS();

        #region CLIENTE

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_CLIENTE_ENT" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_CLIENTE_ENT> SELECT_CAD_CLI_TBL_CLIENTE_ENT(CAD_CLI_TBL_CLIENTE_ENT Ent)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_CLIENTE_ENT(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "INSERT_CAD_CLI_TBL_CLIENTE_ENT" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_CAD_CLI_TBL_CLIENTE_ENT(CAD_CLI_TBL_CLIENTE_ENT Ent)
        {
            try
            {
                ObjDAD.INSERT_CAD_CLI_TBL_CLIENTE_ENT(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "UPDATE_CAD_CLI_TBL_CLIENTE_ENT" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void UPDATE_CAD_CLI_TBL_CLIENTE_ENT(CAD_CLI_TBL_CLIENTE_ENT Ent)
        {
            try
            {
                ObjDAD.UPDATE_CAD_CLI_TBL_CLIENTE_ENT(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "DELETE_CAD_CLI_TBL_CLIENTE_ENT" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_CLIENTE_ENT(CAD_CLI_TBL_CLIENTE_ENT Ent)
        {
            try
            {
                ObjDAD.DELETE_CAD_CLI_TBL_CLIENTE_ENT(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "DELETE_CAD_CLI_TBL_CLIENTE_ENT_EM_LOTE" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_CLIENTE_ENT_EM_LOTE(List<CAD_CLI_TBL_CLIENTE_ENT> ListaEnt)
        {
            try
            {
                ObjDAD.DELETE_CAD_CLI_TBL_CLIENTE_ENT_EM_LOTE(ListaEnt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region ENDERECO

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_ENDERECO" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_ENDERECO_ENT> SELECT_CAD_CLI_TBL_ENDERECO(CAD_CLI_TBL_ENDERECO_ENT Ent)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_ENDERECO(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_ENDERECO_JOIN" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.END_CLIENTE> SELECT_CAD_CLI_TBL_ENDERECO_JOIN(CAD_CLI_TBL_ENDERECO_ENT Ent)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_ENDERECO_JOIN(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "INSERT_CAD_CLI_TBL_ENDERECO" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_CAD_CLI_TBL_ENDERECO(CAD_CLI_TBL_ENDERECO_ENT Ent)
        {
            try
            {
                ObjDAD.INSERT_CAD_CLI_TBL_ENDERECO(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "UPDATE_CAD_CLI_TBL_ENDERECO" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void UPDATE_CAD_CLI_TBL_ENDERECO(CAD_CLI_TBL_ENDERECO_ENT Ent)
        {
            try
            {
                ObjDAD.UPDATE_CAD_CLI_TBL_ENDERECO(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "DELETE_CAD_CLI_TBL_ENDERECO" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_ENDERECO(CAD_CLI_TBL_ENDERECO_ENT Ent)
        {
            try
            {
                ObjDAD.DELETE_CAD_CLI_TBL_ENDERECO(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "DELETE_CAD_CLI_TBL_ENDERECO_EM_LOTE" na camada de dados.
        /// </summary>
        /// <param name="ListaEnt"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_ENDERECO_EM_LOTE(List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT> ListaEnt)
        {
            try
            {
                ObjDAD.DELETE_CAD_CLI_TBL_ENDERECO_EM_LOTE (ListaEnt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region TELEFONE

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_TELEFONE" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_TELEFONE_ENT> SELECT_CAD_CLI_TBL_TELEFONE(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_TELEFONE(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_TELEFONE_JOIN" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.TEL_CLIENTE> SELECT_CAD_CLI_TBL_TELEFONE_JOIN(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_TELEFONE_JOIN(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_TELEFONE_EXISTENTE" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_TELEFONE_ENT> SELECT_CAD_CLI_TBL_TELEFONE_EXISTENTE(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_TELEFONE_EXISTENTE(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "INSERT_CAD_CLI_TBL_TELEFONE" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_CAD_CLI_TBL_TELEFONE(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                ObjDAD.INSERT_CAD_CLI_TBL_TELEFONE(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "UPDATE_CAD_CLI_TBL_TELEFONE" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void UPDATE_CAD_CLI_TBL_TELEFONE(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                ObjDAD.UPDATE_CAD_CLI_TBL_TELEFONE(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "DELETE_CAD_CLI_TBL_TELEFONE" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_TELEFONE(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                ObjDAD.DELETE_CAD_CLI_TBL_TELEFONE(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "DELETE_CAD_CLI_TBL_TELEFONE_EM_LOTE" na camada de dados.
        /// </summary>
        /// <param name="ListaEnt"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_TELEFONE_EM_LOTE(List<CAD_CLI_TBL_TELEFONE_ENT> ListaEnt)
        {
            try
            {
                ObjDAD.DELETE_CAD_CLI_TBL_TELEFONE_EM_LOTE(ListaEnt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region EMAIL

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_EMAIL" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_EMAIL_ENT> SELECT_CAD_CLI_TBL_EMAIL(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_EMAIL(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_EMAIL_JOIN" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.EMAIL_CLIENTE> SELECT_CAD_CLI_TBL_EMAIL_JOIN(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_EMAIL_JOIN(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_EMAIL_EXISTENTE" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_EMAIL_ENT> SELECT_CAD_CLI_TBL_EMAIL_EXISTENTE(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_EMAIL_EXISTENTE(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "INSERT_CAD_CLI_TBL_EMAIL" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_CAD_CLI_TBL_EMAIL(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                ObjDAD.INSERT_CAD_CLI_TBL_EMAIL(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "UPDATE_CAD_CLI_TBL_EMAIL" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void UPDATE_CAD_CLI_TBL_EMAIL(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                ObjDAD.UPDATE_CAD_CLI_TBL_EMAIL(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "DELETE_CAD_CLI_TBL_EMAIL" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_EMAIL(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                ObjDAD.DELETE_CAD_CLI_TBL_EMAIL(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "DELETE_CAD_CLI_TBL_EMAIL_EM_LOTE" na camada de dados.
        /// </summary>
        /// <param name="ListaEnt"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_EMAIL_EM_LOTE(List<CAD_CLI_TBL_EMAIL_ENT> ListaEnt)
        {
            try
            {
                ObjDAD.DELETE_CAD_CLI_TBL_EMAIL_EM_LOTE(ListaEnt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region LOGIN

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_LOGIN" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        //public List<CAD_CLI_TBL_LOGIN> SELECT_CAD_CLI_TBL_LOGIN(CAD_CLI_TBL_LOGIN Ent)
        //{
        //    try
        //    {
        //        return ObjDAD.SELECT_CAD_CLI_TBL_LOGIN(Ent);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_LOGIN" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public bool SELECT_CAD_CLI_TBL_LOGIN(string Usuario, string Senha)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_LOGIN(Usuario, Senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_LOGIN_EXISTENTE" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_LOGIN> SELECT_CAD_CLI_TBL_LOGIN_EXISTENTE(CAD_CLI_TBL_LOGIN Ent)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_LOGIN_EXISTENTE(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Faz chamada da função "INSERT_CAD_CLI_TBL_LOGIN" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_CAD_CLI_TBL_LOGIN(CAD_CLI_TBL_LOGIN Ent)
        {
            try
            {
                ObjDAD.INSERT_CAD_CLI_TBL_LOGIN(Ent);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region ADM

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_ADM" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        //public List<CAD_CLI_TBL_ADM> SELECT_CAD_CLI_TBL_ADM(CAD_CLI_TBL_ADM Ent)
        //{
        //    try
        //    {
        //        return ObjDAD.SELECT_CAD_CLI_TBL_ADM(Ent);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        /// <summary>
        /// Faz chamada da função "SELECT_CAD_CLI_TBL_ADM" na camada de dados.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool SELECT_CAD_CLI_TBL_ADM(string Usuario, string Senha)
        {
            try
            {
                return ObjDAD.SELECT_CAD_CLI_TBL_ADM(Usuario, Senha);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion
    }
}
