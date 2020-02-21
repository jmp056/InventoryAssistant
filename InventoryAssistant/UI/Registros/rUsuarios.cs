using InventoryAssistant.BLL;
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
            MyErrorProvider.Clear();
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

        private void LlenaCampo(Usuarios usuario)
        {
            UsuaruiIdNumericUpDown.Value = usuario.UsuarioId;
            NombresTextBox.Text = usuario.Nombres;
            ApellidosTextBox.Text = usuario.Apellidos;
            CedulaMaskedTextBox.Text = usuario.Cedula;
            CelularMaskedTextBox.Text = usuario.Celular;
            FechaDeRegistroDateTimePicker.Value = usuario.FechaDeRegistro;
            UsuariotextBox.Text = usuario.Usuario;
            ContrasenatextBox.Text = usuario.Contrasena;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorio.Buscar((int)UsuaruiIdNumericUpDown.Value);
            return (usuario != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            //if (UsuaruiIdNumericUpDown.Value == 0)
            //{
            //    MyErrorProvider.SetError(UsuaruiIdNumericUpDown, "El campo Id no puede estar vacio");
            //    UsuaruiIdNumericUpDown.Focus();
            //    paso = false;
            //}

            if (NombresTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombresTextBox, "El campo Nombre no puede estar vacio");
                NombresTextBox.Focus();
                paso = false;
            }

            if (ApellidosTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ApellidosTextBox, "El campo Apellido no puede estar vacio");
                ApellidosTextBox.Focus();
                paso = false;
            }

            if (CedulaMaskedTextBox.Text == "   -       -")
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo Cedula no puede estar vacio");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }
            if (CelularMaskedTextBox.Text == "   -   -")
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "El campo Celular no puede estar vacio");
                CelularMaskedTextBox.Focus();
                paso = false;
            }
            if (UsuariotextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(UsuariotextBox, "El campo Usuario no puede estar vacio");
                UsuaruiIdNumericUpDown.Focus();
                paso = false;
            }
            if (ContrasenatextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ContrasenatextBox, "El campo Contraseña no puede estar vacio");
                ContrasenatextBox.Focus();
                paso = false;
            }
            if (Contrasena2textBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(Contrasena2textBox, "Debes Confirmar la Contraseña");
                Contrasena2textBox.Focus();
                paso = false;
            }
            if (ContrasenatextBox.Text != Contrasena2textBox.Text)
            {
                MyErrorProvider.SetError(Contrasena2textBox, "La Contraseña no coinciden");
                Contrasena2textBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            Usuarios usuario = new Usuarios();

            bool paso = false;

            if (!Validar())
                return;

            usuario = LlenaClase();

            if (UsuaruiIdNumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(usuario);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("Desea Modificar este Usuario?","Modificar",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    paso = repositorio.Modificar(usuario);
                }
                else
                {
                    if (repositorio.Duplicado(p => p.Usuario == UsuariotextBox.Text))
                    {
                        MyErrorProvider.SetError(UsuariotextBox, "Este Usuario Ya Esta Registrado!!!");
                        return;
                    }
                    else
                    {
                        paso = repositorio.Modificar(usuario);
                    }
                }
            }
            if (paso)
            {
                MessageBox.Show("Usuario Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = new Usuarios();

            int.TryParse(UsuaruiIdNumericUpDown.Text, out int id);

            usuario = repositorio.Buscar(id);

            if (usuario != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(usuario);
            }
            else
                MyErrorProvider.SetError(UsuaruiIdNumericUpDown, "Usuario no Encontrado");
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            MyErrorProvider.Clear();
            int.TryParse(UsuaruiIdNumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(UsuaruiIdNumericUpDown, "Usuario No Existe!!!");
                return;
            }
            if (repositorio.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Usuario Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
