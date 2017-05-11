using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.Models.Entities
{
    public class Municipio
    {
        public int id { get; set; }
        public String uf {get;set;}
        public String Nome { get; set; }
    }
}