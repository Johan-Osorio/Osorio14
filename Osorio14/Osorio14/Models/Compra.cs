using System;
using System.Collections.Generic;
using System.Text;

namespace Osorio14.Models
{
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public double Total { get; set; }
        public string Vendedor { get; set; }
    }
}
