using MySql.Data.MySqlClient;
using SmallRoadWeb.Models.Entities;
using System;
using System.Data;

namespace SmallRoadWeb.DAL
{
    public class NotaFiscalDal
    {
        /// <summary>
        /// Cadastra uma nota fiscal
        /// </summary>
        /// <param name="notaFiscal">True se cadastro e False caso contrário.</param>
        /// <returns></returns>
        internal bool Cadastrar(NotaFiscal notaFiscal)
        {
            MySqlConnection conn = Connection.GetConnection(); // Abre a conexão com o banco de dados
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO tb_nota_fiscal (NF_DATA, NF_PRAZO_ENTREGA, DES_ID) VALUES (@Data, @PrazoEntrega, @IdDestinatario);";
                cmd.Parameters.AddWithValue("@Data", notaFiscal.Data.ToString("yyyy-MM-dd HH:mm:ss")); // Adicionando parametros @ da consulta SQL
                cmd.Parameters.AddWithValue("@PrazoEntrega", notaFiscal.PrazoEntrega.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@IdDestinatario", notaFiscal.Destinatario.Id);

                int lines = cmd.ExecuteNonQuery(); // Executa a query e "line" guarda o número de linhas afetadas

                if (lines > 0) // Se salvou o número de "lines" vai ser maior que zero
                {
                    return true;
                }
                else
                {
                    return false;
                }

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

        /// <summary>
        /// Traz um objeto pelo seu ID passado como parametro
        /// </summary>
        /// <returns>Retorna uma lista com todos os usuários</returns>
        internal NotaFiscal ObterRegistro(int nfNumero)
        {
            MySqlConnection conn = Connection.GetConnection(); // Abre a conexão com o banco de dados
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"SELECT * FROM tb_nota_fiscal WHERE nf_numero = @Id"; // SQL
                cmd.Parameters.AddWithValue("@Id", nfNumero);
                MySqlDataReader dados = cmd.ExecuteReader(); // Aguarda o resltado em um data Reader

                NotaFiscal notaFiscal = new NotaFiscal();

                if (dados.Read())
                {
                    notaFiscal.Numero = (int)dados["nf_numero"];
                    notaFiscal.Data = (DateTime)dados["nf_data"];
                    notaFiscal.PrazoEntrega = (DateTime)dados["nf_prazo_entrega"];
                    notaFiscal.Destinatario = new Destinatario();
                    notaFiscal.Destinatario.Id = (int)dados["des_id"];
                }
                
                return notaFiscal; // Retorna objeto

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

        /// <summary>
        /// Atualiza uma NotaFiscal
        /// </summary>
        /// <returns>true ou false</returns>
        internal bool Alterar(NotaFiscal notaFiscal)
        {
            MySqlConnection conn = Connection.GetConnection(); // Abre a conexão com o banco de dados
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE tb_nota_fiscal
                                   SET nf_data=@Data, nf_prazo_entrega=@PrazoEntrega, des_id=@IdDestinatario
                                   WHERE nf_numero = @Numero"; // SQL
                cmd.Parameters.AddWithValue("@Data", notaFiscal.Data.ToString("yyyy-MM-dd HH:mm:ss")); // Adicionando parametros @ da consulta SQL
                cmd.Parameters.AddWithValue("@PrazoEntrega", notaFiscal.PrazoEntrega.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@IdDestinatario", notaFiscal.Destinatario.Id);
                cmd.Parameters.AddWithValue("@Numero", notaFiscal.Numero);
                int lines = cmd.ExecuteNonQuery(); // Executa a query e "line" guarda o número de linhas afetadas

                if (lines > 0) // Se salvou o número de "lines" vai ser maior que zero
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        /// <summary>
        /// Deleta uma NotaFiscal
        /// </summary>
        /// <returns>true ou false</returns>
        internal bool Deletar(int nfNumero)
        {
            MySqlConnection conn = Connection.GetConnection(); // Abre a conexão com o banco de dados
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM tb_nota_fiscal WHERE nf_numero = @Id"; // SQL
                cmd.Parameters.AddWithValue("@Id", nfNumero);
                int lines = cmd.ExecuteNonQuery(); // Executa a query e "line" guarda o número de linhas afetadas

                if (lines > 0) // Se deletou o número de "lines" vai ser maior que zero
                {
                    return true;
                }
                else
                {
                    return false;
                }

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

    }
}