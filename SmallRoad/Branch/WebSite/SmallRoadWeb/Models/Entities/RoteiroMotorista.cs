using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.Models.Entities
{
    public class RoteiroMotorista
    {

        public int rm { get; set; }
        public int usu { get; set; }
        public DateTime entrega { get; set; }
        public string obs { get; set; }
    }
}