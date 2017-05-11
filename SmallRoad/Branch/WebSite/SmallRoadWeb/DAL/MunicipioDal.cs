using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.DAL
{
    public class MunicipioDal
    {

        public SqlConnection conn;

        public MunicipioDal()
        {
            conn = Connection.GetConnection();
        }

        public bool Cadastrar(Municipio municipio)
        {
            String query = @"INSERT INTO TB_MUNICIPIO (EST_UF,MUN_NOME) VALUES (@Uf, @Nome);";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Uf", municipio.Uf);
            cmd.Parameters.AddWithValue("@Nome", municipio.Nome);
            int lines = cmd.ExecuteNonQuery(); 

            if (lines > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool Atualizar(Municipio municipio)
        {
            String query = @"UPDATE TB_MUNICIPIO SET (EST_UF= @Uf,NUM_NOME= @Nome) where (MUN_ID = @Id);";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", municipio.Id);
            cmd.Parameters.AddWithValue("@Uf", municipio.Uf);
            cmd.Parameters.AddWithValue("@Nome", municipio.Nome);
            int lines = cmd.ExecuteNonQuery();

            if (lines > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Deletar(Municipio municipio)
        {
            String query = @"DELETE FROM TB_MUNICIPIO WHERE (MUN_ID = @Id);";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Id", municipio.Id);
            int lines = cmd.ExecuteNonQuery();

            if (lines > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Municipio EncontrarMunicipioPorId(int id)
        {
            Municipio municipio = new Municipio();
            String query = @"SELECT * TB_MUNICIPIO WHERE (MUN_ID = @Id);";
            SqlCommand cmd = new SqlCommand(query, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.Parameters["@ID"].Value = municipio.Id;
                cmd.Parameters["@Uf"].Value = municipio.Uf;
                cmd.Parameters["@Nome"].Value = municipio.Nome;
                return municipio;
            }

            return null;
         }





    }
}