﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.Entidades
{
    class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public bool ControlAlmacen { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public bool Estado { get; set; }
        public string UsuarioR { get; set; }
        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Precio = 0;
            CategoriaId = 0;
            Cantidad = 0;
            FechaDeRegistro = DateTime.Now;
            Estado = false;
            UsuarioR = string.Empty;
        }
    }
}
