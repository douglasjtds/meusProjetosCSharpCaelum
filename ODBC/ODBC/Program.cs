using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace ODBC
{
    class InsereEditora
    {
        public static void Main(string[] args)
        {

            //substituir as informações aqui
            string stringDeConexao = @" driver ={ SQL Server };
                server = SRVFABRICA02\SQLEXPRESS; database = Testes.Estagio_Livraria; uid = rumohomolog01; pwd = @rumo123;";

            System.Console.Write("Digite o nome da Editora: ");
            string nome = System.Console.ReadLine();

            System.Console.Write("Digite o Email da editora: ");
            string email = System.Console.ReadLine();

            string textoInsereEditora = 
                @"INSERT INTO Table_Editoras (Nome, Email)
                VALUES ('" + nome + @"', '" + email + @"')";

            using (OdbcConnection conexao = new OdbcConnection(stringDeConexao))
            {
                OdbcCommand command = new OdbcCommand(textoInsereEditora, conexao);
                conexao.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}