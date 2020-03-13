using System.ComponentModel.DataAnnotations;

namespace InventoryAssistant.Entidades
{
    class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Nombre { get; set; }
        public bool Estado { get; set; }
        public string UsuarioR { get; set; }

        public Categorias()
        {
            CategoriaId = 0;
            Nombre = string.Empty;
            Estado = false;
            UsuarioR = string.Empty;
        }
    }
}
