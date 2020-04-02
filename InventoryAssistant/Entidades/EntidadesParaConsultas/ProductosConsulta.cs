using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.Entidades.EntidadesParaConsultas
{
    class ProductosConsulta
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public ProductosConsulta()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Categoria = string.Empty;
            Cantidad = 0;            
            Precio = 0;
        }
    }
}
