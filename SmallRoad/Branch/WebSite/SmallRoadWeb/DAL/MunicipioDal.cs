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

        public Municipio PesquisarMunicipioPorId(int id)
        {
            Municipio municipio = new Municipio();
            String query = @"SELECT * FROM TB_MUNICIPIO WHERE (MUN_ID = @Id);";
            SqlCommand cmd = new SqlCommand(query, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                municipio.Id = cmd.Parameters["@ID"].Value;
                municipio.Uf = cmd.Parameters["@Uf"].Value;
                municipio.Nome = cmd.Parameters["@Nome"].Value;
                return municipio;
            }

            return null;
         }

        public List<Municipio> PesquisarTodosMunicipios()
        {
            List<Municipio> municipios = new List<Municipio>();
            String query = @"SELECT * FROM TB_MUNICIPIO;";
            //Galindo Escrever o comando que retorna todos os resultados do sql aqui
            foreach (Municipio municipio in municipios) {


            }

            return municipios;


        }





    }
}