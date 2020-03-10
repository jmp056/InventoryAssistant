using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        [Browsable(false)]
        public virtual List<DetalleFacturas> Detalle { get; set; }
        public float Total { get; set; }

        public Facturas()
        {
            FacturaId = 0;
            Usuario = string.Empty;
            Fecha = DateTime.Now;
            Cliente = string.Empty;
            Detalle = new List<DetalleFacturas>();
            Total = 0;
        }
    }
}
