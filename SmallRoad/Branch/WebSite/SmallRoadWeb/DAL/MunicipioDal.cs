using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.DAL
{
    public class MunicipioDal
    {
        public MunicipioDal()
        {
            ConectarBanco();
        }

        public SqlConnection ConectarBanco()
        {
            return Connection.GetConnection();

        }

        public bool Cadastrar(Municipio municipio)
        {
            String query = @"INSERT INTO TB_MUNICIPIO (EST_UF,MUN_NOME) VALUES (@Uf, @Nome);";
            SqlCommand cmd = new SqlCommand(query, ConectarBanco());
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





    }
}