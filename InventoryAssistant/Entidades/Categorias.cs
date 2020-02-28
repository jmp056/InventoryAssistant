using System.ComponentModel.DataAnnotations;

namespace InventoryAssistant.Entidades
{
    class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }

        public Categorias()
        {
            CategoriaId = 0;
            Nombre = string.Empty;
        }
    }
}
