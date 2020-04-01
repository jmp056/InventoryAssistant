using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.Entidades
{
    class Cuadres
    {
        [Key]
        public int CuadreDeCajaId { get; set; }
        public DateTime Fecha { get; set; }
        public int DosMil { get; set; }
        public int Mil { get; set; }
        public int Quinientos { get; set; }
        public int Docientos { get; set; }
        public int Cien { get; set; }
        public int Cincuenta { get; set; }
        public int Veinticinco { get; set; }
        public int Veinte { get; set; }
        public int Diaz { get; set; }
        public int Cinco { get; set; }
        public int Uno { get; set; }
        public int TotalVendido { get; set; }
        public int Diferencia { get; set; }
        public int TotalEnCaja { get; set; }

        public bool Estado { get; set; }
        public string UsuarioR { get; set; }

        public Cuadres()
        {
            CuadreDeCajaId = 0;
            Fecha = DateTime.Now;
            DosMil = 0;
            Mil = 0;
            Quinientos = 0;
            Docientos = 0;
            Cien = 0;
            Cincuenta = 0;
            Veinticinco = 0;
            Veinte = 0;
            Diaz = 0;
            Cinco = 0;
            Uno = 0;
            TotalVendido = 0;
            Diferencia = 0;
            TotalEnCaja = 0;


            Estado = false;
            UsuarioR = string.Empty;
        }
    }
}
