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
        public int ProductoId { get; set; }
        public int Cantidad{ get; set; }
        public string DescripcionProducto { get; set; }
        public int Precio { get; set; }
        public int Importe { get; set; }

        public DetalleFacturas()
        {
            DetalleFacturaId = 0;
            FacturaId = 0;
            ProductoId = 0;
            Cantidad = 0;
            DescripcionProducto = string.Empty;
            Precio = 0;
            Importe = 0;
        }

        public DetalleFacturas(int detalleFacturaId, int facturaId, int productoId, int cantidad, string descripcionProducto, int precio, int importe)
        {
            DetalleFacturaId = detalleFacturaId;
            FacturaId = facturaId;
            ProductoId = productoId;
            Cantidad = cantidad;
            DescripcionProducto = descripcionProducto;
            Precio = precio;
            Importe = importe;
        }
    }
}
