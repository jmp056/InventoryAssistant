using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.Entidades
{
    public class Usuarios
    {
        [Key]
        public int UsuarioId { get; set; 
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Celular { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public string Usuario { get; set; }
        public int NivelDeUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Estado { get; set; }
        public string UsuarioR { get; set; }

        public Usuarios()
        {
            UsuarioId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Celular = string.Empty;
            FechaDeRegistro = DateTime.Now;
            Usuario = string.Empty;
            NivelDeUsuario = 0;
            Contrasena = string.Empty;
            Estado = string.Empty;
            UsuarioR = string.Empty;
        }
    }
}
