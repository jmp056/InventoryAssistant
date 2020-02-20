using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            UsuaruiIdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            ApellidosTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            FechaDeRegistroDateTimePicker.Value = DateTime.Now;
            UsuariotextBox.Text = string.Empty;
            ContrasenatextBox.Text = string.Empty;
            Contrasena2textBox.Text = string.Empty;
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = (int)UsuaruiIdNumericUpDown.Value;
            usuario.Nombres = NombresTextBox.Text;
            usuario.Apellidos = ApellidosTextBox.Text;
            usuario.Cedula = CedulaMaskedTextBox.Text;
            usuario.Celular = CelularMaskedTextBox.Text;
            usuario.FechaDeRegistro = FechaDeRegistroDateTimePicker.Value;
            usuario.Usuario = UsuariotextBox.Text;
            usuario.Contrasena = ContrasenatextBox.Text;

            return usuario;
        }


    }
}
