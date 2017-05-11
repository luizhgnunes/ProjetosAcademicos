using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;



namespace SmallRoadWeb.DAL
{
    // Esta classe é responsável por criar uma conexão com o banco de dados de forma genérica
    public class Connection
    {
        private static string connString = @"Server=bd-small-road.mysql.uhserver.com;Database=bd_small_road;User Id=smallroadapp;Password=grgfg2017*FG;";
        private static SqlConnection conn = null; // Objeto que vai receber a conexão

        /// <summary>
        /// Abre uma conexão com o banco de dados
        /// </summary>
        /// <returns>Connection</returns>
        public static SqlConnection GetConnection()
        {
            conn = new SqlConnection(connString); // Cria conexão usando a os parametros da variavel connString

            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (SqlException exception)
            {
                conn = null;
                throw new Exception("A conexão com o banco de dados falhou." + exception.Message, exception.InnerException);
            }

            return conn;
        }

        /// <summary>
        /// Fecha a conexão com a base de dados quando não precisar mais
        /// </summary>
        public static void CloseConnection()
        {
            try
            {
                if (conn != null) // Se a conexão estiver estabelecida
                {
                    conn.Close(); // Fecha a conexão
                }
            }
            catch (Exception exception)
            {

                throw new Exception("Não foi possível fechar a conexão com o banco de dados" + exception.Message, exception.InnerException);
            }
        }
    }
}