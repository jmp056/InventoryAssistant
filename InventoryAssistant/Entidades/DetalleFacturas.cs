using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.Entidades
{
    public class DetalleFacturas
    {
        [Key]
        public int DetalleFacturaId { get; set; }
        public int FacturaId { get; set; }
        public int CodigoProducto { get; set; }
        public int Cantidad{ get; set; }
        public string NombreProducto { get; set; }
        public float Precio { get; set; }
        public float SubTotal { get; set; }

        public DetalleFacturas()
        {
            DetalleFacturaId = 0;
            FacturaId = 0;
            CodigoProducto = 0;
            Cantidad = 0;
            NombreProducto = string.Empty;
            Precio = 0;
            SubTotal = 0;
        }

        public DetalleFacturas(int detalleFacturaId, int facturaId, int codigoProducto, int cantidad, string nombreProducto, float precio, float subTotal)
        {
            DetalleFacturaId = detalleFacturaId;
            FacturaId = facturaId;
            CodigoProducto = codigoProducto;
            Cantidad = cantidad;
            NombreProducto = nombreProducto;
            Precio = precio;
            SubTotal = subTotal;
        }
    }
}
