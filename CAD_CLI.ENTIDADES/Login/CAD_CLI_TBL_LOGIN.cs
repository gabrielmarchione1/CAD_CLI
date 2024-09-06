using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace CAD_CLI.ENTIDADES
{
    /// <summary>
    /// Classe CAD_CLI_TBL_LOGIN
    /// </summary>
    [Table(Name = "CAD_CLI_TBL_LOGIN")]
    public class CAD_CLI_TBL_LOGIN
    {
        int _ID_USUARIO;
        /// <summary>
        /// COLUNA ID_USUARIO
        /// </summary>
        [Column(Storage = "_ID_USUARIO", IsPrimaryKey=true, IsDbGenerated=true)]
        public int ID_USUARIO { get { return _ID_USUARIO; } set { _ID_USUARIO = value; } }

        string _NOME_USUARIO;
        /// <summary>
        /// COLUNA NOME_USUARIO
        /// </summary>
        [Column(Storage = "_NOME_USUARIO", CanBeNull = false)]
        public string NOME_USUARIO { get { return _NOME_USUARIO; } set { _NOME_USUARIO = value; } }

        string _SENHA_USUARIO;
        /// <summary>
        /// COLUNA SENHA_USUARIO
        /// </summary>
        [Column(Storage = "_SENHA_USUARIO", CanBeNull = false)]
        public string SENHA_USUARIO { get { return _SENHA_USUARIO; } set { _SENHA_USUARIO = value; } }
    }
}
