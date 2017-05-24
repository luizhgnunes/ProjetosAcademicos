using MySql.Data.MySqlClient;
using SmallRoadWeb.Controllers;
using SmallRoadWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.DAL
{
    public class UsuarioDal
    {
        /// <summary>
        /// Realiza o login de um usuário
        /// </summary>
        /// <returns>true or false</returns>
        internal bool Logar(Usuario usuario)
        {
            MySqlConnection conn = Connection.GetConnection(); // Abre a conexão com o banco de dados
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT 1 FROM tb_usuario WHERE usu_login = @Login AND usu_senha = @Senha"; // SQL
                cmd.Parameters.AddWithValue("@Login", usuario.Login);
                cmd.Parameters.AddWithValue("@Senha", GerarHashMd5(usuario.Senha));
                MySqlDataReader dados = cmd.ExecuteReader(); // Aguarda o resltado em um data Reader

                //HttpContext.Current.Session["Logado"] = "true";

                UsuarioController.Logado = dados.HasRows;

                return dados.HasRows;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    Connection.CloseConnection();
            }
        }

        private string GerarHashMd5(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}