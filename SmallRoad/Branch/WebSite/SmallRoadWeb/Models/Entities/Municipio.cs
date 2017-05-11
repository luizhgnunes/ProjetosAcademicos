using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.Models.Entities
{
    public class Municipio
    {
        public int id { get; set; }
        public string Uf {get;set;}
        public string Nome { get; set; }
    }
}