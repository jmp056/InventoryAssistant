using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rep.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public String Nombres { get; set; }
        public float Deuda { get; set; }
        public DateTime Fecha { get; set; }

        public Clientes()
        {
            ClienteId = 0;
            Nombres = string.Empty;
            Deuda = 0;
            Fecha = DateTime.Now;
        }
    }
}
