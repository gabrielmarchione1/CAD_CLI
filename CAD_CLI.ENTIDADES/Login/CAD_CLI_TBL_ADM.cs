using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace CAD_CLI.ENTIDADES
{
    /// <summary>
    /// Classe CAD_CLI_TBL_ADM
    /// </summary>
    [Table(Name= "CAD_CLI_TBL_ADM")]
    public class CAD_CLI_TBL_ADM
    {
        string _USUARIO_ADM;
        /// <summary>
        /// COLUNA USUARIO_ADM
        /// </summary>
        [Column(Storage="_USUARIO_ADM", CanBeNull=false)]
        public string USUARIO_ADM { get {  return _USUARIO_ADM; } set { _USUARIO_ADM = value; }}

        string _SENHA_ADM;
        /// <summary>
        /// COLUNA SENHA_ADM
        /// </summary>
        [Column(Storage = "_SENHA_ADM", CanBeNull = false)]
        public string SENHA_ADM { get { return _SENHA_ADM; } set { _SENHA_ADM = value; } }
    }
}
