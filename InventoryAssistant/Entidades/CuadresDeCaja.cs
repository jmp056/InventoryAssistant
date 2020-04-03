using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.Entidades
{
    public class CuadresDeCaja
    {
        [Key]
        public int CuadreDeCajaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public int Dosmil { get; set; }
        public int Mil { get; set; }
        public int Quinientos { get; set; }
        public int Doscientos { get; set; }
        public int Cien { get; set; }
        public int Cincuenta { get; set; }
        public int Veinticinco { get; set; }
        public int Veinte { get; set; }
        public int Diez { get; set; }
        public int Cinco { get; set; }
        public int Uno { get; set; }
        public float TotalVendido { get; set; }
        public float Diferencia { get; set; }
        public float TotalEnCaja { get; set; }

        public bool Estado { get; set; }
        public string UsuarioR { get; set; }

        public CuadresDeCaja()
        {
            CuadreDeCajaId = 0;
            Fecha = DateTime.Now;
            Usuario = string.Empty;
            Dosmil = 0;
            Mil = 0;
            Quinientos = 0;
            Doscientos = 0;
            Cien = 0;
            Cincuenta = 0;
            Veinticinco = 0;
            Veinte = 0;
            Diez = 0;
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
