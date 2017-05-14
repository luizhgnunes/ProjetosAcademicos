using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmallRoadWeb.Models.Entities
{
    public class NotaFiscal
    {
        public int Numero { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
        public DateTime PrazoEntrega { get; set; }
        public Destinatario Destinatario { get; set; }
    }
}