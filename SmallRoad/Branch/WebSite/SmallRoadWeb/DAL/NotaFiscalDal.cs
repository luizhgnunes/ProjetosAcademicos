using SmallRoadWeb.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.DAL
{
    public class NotaFiscalDal
    {
        public bool Cadastrar(NotaFiscal notaFiscal)
        {
            try
            {
                SqlConnection conn = Connection.GetConnection(); // Abre a conexão com o banco de dados
                string query = @"INSERT INTO TB_NOTA_FISCAL (NF_DATA, NF_PRAZO_ENTREGA, DES_ID) VALUES (@Data, @PrazoEntrega, @IdDestinatario);";
                SqlCommand cmd = new SqlCommand(query, conn); // Vincula a query SQL com a conexão
                cmd.Parameters.AddWithValue("@Data", notaFiscal.Data); // Adicionando parametros @ da consulta SQL
                cmd.Parameters.AddWithValue("@PrazoEntrega", notaFiscal.PrazoEntrega);
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
                return false;
            }
        }
    }
}