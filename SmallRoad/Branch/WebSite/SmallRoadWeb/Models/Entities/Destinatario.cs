using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.Models.Entities
{
    public class Destinatario
    {

        public int Numero { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Latitude { get; set; }
        public String Longitude { get; set; }
        public String Endereço { get; set; }
        public String Bairro { get; set; }
        public String Cep { get; set; }
        public Municipio Municipio { get; set; }
        public int Ddd { get;set; }
        public int Telefone { get; set; }
        public DateTime DtCadastro { get; set; }




    }
}