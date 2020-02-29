using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.DAL
{
    class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Categorias> Categoria { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<EntradaProductos> Entrada { get; set; }


        public Contexto() : base("ConStr")
        {   }
    }
}
