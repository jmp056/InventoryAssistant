using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.Entidades.EntidadesParaConsultas
{
    class EntradaProductosConsulta
    {
        [Key]
        public int EntradaProductoId { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }

        public EntradaProductosConsulta()
        {
            EntradaProductoId = 0;
            Producto = string.Empty;
            Cantidad = 0;
            Fecha = DateTime.Now;
        }
    }
}
