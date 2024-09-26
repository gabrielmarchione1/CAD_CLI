using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CAD_CLI.ENTIDADES
{
    /// <summary>
    /// Classe de apoio de join.
    /// </summary>
    public class CAD_CLI_TBL_JOIN
    {
        /// <summary>
        /// Classe telefone join cliente.
        /// </summary>
        public class TEL_CLIENTE
        {
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public int ID_TELEFONE {  get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string NOME_CLIENTE { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public int NUMERO_PAIS { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string NUMERO_DDD { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string NUMERO_TELEFONE { get; set; }
        }

        /// <summary>
        /// Classe email join cliente
        /// </summary>
        public class EMAIL_CLIENTE
        {
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public int ID_EMAIL { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string NOME_CLIENTE { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string ENDERECO_EMAIL {  get; set; }    
        }

        /// <summary>
        /// Classe endereço join cliente
        /// </summary>
        public class END_CLIENTE
        {
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public int ID_ENDERECO { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public int ID_CLIENTE { get; set; } 
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string NOME_CLIENTE { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string LOGRADOURO { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public int NUMERO_RUA { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string COMPLEMENTO { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string BAIRRO { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string CIDADE { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string UF { get; set; }
            /// <summary>
            /// Mapeamento LINQ
            /// </summary>
            public string CEP { get; set; }
        }
    }
}
