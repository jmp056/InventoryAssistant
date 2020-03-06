using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.Entidades
{
    public class DetalleFactura
    {
        [Key]
        public int DetalleFactiraId { get; set; }
        public int FacturaId { get; set; }
        public int CodigoProducto { get; set; }
        public int Cantidad{ get; set; }
        public string NombreProducto { get; set; }
        public float Precio { get; set; }
        public float SubTotal { get; set; }

        public DetalleFactura()
        {
            DetalleFactiraId = 0;
            FacturaId = 0;
            CodigoProducto = 0;
            Cantidad = 0;
            NombreProducto = string.Empty;
            Precio = 0;
            SubTotal = 0;
        }

        public DetalleFactura(int detalleFactiraId, int facturaId, int codigoProducto, int cantidad, string nombreProducto, float precio, float subTotal)
        {
            DetalleFactiraId = detalleFactiraId;
            FacturaId = facturaId;
            CodigoProducto = codigoProducto;
            Cantidad = cantidad;
            NombreProducto = nombreProducto;
            Precio = precio;
            SubTotal = subTotal;
        }
    }
}
