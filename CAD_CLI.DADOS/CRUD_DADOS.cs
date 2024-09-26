using CAD_CLI.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_CLI.DADOS
{
    /// <summary>
    /// Classe de CRUD DADOS
    /// </summary>
    public class CRUD_DADOS
    {

        #region CLIENTE

        ///// <summary>
        ///// Método para consultar clientes.
        ///// </summary>
        ///// <param name="Ent"></param>
        ///// <returns></returns>
        ///// <exception cref="Exception"></exception>
        //public List<CAD_CLI_TBL_CLIENTE_ENT> SELECT_CAD_CLI_TBL_CLIENTE_ENT(CAD_CLI_TBL_CLIENTE_ENT Ent)
        //{
        //    try
        //    {
        //        using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
        //        {
        //            List<CAD_CLI_TBL_CLIENTE_ENT> listaClientes = (from TBL_CLI in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>()
        //                                                           where (TBL_CLI.CPF_CLIENTE == Ent.CPF_CLIENTE && TBL_CLI.CPF_CONTROLE == Ent.CPF_CONTROLE)
        //                                                           || (Ent.CPF_CLIENTE == 0 && Ent.CPF_CONTROLE == 0)
        //                                                           select TBL_CLI).ToList();
        //            return listaClientes;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        /// <summary>
        /// Método para consultar clientes.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_CLIENTE_ENT> SELECT_CAD_CLI_TBL_CLIENTE_ENT(CAD_CLI_TBL_CLIENTE_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    List<CAD_CLI_TBL_CLIENTE_ENT> listaClientes = (from TBL_CLI in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>()
                                                                   where (TBL_CLI.CPF_CLIENTE == Ent.CPF_CLIENTE && TBL_CLI.CPF_CONTROLE == Ent.CPF_CONTROLE)
                                                                   || (Ent.CPF_CLIENTE == null && Ent.CPF_CONTROLE == null)
                                                                   select TBL_CLI).ToList();
                    return listaClientes;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para inserir cliente.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_CAD_CLI_TBL_CLIENTE_ENT(CAD_CLI_TBL_CLIENTE_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>().InsertOnSubmit(Ent);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para alterar cliente.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void UPDATE_CAD_CLI_TBL_CLIENTE_ENT(CAD_CLI_TBL_CLIENTE_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    CAD_CLI_TBL_CLIENTE_ENT cliente = (from TBL_CLI in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>()
                                                       where TBL_CLI.ID_CLIENTE == Ent.ID_CLIENTE
                                                       select TBL_CLI).SingleOrDefault();

                    cliente.NOME_CLIENTE = Ent.NOME_CLIENTE;
                    //cliente.CPF_CLIENTE = Ent.CPF_CLIENTE;
                    //cliente.CPF_CONTROLE = Ent.CPF_CONTROLE;
                    //cliente.DATA_NASCIMENTO = Ent.DATA_NASCIMENTO;

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para deletar cliente.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_CLIENTE_ENT(CAD_CLI_TBL_CLIENTE_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    CAD_CLI_TBL_CLIENTE_ENT entidade = (from TBL_CLI in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>()
                                                        where TBL_CLI.ID_CLIENTE == Ent.ID_CLIENTE
                                                        select TBL_CLI).SingleOrDefault();

                    db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>().DeleteOnSubmit(entidade);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para deletar clientes em lote.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_CLIENTE_ENT_EM_LOTE(List<CAD_CLI_TBL_CLIENTE_ENT> ListaEnt)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    //List<int> idsParaDeletar = new List<int>();
                    //idsParaDeletar = ListaEnt.Select(x => x.ID_CLIENTE).ToList();

                    //List<CAD_CLI_TBL_CLIENTE_ENT> cliente = (from TBL_CLI in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>()
                    //                                         where idsParaDeletar.Contains(TBL_CLI.ID_CLIENTE)
                    //                                         select TBL_CLI).ToList();

                    //db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>().DeleteAllOnSubmit(cliente);
                    //db.SubmitChanges();

                    string idsParaDeletar = string.Join(", ", ListaEnt.Select(x => x.ID_CLIENTE).ToList());
                    string sql = "DELETE FROM dbo.CAD_CLI_TBL_CLIENTE WHERE ID_CLIENTE IN (" + idsParaDeletar + ")";
                    db.ExecuteCommand(sql);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region ENDERECO

        /// <summary>
        /// Método para consultar endereços.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_ENDERECO_ENT> SELECT_CAD_CLI_TBL_ENDERECO(CAD_CLI_TBL_ENDERECO_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    List<CAD_CLI_TBL_ENDERECO_ENT> listaEnderecos = (from TBL_END in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT>()
                                                                     where TBL_END.ID_CLIENTE == Ent.ID_CLIENTE
                                                                     || Ent.ID_CLIENTE == 0
                                                                     select TBL_END).ToList();
                    return listaEnderecos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método de consulta de endereço com cliente.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.END_CLIENTE> SELECT_CAD_CLI_TBL_ENDERECO_JOIN(CAD_CLI_TBL_ENDERECO_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    var listaEnderecos = (from TBL_END in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT>()
                                          join TBL_CLI in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>()
                                          on TBL_END.ID_CLIENTE equals TBL_CLI.ID_CLIENTE
                                          where TBL_END.ID_CLIENTE == Ent.ID_CLIENTE
                                          || Ent.ID_CLIENTE == 0
                                          select new
                                          {
                                              TBL_END.ID_ENDERECO,
                                              TBL_CLI.ID_CLIENTE,
                                              TBL_CLI.NOME_CLIENTE,
                                              TBL_END.LOGRADOURO,
                                              TBL_END.NUMERO_RUA,
                                              TBL_END.COMPLEMENTO,
                                              TBL_END.BAIRRO,
                                              TBL_END.CIDADE,
                                              TBL_END.UF,
                                              TBL_END.CEP
                                          }).ToList();

                    List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.END_CLIENTE> lista = new List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.END_CLIENTE>();
                    if (listaEnderecos != null)
                    {
                        foreach (var item in listaEnderecos)
                        {
                            lista.Add(new CAD_CLI_TBL_JOIN.END_CLIENTE
                            {
                                ID_ENDERECO = item.ID_ENDERECO,
                                ID_CLIENTE = item.ID_CLIENTE,
                                NOME_CLIENTE = item.NOME_CLIENTE,
                                LOGRADOURO = item.LOGRADOURO,
                                NUMERO_RUA = item.NUMERO_RUA,
                                COMPLEMENTO = item.COMPLEMENTO,
                                BAIRRO = item.BAIRRO,
                                CIDADE = item.CIDADE,
                                UF = item.UF,
                                CEP = item.CEP
                            });
                        }
                    }
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para inserir endereço.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_CAD_CLI_TBL_ENDERECO(CAD_CLI_TBL_ENDERECO_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT>().InsertOnSubmit(Ent);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para alterar endereço.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void UPDATE_CAD_CLI_TBL_ENDERECO(CAD_CLI_TBL_ENDERECO_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    CAD_CLI_TBL_ENDERECO_ENT endereco = (from TBL_END in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT>()
                                                         where TBL_END.ID_ENDERECO == Ent.ID_ENDERECO
                                                         select TBL_END).FirstOrDefault();
                    if (endereco != null)
                    {
                        endereco.ID_CLIENTE = Ent.ID_CLIENTE;
                        endereco.LOGRADOURO = Ent.LOGRADOURO;
                        endereco.NUMERO_RUA = Ent.NUMERO_RUA;
                        endereco.COMPLEMENTO = Ent.COMPLEMENTO;
                        endereco.BAIRRO = Ent.BAIRRO;
                        endereco.CIDADE = Ent.CIDADE;
                        endereco.UF = Ent.UF;
                        endereco.CEP = Ent.CEP;

                        db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT>().Context.SubmitChanges();
                    }

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para deletar endereço.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_ENDERECO(CAD_CLI_TBL_ENDERECO_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    CAD_CLI_TBL_ENDERECO_ENT entidade = (from TBL_END in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT>()
                                                         where TBL_END.ID_ENDERECO == Ent.ID_ENDERECO
                                                         select TBL_END).FirstOrDefault();

                    if (entidade != null)
                    {
                        db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT>().DeleteOnSubmit(entidade);
                        db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT>().Context.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para deletar endereços em lote.
        /// </summary>
        /// <param name="ListaEnt"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_ENDERECO_EM_LOTE(List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ENDERECO_ENT> ListaEnt)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    string idsParaDeletar = string.Join(", ", ListaEnt.Select(x => x.ID_ENDERECO).ToList());
                    string sql = "DELETE FROM dbo.CAD_CLI_TBL_ENDERECO WHERE ID_ENDERECO IN (" + idsParaDeletar + ")";
                    db.ExecuteCommand(sql);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region TELEFONE

        /// <summary>
        /// Método para consultar telefones.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_TELEFONE_ENT> SELECT_CAD_CLI_TBL_TELEFONE(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    List<CAD_CLI_TBL_TELEFONE_ENT> listaTelefones = (from TBL_TEL in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT>()
                                                                     where TBL_TEL.ID_CLIENTE == Ent.ID_CLIENTE
                                                                     || Ent.ID_CLIENTE == 0
                                                                     select TBL_TEL).ToList();
                    return listaTelefones;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método de consulta de telefone com cliente.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.TEL_CLIENTE> SELECT_CAD_CLI_TBL_TELEFONE_JOIN(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    var listaTelefones = (from TBL_TEL in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT>()
                                          join TBL_CLI in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>()
                                          on TBL_TEL.ID_CLIENTE equals TBL_CLI.ID_CLIENTE
                                          where TBL_TEL.ID_CLIENTE == Ent.ID_CLIENTE
                                          || Ent.ID_CLIENTE == 0
                                          select new
                                          {
                                              TBL_TEL.ID_TELEFONE,
                                              TBL_CLI.NOME_CLIENTE,
                                              TBL_TEL.NUMERO_PAIS,
                                              TBL_TEL.NUMERO_DDD,
                                              TBL_TEL.NUMERO_TELEFONE
                                          }).ToList();

                    List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.TEL_CLIENTE> lista = new List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.TEL_CLIENTE>();
                    if (listaTelefones != null)
                    {
                        foreach (var item in listaTelefones)
                        {
                            lista.Add(new CAD_CLI_TBL_JOIN.TEL_CLIENTE
                            {
                                ID_TELEFONE = item.ID_TELEFONE,
                                NOME_CLIENTE = item.NOME_CLIENTE,
                                NUMERO_PAIS = item.NUMERO_PAIS,
                                NUMERO_DDD = item.NUMERO_DDD,
                                NUMERO_TELEFONE = item.NUMERO_TELEFONE
                            });
                        }
                    }
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para consultar se o telefone existe.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_TELEFONE_ENT> SELECT_CAD_CLI_TBL_TELEFONE_EXISTENTE(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    List<CAD_CLI_TBL_TELEFONE_ENT> listaTelefones = (from TBL_TEL in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT>()
                                                                     where (TBL_TEL.NUMERO_DDD == Ent.NUMERO_DDD) && (TBL_TEL.NUMERO_TELEFONE == Ent.NUMERO_TELEFONE)
                                                                     || Ent.ID_CLIENTE == 0
                                                                     select TBL_TEL).ToList();
                    return listaTelefones;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para inserir telefone.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_CAD_CLI_TBL_TELEFONE(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT>().InsertOnSubmit(Ent);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para alterar telefone.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void UPDATE_CAD_CLI_TBL_TELEFONE(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    CAD_CLI_TBL_TELEFONE_ENT telefone = (from TBL_TEL in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT>()
                                                         where TBL_TEL.ID_TELEFONE == Ent.ID_TELEFONE
                                                         select TBL_TEL).FirstOrDefault();
                    if (telefone != null)
                    {
                        telefone.ID_CLIENTE = Ent.ID_CLIENTE;
                        telefone.NUMERO_PAIS = Ent.NUMERO_PAIS;
                        telefone.NUMERO_DDD = Ent.NUMERO_DDD;
                        telefone.NUMERO_TELEFONE = Ent.NUMERO_TELEFONE;

                        db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT>().Context.SubmitChanges();
                    }

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para deletar cliente.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_TELEFONE(CAD_CLI_TBL_TELEFONE_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    CAD_CLI_TBL_TELEFONE_ENT entidade = (from TBL_TEL in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT>()
                                                         where TBL_TEL.ID_TELEFONE == Ent.ID_TELEFONE
                                                         select TBL_TEL).FirstOrDefault();

                    if (entidade != null)
                    {
                        db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT>().DeleteOnSubmit(entidade);
                        db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_TELEFONE_ENT>().Context.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para excluir telefones em lote.
        /// </summary>
        /// <param name="ListaEnt"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_TELEFONE_EM_LOTE(List<CAD_CLI_TBL_TELEFONE_ENT> ListaEnt)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    string idsParaDeletar = string.Join(", ", ListaEnt.Select(x => x.ID_TELEFONE).ToList());
                    string sql = "DELETE FROM dbo.CAD_CLI_TBL_TELEFONE WHERE ID_TELEFONE IN (" + idsParaDeletar + ")";
                    db.ExecuteCommand(sql);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region EMAIL

        /// <summary>
        /// Método para consultar emails.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_EMAIL_ENT> SELECT_CAD_CLI_TBL_EMAIL(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    List<CAD_CLI_TBL_EMAIL_ENT> listaEmails = (from TBL_EMAIL in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT>()
                                                               where TBL_EMAIL.ID_CLIENTE == Ent.ID_CLIENTE
                                                               || Ent.ID_CLIENTE == 0
                                                               select TBL_EMAIL).ToList();
                    return listaEmails;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método de consulta de email com cliente.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.EMAIL_CLIENTE> SELECT_CAD_CLI_TBL_EMAIL_JOIN(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    var listaEmails = (from TBL_EMAIL in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT>()
                                       join TBL_CLI in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_CLIENTE_ENT>()
                                       on TBL_EMAIL.ID_CLIENTE equals TBL_CLI.ID_CLIENTE
                                       where TBL_EMAIL.ID_CLIENTE == Ent.ID_CLIENTE
                                       || Ent.ID_CLIENTE == 0
                                       select new
                                       {
                                           TBL_EMAIL.ID_EMAIL,
                                           TBL_CLI.NOME_CLIENTE,
                                           TBL_EMAIL.ENDERECO_EMAIL
                                       }).ToList();

                    List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.EMAIL_CLIENTE> lista = new List<CAD_CLI.ENTIDADES.CAD_CLI_TBL_JOIN.EMAIL_CLIENTE>();
                    if (listaEmails != null)
                    {
                        foreach (var item in listaEmails)
                        {
                            lista.Add(new CAD_CLI_TBL_JOIN.EMAIL_CLIENTE
                            {
                                ID_EMAIL = item.ID_EMAIL,
                                NOME_CLIENTE = item.NOME_CLIENTE,
                                ENDERECO_EMAIL = item.ENDERECO_EMAIL
                            });
                        }
                    }
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para consultar se email já existe.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_EMAIL_ENT> SELECT_CAD_CLI_TBL_EMAIL_EXISTENTE(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    List<CAD_CLI_TBL_EMAIL_ENT> listaEmails = (from TBL_EMAIL in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT>()
                                                               where TBL_EMAIL.ENDERECO_EMAIL == Ent.ENDERECO_EMAIL
                                                               || Ent.ID_CLIENTE == 0
                                                               select TBL_EMAIL).ToList();
                    return listaEmails;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para inserir email.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_CAD_CLI_TBL_EMAIL(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT>().InsertOnSubmit(Ent);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para alterar email.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void UPDATE_CAD_CLI_TBL_EMAIL(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    CAD_CLI_TBL_EMAIL_ENT email = (from TBL_EMAIL in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT>()
                                                   where TBL_EMAIL.ID_EMAIL == Ent.ID_EMAIL
                                                   select TBL_EMAIL).FirstOrDefault();
                    if (email != null)
                    {
                        email.ID_CLIENTE = Ent.ID_CLIENTE;
                        email.ENDERECO_EMAIL = Ent.ENDERECO_EMAIL;

                        db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT>().Context.SubmitChanges();
                    }

                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para deletar email.
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_EMAIL(CAD_CLI_TBL_EMAIL_ENT Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    CAD_CLI_TBL_EMAIL_ENT entidade = (from TBL_EMAIL in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT>()
                                                      where TBL_EMAIL.ID_EMAIL == Ent.ID_EMAIL
                                                      select TBL_EMAIL).FirstOrDefault();

                    if (entidade != null)
                    {
                        db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT>().DeleteOnSubmit(entidade);
                        db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_EMAIL_ENT>().Context.SubmitChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para deletar emails em lote.
        /// </summary>
        /// <param name="ListaEnt"></param>
        /// <exception cref="Exception"></exception>
        public void DELETE_CAD_CLI_TBL_EMAIL_EM_LOTE(List<CAD_CLI_TBL_EMAIL_ENT> ListaEnt)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    string idsParaDeletar = string.Join(", ", ListaEnt.Select(x => x.ID_EMAIL).ToList());
                    string sql = "DELETE FROM dbo.CAD_CLI_TBL_EMAIL WHERE ID_EMAIL IN (" + idsParaDeletar + ")";
                    db.ExecuteCommand(sql);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region LOGIN

        /// <summary>
        /// Método para consultar usuários (Login).
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        //public List<CAD_CLI_TBL_LOGIN> SELECT_CAD_CLI_TBL_LOGIN(CAD_CLI_TBL_LOGIN Ent)
        //{
        //    try
        //    {
        //        using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
        //        {
        //            List<CAD_CLI_TBL_LOGIN> listaUsuarios = (from TBL_LOGIN in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_LOGIN>()
        //                                                     where (TBL_LOGIN.NOME_USUARIO == Ent.NOME_USUARIO) && (TBL_LOGIN.SENHA_USUARIO == Ent.SENHA_USUARIO)
        //                                                     select TBL_LOGIN).ToList();
        //            return listaUsuarios;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        /// <summary>
        /// Método para consultar usuários (Login).
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public bool SELECT_CAD_CLI_TBL_LOGIN(string Usuario, string Senha)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(CAD_CLI.DADOS.CAD_CLI_CONEXAO.connectionString);
            conn.Open();

            try
            {
                // Query SQL com collation case-sensitive
                string sql = $@"
                                DECLARE @usuario VARCHAR(25) = '{Usuario}'
                                DECLARE @senha VARCHAR(25) = '{Senha}'

                                SELECT * 
                                FROM CAD_CLI_TBL_LOGIN
                                WHERE NOME_USUARIO COLLATE Latin1_General_CS_AS = @usuario
                                AND SENHA_USUARIO COLLATE Latin1_General_CS_AS = @senha;
                                ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Executa a consulta e obtém os resultados
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Retorna true se houver resultados, false caso contrário
                        return reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para consultar se o usuário já existe.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public List<CAD_CLI_TBL_LOGIN> SELECT_CAD_CLI_TBL_LOGIN_EXISTENTE(CAD_CLI_TBL_LOGIN Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    List<CAD_CLI_TBL_LOGIN> listaUsuarios = (from TBL_LOGIN in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_LOGIN>()
                                                             where TBL_LOGIN.NOME_USUARIO == Ent.NOME_USUARIO
                                                             select TBL_LOGIN).ToList();
                    return listaUsuarios;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Método para inserir usuário (Login).
        /// </summary>
        /// <param name="Ent"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_CAD_CLI_TBL_LOGIN(CAD_CLI_TBL_LOGIN Ent)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_LOGIN>().InsertOnSubmit(Ent);
                    db.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        #region ADM

        /// <summary>
        /// Método para consultar ADMs.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        //public List<CAD_CLI_TBL_ADM> SELECT_CAD_CLI_TBL_ADM(CAD_CLI_TBL_ADM Ent)
        //{
        //    try
        //    {
        //        using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
        //        {
        //            List<CAD_CLI_TBL_ADM> listaAdms = (from TBL_ADM in db.GetTable<CAD_CLI.ENTIDADES.CAD_CLI_TBL_ADM>()
        //                                               where TBL_ADM.USUARIO_ADM == Ent.USUARIO_ADM && TBL_ADM.SENHA_ADM == Ent.SENHA_ADM
        //                                               select TBL_ADM).ToList();
        //            return listaAdms;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message.ToString());
        //    }
        //}

        /// <summary>
        /// Método para consultar ADMs.
        /// </summary>
        /// <param name="Ent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool SELECT_CAD_CLI_TBL_ADM(string Usuario, string Senha)
        {
            // Cria a conexão com o banco
            SqlConnection conn = new SqlConnection(CAD_CLI.DADOS.CAD_CLI_CONEXAO.connectionString);
            conn.Open();

            try
            {
                // Query SQL com collation case-sensitive
                string sql = $@"
                    DECLARE @usuario VARCHAR(25) = '{Usuario}'
                    DECLARE @senha VARCHAR(25) = '{Senha}'

                    SELECT * 
                    FROM CAD_CLI_TBL_ADM
                    WHERE USUARIO_ADM COLLATE Latin1_General_CS_AS = @usuario
                    AND SENHA_ADM COLLATE Latin1_General_CS_AS = @senha;
                    ";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Executa a consulta e obtém os resultados
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Retorna true se houver resultados, false caso contrário
                        return reader.HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        #endregion

        /// <summary>
        /// Função generica de bulkcopy.
        /// </summary>
        /// <param name="NomeTabela"></param>
        /// <param name="DtDados"></param>
        /// <exception cref="Exception"></exception>
        public void INSERT_BULKCOPY(string NomeTabela, DataTable DtDados)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    db.INSERT_DT_BULKCOPY(NomeTabela, DtDados);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// Função generica de execução de procedure sem retorno.
        /// </summary>
        /// <param name="NomeProcedure"></param>
        /// <param name="prms"></param>
        /// <exception cref="Exception"></exception>
        public void EXECUTA_SP_SEM_RETORNO(string NomeProcedure, SqlParameter[] Prms = null)
        {
            try
            {
                using (CAD_CLI.DADOS.CAD_CLI_CONEXAO db = new CAD_CLI_CONEXAO())
                {
                    db.EXECUTA_SP_SEM_RETORNO(NomeProcedure, Prms);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
