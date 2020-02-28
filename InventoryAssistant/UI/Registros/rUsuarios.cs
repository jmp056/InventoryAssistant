using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Registros
{
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
            Limpiar();
        }

        public void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            UsuarioIdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            ApellidosTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            FechaDeRegistroDateTimePicker.Value = DateTime.Now;
            UsuarioTextBox.Text = string.Empty;
            NivelDeUsuarioComboBox.SelectedIndex = -1;
            ContrasenaTextBox.Text = string.Empty;
            ConfirmarContrasenaTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
            NombresTextBox.Focus();
        }

        private Usuarios LlenaClase()  // Funcion encargada de llenar el objeto
        {
            Usuarios usuario = new Usuarios();

            usuario.UsuarioId = (int)UsuarioIdNumericUpDown.Value;
            usuario.Nombres = NombresTextBox.Text.ToUpper();
            usuario.Apellidos = ApellidosTextBox.Text.ToUpper();
            usuario.Cedula = CedulaMaskedTextBox.Text;
            usuario.Celular = TelefonoMaskedTextBox.Text;
            usuario.FechaDeRegistro = FechaDeRegistroDateTimePicker.Value;
            usuario.Usuario = UsuarioTextBox.Text;
            usuario.NivelDeUsuario = Convert.ToInt32(NivelDeUsuarioComboBox.SelectedIndex);
            usuario.Contrasena = ContrasenaTextBox.Text;

            return usuario;
        }

        private void LlenaCampo(Usuarios usuario)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
        {
            UsuarioIdNumericUpDown.Value = usuario.UsuarioId;
            NombresTextBox.Text = usuario.Nombres;
            ApellidosTextBox.Text = usuario.Apellidos;
            CedulaMaskedTextBox.Text = usuario.Cedula;
            TelefonoMaskedTextBox.Text = usuario.Celular;
            FechaDeRegistroDateTimePicker.Value = usuario.FechaDeRegistro;
            UsuarioTextBox.Text = usuario.Usuario;
            NivelDeUsuarioComboBox.SelectedIndex = usuario.NivelDeUsuario;
            ContrasenaTextBox.Text = usuario.Contrasena;
        }

        private bool Validar() //Funcion que valida todo el registro
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombresTextBox.Text == string.Empty) // Condicion encargada de validar que el campo nombre no este vacio
            {
                MyErrorProvider.SetError(NombresTextBox, "El nombre no puede estar vacío!");
                NombresTextBox.Focus();
                paso = false;
            }

            if (ApellidosTextBox.Text == string.Empty) // Condicion encargada de validar que el campo apellido no este vacio  
            {
                MyErrorProvider.SetError(ApellidosTextBox, "El apellido no puede estar vacío!");
                ApellidosTextBox.Focus();
                paso = false;
            }

            if (CedulaMaskedTextBox.Text == "   -       -")// Condicion encargada de validar que el campo cedula no este vacio 
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "La cedula no puede estar vacía!");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }
            else if (CedulaMaskedTextBox.Text.Contains(" ") == true || CedulaMaskedTextBox.Text.Length < 13) // Condicion encargada de validar que el campo cedula este completo
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "La cedula no esta completa");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }
            else // Validando que la cedula no este duplicada
            {
                if (UsuarioIdNumericUpDown.Value == 0 || Convert.ToString(UsuarioIdNumericUpDown.Value) == string.Empty) // Validando que la cedula no exista, en caso de registrar un usuario nuevo
                {
                    if (UsuariosBLL.ExisteCedula(CedulaMaskedTextBox.Text) == true)
                    {
                        MyErrorProvider.SetError(CedulaMaskedTextBox, "Ya este número de cedula está registrada con otro usuario, debe ingresar una diferente!");
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
                            MyErrorProvider.SetError(CedulaMaskedTextBox, "Ya este cedula está registrada, debe ingresar una diferente!");
                            CedulaMaskedTextBox.Focus();
                            paso = false;
                        }
                    }
                    else if (Listado.Count > 1) 
                    {
                        MyErrorProvider.SetError(CedulaMaskedTextBox, "Ya este cedula está registrada, debe ingresar una diferente!");
                        CedulaMaskedTextBox.Focus();
                        paso = false;
                    }
                }
            }


            if (TelefonoMaskedTextBox.Text != "   -   -" && TelefonoMaskedTextBox.Text.Length < 12) //Validar que el numero de celular este vacio o completo
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox, "Debe ingresar un numero de teléfono valido!");
                TelefonoMaskedTextBox.Focus();
                paso = false;
            }
            else if (TelefonoMaskedTextBox.Text != "   -   -" && TelefonoMaskedTextBox.Text.Contains(" ")) // Valida que el numero de telefono no tenga espacios en blanco
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox, "El número de teléfono no puede contener espacios en blanco!");
                TelefonoMaskedTextBox.Focus();
                paso = false;
            }


            if (FechaDeRegistroDateTimePicker.Value > DateTime.Now)  // Valida que la fecha de ingreso no sea mayor a la actual
            {
                MyErrorProvider.SetError(FechaDeRegistroDateTimePicker, "La fecha de registro no puede ser mayor a la fecha actual!");
                FechaDeRegistroDateTimePicker.Focus();
                paso = false;
            }

            if (UsuarioTextBox.Text == string.Empty)// Valida que el campo usuario no este vacío
            {
                MyErrorProvider.SetError(UsuarioTextBox, "El nombre de usuario no puede estar vacío!");
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
                    if (UsuariosBLL.ExisteUsuario(UsuarioTextBox.Text) == true)
                    {
                        MyErrorProvider.SetError(UsuarioTextBox, "Ya este nombre de usuario existe, debe elegir uno diferente!");
                        CedulaMaskedTextBox.Focus();
                        paso = false;
                    }
                }
                else //Valida que si al modificar un usuario, el nombre de usuario sea unico
                {
                    RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
                    var Listado = new List<Usuarios>();

                    Listado = Repositorio.GetList(p => p.Usuario.Contains(UsuarioTextBox.Text));

                    if (Listado.Count == 1) // Confirma que solo exista un usuario con ese numero de cedula
                    {
                        Usuarios UsuarioTemporal = new Usuarios();
                        UsuarioTemporal = Listado[0];
                        if (UsuarioTemporal.UsuarioId != UsuarioIdNumericUpDown.Value) // Verifica si el usuario que tiene ese nombre de usuario en la base de datos no es al que se esta modificando!
                        {
                            MyErrorProvider.SetError(UsuarioTextBox, "Ya este nombre de usuario existe, debe elegir uno diferente!");
                            UsuarioTextBox.Focus();
                            paso = false;
                        }
                    }
                    else if (Listado.Count > 1)
                    {
                        MyErrorProvider.SetError(UsuarioTextBox, "Ya este nombre de usuario existe, debe elegir uno diferente!");
                        UsuarioTextBox.Focus();
                        paso = false;
                    }
                }
            }

            if (NivelDeUsuarioComboBox.Text != "Administrador" && NivelDeUsuarioComboBox.Text != "Supervisor" && NivelDeUsuarioComboBox.Text != "Usuario") // Valida el nivel de usuario
            {
                MyErrorProvider.SetError(NivelDeUsuarioComboBox, "Debe elegir un nivel de usuario!");
                NivelDeUsuarioComboBox.Focus();
                paso = false;
            }

            if (ContrasenaTextBox.Text == string.Empty) // Valida que la clave no este vacia
            {
                MyErrorProvider.SetError(ContrasenaTextBox, "La contraseña no puede estar vacía!");
                NivelDeUsuarioComboBox.Focus();
                paso = false;
            }
            else if (ContrasenaTextBox.Text.Length < 5) // Valida que la contraseña tenga mas de 4 caracteres
            {
                MyErrorProvider.SetError(ContrasenaTextBox, "La contraseña debe poseer al menos 5 caracteres!");
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
            if (ContrasenaTextBox.Text != ConfirmarContrasenaTextBox.Text) // Confirma la contraseña del usuario
            {
                MyErrorProvider.SetError(ConfirmarContrasenaTextBox, "Las contraseñas no coinciden!");
                ContrasenaTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos() // Funcnion encargada de verificar si un usuario exist en una base de datos!
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            Usuarios usuario = repositorio.Buscar((int)UsuarioIdNumericUpDown.Value);
            return (usuario != null);
        }

        //Botones -------------------------------------------------------------------------------------------------
        private void BuscarButton_Click_1(object sender, EventArgs e)// Clic al boton buscar
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
                MyErrorProvider.SetError(UsuarioIdNumericUpDown, "No existe un usuario con este codigo!");
            NombresTextBox.Focus();
        }

        private void LimpiarButton_Click_1(object sender, EventArgs e) //Clic al boton limpiar
        {
            Limpiar();
            NombresTextBox.Focus();
        }

        private void GuardarButton_Click_1(object sender, EventArgs e) //Clic al boton guardar
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
                    MessageBox.Show("No se puede modificar un Usuario que no existe!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("¿Seguro que desea modificar el usuario de " + usuario.Nombres + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    paso = repositorio.Modificar(usuario);
                    if (paso)
                    {
                        MessageBox.Show("El usuario se modificó exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el usuario!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                else
                {
                    return;
                }
            }

            if (paso)
            {
                MessageBox.Show("El usuario se guardado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            { 
                MessageBox.Show("No se pudo Guardar el usuario!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombresTextBox.Focus();
            }
               
            NombresTextBox.Focus();
        }

        private void EliminarButton_Click(object sender, EventArgs e) //Clic al boton eliminar
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            MyErrorProvider.Clear();
            bool paso = false;
            int.TryParse(UsuarioIdNumericUpDown.Text, out int Id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(UsuarioIdNumericUpDown, "Este usuario no existe!");
                return;
            }
            else
            {
                Usuarios Usuario = Repositorio.Buscar(Convert.ToInt32(UsuarioIdNumericUpDown.Value));
                if(Usuario != null)
                {
                    var result = MessageBox.Show("¿Seguro que desea eliminar el usuario de " + Usuario.Nombres + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        paso = Repositorio.Eliminar(Id);
                        if (paso)
                        {
                            MessageBox.Show("El usuario se elimino exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NombresTextBox.Focus();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el usuario!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            NombresTextBox.Focus();
                        }
                        return;
                    }
                }
                 
            }
            NombresTextBox.Focus();
        }
        //---------------------------------------------------------------------------------------------------------

        //Moviendo el foco entre los campos del registro ----------------------------------------------------------

        private void UsuarioIdNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)// Al precionar enter mueve el culsor del NumericUpDown del codigo del usuario al Boton buscar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarButton.Focus();
            }
        }

        private void NombresTextBox_KeyPress(object sender, KeyPressEventArgs e)//Al precionar enter mueve el culsor del TextBox del los nombre al TextBox de los apellido
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ApellidosTextBox.Focus();
            }
        }

        private void ApellidosTextBox_KeyPress(object sender, KeyPressEventArgs e)//Al precionar enter mueve el culsor del TextBox de los apellidos al MaskTextBox de la cedula
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CedulaMaskedTextBox.Focus();
            }
        }

        private void CedulaMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e) //Al precionar enter mueve del el culsor MaskTextBox de la Cedula al MaskTextBox del Telefono
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                TelefonoMaskedTextBox.Focus();
            }
        }

        private void TelefonoMaskedTextBox_KeyPress(object sender, KeyPressEventArgs e)//Al precionar enter mueve el culsor del MaskTextBox del telefono al DateTimePicker de la fecha de registro
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                FechaDeRegistroDateTimePicker.Focus();
            }
        }
        private void FechaDeRegistroDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)//Al precionar enter mueve el culsor del DateTimePicker de la fecha de registro al TextBox del Usuario
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                UsuarioTextBox.Focus();
            }
        }

        private void FechaDeRegistroDateTimePicker_ValueChanged(object sender, EventArgs e)//Al cambiar el valor mueve el culsor del DateTimePicker de la fecha de registro al TextBox del Usuario
        {
            UsuarioTextBox.Focus();
        }

        private void FechaDeRegistroDateTimePicker_CloseUp(object sender, EventArgs e)// Al minimizarse mueve el culsor desde del DateTimePicker de la fecha de registro al TextBox del Usuario
        {
            UsuarioTextBox.Focus();
        }

        private void UsuarioTextBox_KeyPress(object sender, KeyPressEventArgs e)//Al precionar enter mueve el culsor del TextBox del nombre de usuario al ComboBox del nivel de usuario
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                NivelDeUsuarioComboBox.Focus();
            }
        }

        private void NivelDeUsuarioComboBox_SelectedIndexChanged(object sender, EventArgs e) //Al minimizarse mueve el culsor desde del ComboBox del nivel de usuario al TextBox de la contraseña
        {
            ContrasenaTextBox.Focus();
        }

        private void ContrasenaTextBox_KeyPress(object sender, KeyPressEventArgs e)//Al precionar enter mueve el culsor del TextBox del la contraseña al TextBox de la confirmacion de la contraseña
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ConfirmarContrasenaTextBox.Focus();
            }
        }

        private void ConfirmarContrasenaTextBox_KeyPress(object sender, KeyPressEventArgs e)//Al precionar enter mueve el culsor del TextBox de la confirmacion de la contraseña al Boton Guardar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                GuardarButton.Focus();
            }
        }


    }
}

