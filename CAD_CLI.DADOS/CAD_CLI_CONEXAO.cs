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
        public CAD_CLI_CONEXAO() : base("Server=*servidor*;Database=*nome_db*;Trusted_Connection=True;") { }
    }
}
