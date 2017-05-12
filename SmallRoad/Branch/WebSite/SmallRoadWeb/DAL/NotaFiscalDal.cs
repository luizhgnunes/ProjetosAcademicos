using MySql.Data.MySqlClient;
using SmallRoadWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.DAL
{
    public class NotaFiscalDal
    {
        public bool Cadastrar(NotaFiscal notaFiscal)
        {
            MySqlConnection conn = Connection.GetConnection(); // Abre a conexão com o banco de dados
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO TB_NOTA_FISCAL (NF_DATA, NF_PRAZO_ENTREGA, DES_ID) VALUES (@Data, @PrazoEntrega, @IdDestinatario);";
                cmd.Parameters.AddWithValue("@Data", notaFiscal.Data.Year + "-" + notaFiscal.Data.Month + "-" + notaFiscal.Data.Day); // Adicionando parametros @ da consulta SQL
                cmd.Parameters.AddWithValue("@PrazoEntrega", notaFiscal.PrazoEntrega.Year + "-" + notaFiscal.PrazoEntrega.Month + "-" + notaFiscal.PrazoEntrega.Day);
                cmd.Parameters.AddWithValue("@IdDestinatario", 1);

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
    }
}