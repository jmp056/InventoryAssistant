using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.Entidades
{
    public class Facturas
    {
        public int FacturaId { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public float Total { get; set; }

        public Facturas()
        {
            FacturaId = 0;
            Usuario = string.Empty;
            Fecha = DateTime.Now;
            Cliente = string.Empty;
            Total = 0;
        }
    }
}
