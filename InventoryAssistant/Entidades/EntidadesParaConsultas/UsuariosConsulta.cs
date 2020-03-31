using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.Entidades.EntidadesParaConsultas
{
    class UsuariosConsulta
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombres { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public string Usuario { get; set; }
        public string NivelDeUsuario { get; set; }
        public UsuariosConsulta()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            Cedula = string.Empty;
            Celular = string.Empty;
            Usuario = string.Empty;
            NivelDeUsuario = string.Empty;
        }
    }
}
