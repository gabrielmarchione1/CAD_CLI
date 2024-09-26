using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_CLI.ENTIDADES
{
    /// <summary>
    /// Classe CAD_CLI_TBL_TELEFONE
    /// </summary>
    [Table(Name = "CAD_CLI_TBL_TELEFONE")]
    public class CAD_CLI_TBL_TELEFONE_ENT
    {
        int _ID_TELEFONE;
        /// <summary>
        /// COLUNA ID_TELEFONE
        /// </summary>
        [Column(Storage = "_ID_TELEFONE", IsPrimaryKey=true, IsDbGenerated=true)]
        public int ID_TELEFONE { get { return _ID_TELEFONE; } set { _ID_TELEFONE = value; } }

        int _ID_CLIENTE;
        /// <summary>
        /// COLUNA ID_CLIENTE
        /// </summary>
        [Column(Storage = "_ID_CLIENTE", CanBeNull = false)]
        public int ID_CLIENTE { get { return _ID_CLIENTE; } set { _ID_CLIENTE = value; } }

        int _NUMERO_PAIS;
        /// <summary>
        /// COLUNA NUMERO_PAIS
        /// </summary>
        [Column(Storage = "_NUMERO_PAIS", CanBeNull = false)]
        public int NUMERO_PAIS { get { return _NUMERO_PAIS; } set { _NUMERO_PAIS = value; } }

        string _NUMERO_DDD;
        /// <summary>
        /// COLUNA NUMERO_DDD
        /// </summary>
        [Column(Storage = "_NUMERO_DDD", CanBeNull = false)]
        public string NUMERO_DDD { get { return _NUMERO_DDD; } set { _NUMERO_DDD = value; } }

        string _NUMERO_TELEFONE;
        /// <summary>
        /// COLUNA NUMERO_TELEFONE
        /// </summary>
        [Column(Storage = "_NUMERO_TELEFONE", CanBeNull = false)]
        public string NUMERO_TELEFONE { get { return _NUMERO_TELEFONE; } set { _NUMERO_TELEFONE = value; } }
    }
}
