using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD_CLI.ENTIDADES
{
    /// <summary>
    /// Classe CAD_CLI_TBL_CLIENTE
    /// </summary>
    [Table(Name = "CAD_CLI_TBL_CLIENTE")]
    public class CAD_CLI_TBL_CLIENTE_ENT
    {
        int _ID_CLIENTE;
        /// <summary>
        /// COLUNA ID_CLIENTE
        /// </summary>
        [Column(Storage = "_ID_CLIENTE", IsPrimaryKey=true, IsDbGenerated=true)]
        public int ID_CLIENTE { get { return _ID_CLIENTE; } set { _ID_CLIENTE = value; } }

        string _NOME_CLIENTE;
        /// <summary>
        /// COLUNA NOME_CLIENTE
        /// </summary>
        [Column(Storage = "_NOME_CLIENTE", CanBeNull = false)]
        public string NOME_CLIENTE { get { return _NOME_CLIENTE; } set { _NOME_CLIENTE = value; } }

        string _CPF_CLIENTE;
        /// <summary>
        /// COLUNA CPF_CLIENTE
        /// </summary>
        [Column(Storage = "_CPF_CLIENTE", CanBeNull = false)]
        public string CPF_CLIENTE { get { return _CPF_CLIENTE; } set { _CPF_CLIENTE = value; } }

        string _CPF_CONTROLE;
        /// <summary>
        /// COLUNA CPF_CONTROLE
        /// </summary>
        [Column(Storage = "_CPF_CONTROLE", CanBeNull = false)]
        public string CPF_CONTROLE { get { return _CPF_CONTROLE; } set { _CPF_CONTROLE = value; } }

        DateTime _DATA_NASCIMENTO;
        /// <summary>
        /// COLUNA DATA_NASCIMENTO
        /// </summary>
        [Column(Storage = "_DATA_NASCIMENTO", CanBeNull = false)]
        public DateTime DATA_NASCIMENTO { get { return _DATA_NASCIMENTO; } set { _DATA_NASCIMENTO = value; } }
    }
}
