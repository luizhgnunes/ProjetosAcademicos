using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.Models.Entities
{
    public class Destinatario
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Endereço { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public Municipio Municipio { get; set; }
        public int Ddd { get;set; }
        public int Telefone { get; set; }
        public DateTime DtCadastro { get; set; }
    }
}