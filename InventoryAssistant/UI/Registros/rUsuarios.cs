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
            EliminarButton.Enabled = false;
        }

        public void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            UsuarioIdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            ApellidosTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            FechaDeRegistroDateTimePicker.Value = DateTime.Now;
            UsuarioTextBox.Text = string.Empty;
            NivelDeUsuarioComboBox.Text = string.Empty;
            ContrasenaTextBox.Enabled = true;
            ContrasenaTextBox.Text = string.Empty;
            ConfirmarContrasenaTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private Usuarios LlenaClase()  // Funcion encargada de llenar el objeto
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = (int)UsuarioIdNumericUpDown.Value;
            usuario.Nombres = NombresTextBox.Text;
            usuario.Apellidos = ApellidosTextBox.Text;
            usuario.Cedula = CedulaMaskedTextBox.Text;
            usuario.Celular = CelularMaskedTextBox.Text;
            usuario.FechaDeRegistro = FechaDeRegistroDateTimePicker.Value;
            usuario.Usuario = UsuarioTextBox.Text;
            if (NivelDeUsuarioComboBox.Text == "Administrador")
                usuario.NivelDeUsuario = 1;
            else if (NivelDeUsuarioComboBox.Text == "Usuario")
                usuario.NivelDeUsuario = 2;
            usuario.Contrasena = ContrasenaTextBox.Text;

            return usuario;
        }

        private void LlenaCampo(Usuarios usuario)  // Funcion encargada de llenar los campos con los datos de un objeto
        {
            UsuarioIdNumericUpDown.Value = usuario.UsuarioId;
            NombresTextBox.Text = usuario.Nombres;
            ApellidosTextBox.Text = usuario.Apellidos;
            CedulaMaskedTextBox.Text = usuario.Cedula;
            CelularMaskedTextBox.Text = usuario.Celular;
            FechaDeRegistroDateTimePicker.Value = usuario.FechaDeRegistro;
            UsuarioTextBox.Text = usuario.Usuario;
            if (usuario.NivelDeUsuario == 1)
                NivelDeUsuarioComboBox.Text = "Administracion";
            else if (usuario.NivelDeUsuario == 2)
                NivelDeUsuarioComboBox.Text = "Usuario";
            ContrasenaTextBox.Enabled = false;
            ContrasenaTextBox.Text = usuario.Contrasena;
        }

        private bool Validar() //Funcion que valida todo el registro
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombresTextBox.Text == string.Empty) // Validando que el campo nombre no este vacío  
            {
                MyErrorProvider.SetError(NombresTextBox, "El campo \"Nombre\" no puede estar vacío!");
                NombresTextBox.Focus();
                paso = false;
            }

            if (ApellidosTextBox.Text == string.Empty) // Validando que el campo apellido no este vacío  
            {
                MyErrorProvider.SetError(ApellidosTextBox, "El campo \"Apellidos\" no puede estar vacío!");
                ApellidosTextBox.Focus();
                paso = false;
            }

            if (CedulaMaskedTextBox.Text == "   -       -")// Validando que el campo cedula no este vacío
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo \"Cedula\" no puede estar vacio!");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }
            else if (CedulaMaskedTextBox.Text.Contains(" ") == true || CedulaMaskedTextBox.Text.Length < 13) // Validando que el campo cedula este completo
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo \"Cedula\" no esta completo!");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }
            else // Validando que la cedula no este duplicada
            {
                if (UsuarioIdNumericUpDown.Value == 0 || Convert.ToString(UsuarioIdNumericUpDown.Value) == string.Empty) // Validando que la cedula no exista, en caso de registrar un usuario nuevo
                {
                    if (UsuariosBLL.ExisteCedula(CedulaMaskedTextBox.Text) == true)
                    {
                        MyErrorProvider.SetError(CedulaMaskedTextBox, "Ya este numero de cedula está registrada con otro usuario, debe ingresar una diferente!");
                        CedulaMaskedTextBox.Focus();
                        paso = false;
                    }
                }
                else //Valida que si al modificar un usuario, el numero de cedula sea unico
                {
                    RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
                    var Listado = new List<Usuarios>();

                    Listado = Repositorio.GetList(p => p.Cedula.Contains(CedulaMaskedTextBox.Text));

                    if (Listado.Count == 1) // Confirma que solo exista un usuario con ese numero de cedula
                    {
                        Usuarios UsuarioTemporal = new Usuarios();
                        UsuarioTemporal = Listado[0];
                        if (UsuarioTemporal.UsuarioId != UsuarioIdNumericUpDown.Value) // Verifica si el usuario que tiene ese numero de cedula en la base de datos no es al que se esta modificando!
                        {
                            MyErrorProvider.SetError(CedulaMaskedTextBox, "Ya este numero de cedula está registrada con otro usuario, debe ingresar una diferente!");
                            CedulaMaskedTextBox.Focus();
                            paso = false;
                        }
                    }
                    else
                    {
                        MyErrorProvider.SetError(CedulaMaskedTextBox, "Ya este numero de cedula está registrada con otro usuario, debe ingresar una diferente!");
                        CedulaMaskedTextBox.Focus();
                        paso = false;
                    }
                }
            }


            if(CelularMaskedTextBox.Text != "   -   -" && CelularMaskedTextBox.Text.Length < 12) //Validar que el numero de celular este vacio o completo
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "Debe ingresar un numero de celular valido!");
                CelularMaskedTextBox.Focus();
                paso = false;
            }
            else if(CelularMaskedTextBox.Text.Contains(" ")) // Valida que el numero de telefono no tenga espacios en blanco
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "El numero de celular no puede contener espacios en blanco!");
                CelularMaskedTextBox.Focus();
                paso = false;
            }
            

            if (FechaDeRegistroDateTimePicker.Value > DateTime.Now)  // Valida que la fecha de ingreso no sea mayor a la actual
            {
                MyErrorProvider.SetError(FechaDeRegistroDateTimePicker, "La fecha de registro no puede ser mayor a la fecha actual");
                FechaDeRegistroDateTimePicker.Focus();
                paso = false;
            }

            if (UsuarioTextBox.Text == string.Empty)// Valida que el campo usuario no este vacío
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El campo \"Usuario\" no puede estar vacío!");
                UsuarioTextBox.Focus();
                paso = false;
            }
            else if (UsuarioTextBox.Text.Contains(" "))// Valida que el campo usuario contenga no contenga espacios en blanco
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El nombre de Usuario no debe poseer espacios en blanco!");
                UsuarioTextBox.Focus();
                paso = false;
            }
            else if (UsuarioTextBox.Text.Length < 3)// Valida que el campo usuario contenga 3 o mas caracteres
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El nombre de Usuario debe poseer tres o más caracteres!");
                UsuarioTextBox.Focus();
                paso = false;
            }
            else // Validando que el nombre de usuario no este duplicado
            {
                if (UsuarioIdNumericUpDown.Value == 0 || Convert.ToString(UsuarioIdNumericUpDown.Value) == string.Empty) // Validando que el nombre usuario no exista, en caso de registrar un usuario nuevo
                {
                    if (UsuariosBLL.ExisteUsuario(CedulaMaskedTextBox.Text,UsuarioTextBox.Text) == true)
                    {
                        MyErrorProvider.SetError(UsuarioTextBox, "Ya este nombre de usuario existe, debe elegir uno diferente!");
                        CedulaMaskedTextBox.Focus();
                        paso = false;
                    }
                }
                else //Valida que si al modificar un usuario, el numero de usuario sea unico
                {
                    RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
                    var Listado = new List<Usuarios>();

                    Listado = Repositorio.GetList(p => p.Cedula.Contains(CedulaMaskedTextBox.Text));

                    if (Listado.Count == 1) // Confirma que solo exista un usuario con ese nombre de usuario
                    {
                        Usuarios UsuarioTemporal = new Usuarios();
                        UsuarioTemporal = Listado[0];
                        if (UsuarioTemporal.UsuarioId != UsuarioIdNumericUpDown.Value) // Verifica si el usuario que tiene ese nombre de usuario en la base de datos es diferente al que se esta modificando!
                        {
                            MyErrorProvider.SetError(CedulaMaskedTextBox, "Ya este nombre de usuario existe, debe elegir uno diferente!");
                            CedulaMaskedTextBox.Focus();
                            paso = false;
                        }
                    }
                    else
                    {
                        MyErrorProvider.SetError(CedulaMaskedTextBox, "Ya este nombre de usuario existe, debe elegir uno diferente!");
                        CedulaMaskedTextBox.Focus();
                        paso = false;
                    }
                }
            }

            if(NivelDeUsuarioComboBox.Text != "Administrador" && NivelDeUsuarioComboBox.Text != "Usuario") // Valida el nivel de usuario
            {
                MyErrorProvider.SetError(NivelDeUsuarioComboBox, "Debe elegir un nuvel de usuario!");
                NivelDeUsuarioComboBox.Focus();
                paso = false;
            }

            if (ContrasenaTextBox.Text == string.Empty) // Valida que la clave no este vacia
            {
                MyErrorProvider.SetError(ContrasenaTextBox, "El campo \"Contraseña\" no puede estar vacio y/o tener espacio");
                NivelDeUsuarioComboBox.Focus();
                paso = false;
            }
            else if (ContrasenaTextBox.Text.Length < 5) // Valida que la contraseña tenga mas de 4 caracteres
            {
                MyErrorProvider.SetError(ContrasenaTextBox, "El campo \"Contraseña\" debe poseer al menos 5 caracteres!");
                NivelDeUsuarioComboBox.Focus();
                paso = false;
            }
            else if (ContrasenaTextBox.Text.Contains(" ")) // Valida que la contraseña no contenga espacios en blanco
            {
                MyErrorProvider.SetError(ContrasenaTextBox, "La contraseña no puede poseer espacios en blanco!");
                ContrasenaTextBox.Focus();
                paso = false;
            }
            else if (Equals(UsuarioTextBox.Text, ContrasenaTextBox.Text)) // Valida que el usuario y la contaseña no sean iguales
            {
                MyErrorProvider.SetError(ContrasenaTextBox, "La contraseña y el nombre de usuario no pueden ser iguales!");
                ContrasenaTextBox.Focus();
                paso = false;
            }
            if (ContrasenaTextBox.Text !=ConfirmarContrasenaTextBox.Text) // Confirma la contraseña del usuario
            {
                MyErrorProvider.SetError(ConfirmarContrasenaTextBox, "Las contraseña no coinciden!");
                ContrasenaTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorio.Buscar((int)UsuarioIdNumericUpDown.Value);
            return (usuario != null);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = new Usuarios();

            int.TryParse(UsuarioIdNumericUpDown.Text, out int id);

            usuario = repositorio.Buscar(id);

            if (usuario != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(usuario);
            }
            else
                MyErrorProvider.SetError(UsuarioIdNumericUpDown, "Usuario no Encontrado");
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            Usuarios usuario = new Usuarios();

            bool paso = false;

            if (!Validar())
                return;

            usuario = LlenaClase();

            if (UsuarioIdNumericUpDown.Value == 0)
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

                var result = MessageBox.Show("Desea Modificar este Usuario?", "Modificar",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    paso = repositorio.Modificar(usuario);
                }
                else
                {
                    if (repositorio.Duplicado(p => p.Cedula == UsuarioTextBox.Text))
                    {
                        MyErrorProvider.SetError(UsuarioTextBox, "Este Usuario Ya Esta Registrado!!!");
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

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            MyErrorProvider.Clear();
            int.TryParse(UsuarioIdNumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(UsuarioIdNumericUpDown, "Usuario No Existe!!!");
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
