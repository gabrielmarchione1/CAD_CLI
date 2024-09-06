using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace CAD_CLI.ENTIDADES
{
    /// <summary>
    /// Classe CAD_CLI_TBL_ENDERECO
    /// </summary>
    [Table(Name = "CAD_CLI_TBL_ENDERECO")]
    public class CAD_CLI_TBL_ENDERECO_ENT
    {
        int _ID_ENDERECO;
        /// <summary>
        /// COLUNA ID_ENDERECO
        /// </summary>
        [Column(Storage = "_ID_ENDERECO", IsPrimaryKey=true, IsDbGenerated=true)]
        public int ID_ENDERECO { get { return _ID_ENDERECO; } set { _ID_ENDERECO = value; } }

        int _ID_CLIENTE;
        /// <summary>
        /// COLUNA ID_CLIENTE
        /// </summary>
        [Column(Storage = "_ID_CLIENTE", CanBeNull = false)]
        public int ID_CLIENTE { get { return _ID_CLIENTE; } set { _ID_CLIENTE = value; } }

        string _LOGRADOURO;
        /// <summary>
        /// COLUNA LOGRADOURO
        /// </summary>
        [Column(Storage = "_LOGRADOURO", CanBeNull = false)]
        public string LOGRADOURO { get { return _LOGRADOURO; } set { _LOGRADOURO = value; } }

        int _NUMERO_RUA;
        /// <summary>
        /// COLUNA NUMERO_RUA
        /// </summary>
        [Column(Storage = "_NUMERO_RUA", CanBeNull = false)]
        public int NUMERO_RUA { get { return _NUMERO_RUA; } set { _NUMERO_RUA = value; } }

        string _COMPLEMENTO;
        /// <summary>
        /// COLUNA COMPLEMENTO
        /// </summary>
        [Column(Storage = "_COMPLEMENTO", CanBeNull = true)]
        public string COMPLEMENTO { get { return _COMPLEMENTO; } set { _COMPLEMENTO = value; } }

        string _BAIRRO;
        /// <summary>
        /// COLUNA BAIRRO
        /// </summary>
        [Column(Storage = "_BAIRRO", CanBeNull = false)]
        public string BAIRRO { get { return _BAIRRO; } set { _BAIRRO = value; } }

        string _CIDADE;
        /// <summary>
        /// COLUNA CIDADE
        /// </summary>
        [Column(Storage = "_CIDADE", CanBeNull = false)]
        public string CIDADE { get { return _CIDADE; } set { _CIDADE = value; } }

        string _UF;
        /// <summary>
        /// COLUNA UF
        /// </summary>
        [Column(Storage = "_UF", CanBeNull = false)]
        public string UF { get { return _UF; } set { _UF = value; } }

        int _CEP;
        /// <summary>
        /// COLUNA CEP
        /// </summary>
        [Column(Storage = "_CEP", CanBeNull = false)]
        public int CEP { get { return _CEP; } set { _CEP = value; } }
    }
}
