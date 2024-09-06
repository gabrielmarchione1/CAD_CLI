using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace CAD_CLI.ENTIDADES
{
    /// <summary>
    /// Classe CAD_CLI_TBL_EMAIL
    /// </summary>
    [Table(Name = "CAD_CLI_TBL_EMAIL")]
    public class CAD_CLI_TBL_EMAIL_ENT
    {
        int _ID_EMAIL;
        /// <summary>
        /// COLUNA ID_EMAIL
        /// </summary>
        [Column(Storage = "_ID_EMAIL", IsPrimaryKey=true, IsDbGenerated=true)]
        public int ID_EMAIL { get { return _ID_EMAIL; } set { _ID_EMAIL = value; } }

        int _ID_CLIENTE;
        /// <summary>
        /// COLUNA ID_CLIENTE
        /// </summary>
        [Column(Storage = "_ID_CLIENTE", CanBeNull = false)]
        public int ID_CLIENTE { get { return _ID_CLIENTE; } set { _ID_CLIENTE = value; } }

        string _ENDERECO_EMAIL;
        /// <summary>
        /// COLUNA ENDERECO_EMAIL
        /// </summary>
        [Column(Storage = "_ENDERECO_EMAIL", CanBeNull = false)]
        public string ENDERECO_EMAIL { get { return _ENDERECO_EMAIL; } set { _ENDERECO_EMAIL = value; } }
    }
}
