﻿using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Registros
{
    public partial class rUsuarios : Form
    {
        string NombreUsuario;
        int UsuarioId;

        public rUsuarios(string nombreUsuario, int usuarioId)
        {
            try
            {
                this.NombreUsuario = nombreUsuario;
                this.UsuarioId = usuarioId;
                InitializeComponent();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            try
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

                EstadoToolStripStatusLabel.Text = string.Empty;
                UsuarioToolStripStatusLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Usuarios LlenaClase()  // Funcion encargada de llenar el objeto
        {
            Usuarios usuario = new Usuarios();

            try
            {
                usuario.UsuarioId = (int)UsuarioIdNumericUpDown.Value;
                usuario.Nombres = NombresTextBox.Text;
                usuario.Apellidos = ApellidosTextBox.Text;
                usuario.Cedula = CedulaMaskedTextBox.Text;
                usuario.Celular = TelefonoMaskedTextBox.Text;
                usuario.FechaDeRegistro = FechaDeRegistroDateTimePicker.Value;
                usuario.Usuario = UsuarioTextBox.Text;
                usuario.NivelDeUsuario = Convert.ToInt32(NivelDeUsuarioComboBox.SelectedIndex);
                usuario.Contrasena = ContrasenaTextBox.Text;

                usuario.Estado = (usuario.UsuarioId == 0) ? false : true;
                usuario.UsuarioR = NombreUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return usuario;
        }

        private void LlenaCampo(Usuarios usuario)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
        {
            try
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

                EstadoToolStripStatusLabel.Text = (usuario.Estado == false) ? "Agregado por: " : "Modificado por: ";
                UsuarioToolStripStatusLabel.Text = usuario.UsuarioR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //* Método o función para validar una cédula dominicana*
        public bool ValidaCedula(string cedula)
        {
            cedula = cedula.Replace("-", "");
            //Declaración de variables a nivel de método o función.
            int verificador = 0;
            int digito = 0;
            int digitoVerificador = 0;
            int digitoImpar = 0;
            int sumaPar = 0;
            int sumaImpar = 0;
            int longitud = Convert.ToInt32(cedula.Length);
            /*Control de errores en el código*/
            try
            {
                //verificamos que la longitud del parametro sea igual a 11
                if (longitud == 11)
                {
                    digitoVerificador = Convert.ToInt32(cedula.Substring(10, 1));
                    //recorremos en un ciclo for cada dígito de la cédula
                    for (int i = 9; i >= 0; i--)
                    {
                        //si el digito no es par multiplicamos por 2
                        digito = Convert.ToInt32(cedula.Substring(i, 1));
                        if ((i % 2) != 0)
                        {
                            digitoImpar = digito* 2;
                            //si el digito obtenido es mayor a 10, restamos 9
                            if (digitoImpar >= 10)
                            {
                                digitoImpar = digitoImpar - 9;
                            }
                            sumaImpar = sumaImpar + digitoImpar;
                        }
                        /*En los demás casos sumamos el dígito y lo aculamos 
                        en la variable */
                        else
                        {
                            sumaPar = sumaPar + digito;
                        }
                    }
                    /*Obtenemos el verificador restandole a 10 el modulo 10 
                    de la suma total de los dígitos*/
                    verificador = 10 - ((sumaPar + sumaImpar) % 10);
                    /*si el verificador es igual a 10 y el dígito verificador
                    es igual a cero o el verificador y el dígito verificador 
                    son iguales retorna verdadero*/
                    if (((verificador == 10) && (digitoVerificador == 0))
                    || (verificador == digitoVerificador))
                    {
                        return true;
                    }
                }
                else
                {
                    MyErrorProvider.SetError(CedulaMaskedTextBox, "La cédula debe contener once(11) digitos!");
                    CedulaMaskedTextBox.Focus();
                    Console.WriteLine("La cédula debe contener once(11) digitos");
                }
            }
            catch
            {
                    MessageBox.Show("No se pudo validar la cédula", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("No se pudo validar la cédula");
            }
            return false;
        }


        private bool Validar() //Funcion que valida todo el registro
        {
            bool paso = true;

            try
            {
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
                    if (!ValidaCedula(CedulaMaskedTextBox.Text))
                    {
                        MyErrorProvider.SetError(CedulaMaskedTextBox, "Error, Cedula Incorrecta");
                        paso = false;
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
                        string Comparador = UsuarioTextBox.Text.ToUpper();

                        if (UsuariosBLL.ExisteUsuario(UsuarioTextBox.Text) == true || Comparador == "ADMIN"|| Comparador == "ADMINISTRADOR")
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos() // Funcnion encargada de verificar si un usuario existe en una base de datos!
        {
            Usuarios usuario = new Usuarios();

            try
            {
                RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
                usuario = repositorio.Buscar((int)UsuarioIdNumericUpDown.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (usuario != null);
        }

        //Botones -------------------------------------------------------------------------------------------------
        private void BuscarButton_Click_1(object sender, EventArgs e)// Clic al boton buscar
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar()
        {
            try
            {
                RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
                Usuarios usuario = new Usuarios();

                int.TryParse(UsuarioIdNumericUpDown.Text, out int id);

                usuario = repositorio.Buscar(id);

                if (usuario != null)
                {
                    MyErrorProvider.Clear();
                    LlenaCampo(usuario);
                    UsuarioIdNumericUpDown.Enabled = false;
                    BuscarButton.Enabled = false;
                }
                else
                {
                    Limpiar();
                    MyErrorProvider.SetError(UsuarioIdNumericUpDown, "No existe un usuario con este codigo!");
                    NombresTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarButton_Click_1(object sender, EventArgs e) //Clic al boton limpiar
        {
            try
            {
                Limpiar();
                NombresTextBox.Focus();
                UsuarioIdNumericUpDown.Enabled = true;
                BuscarButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarButton_Click_1(object sender, EventArgs e) //Clic al boton guardar
        {
            try
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
                    MessageBox.Show("No se pudo guardar el usuario!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NombresTextBox.Focus();
                }
               
                NombresTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e) //Clic al boton eliminar
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rUsuarios_Load(object sender, EventArgs e) // Al cargar el Form
        {
            try
            {
                FechaDeRegistroDateTimePicker.Value = DateTime.Now;

                if(UsuarioId > 0)
                {
                    UsuarioIdNumericUpDown.Value = UsuarioId;
                    Buscar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //---------------------------------------------------------------------------------------------------------

        //Moviendo el foco entre los campos del registro ----------------------------------------------------------
        private void UsuarioIdNumericUpDown_KeyDown(object sender, KeyEventArgs e) // Al Pulsar una tecla en el NumericUpDown del id
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    BuscarButton.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_KeyDown(object sender, KeyEventArgs e)// Al pulsar una tecla en el boton buscar
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        UsuarioIdNumericUpDown.Focus();
                        break;

                    case Keys.Left:
                        UsuarioIdNumericUpDown.Focus();
                        break;

                    case Keys.Right:
                        NombresTextBox.Focus();
                        break;

                    case Keys.Down:
                        NombresTextBox.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NombresTextBox_KeyDown(object sender, KeyEventArgs e) // Al pulsar tecla en el TextBox de los nombres
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        BuscarButton.Focus();
                        break;

                    case Keys.Down:
                        ApellidosTextBox.Focus();
                        break;

                    case Keys.Enter:
                        ApellidosTextBox.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApellidosTextBox_KeyDown(object sender, KeyEventArgs e) // Al pulsar tecla en el TextBox de los apellidos
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        NombresTextBox.Focus();
                        break;

                    case Keys.Down:
                        CedulaMaskedTextBox.Focus();
                        break;

                    case Keys.Enter:
                        CedulaMaskedTextBox.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CedulaMaskedTextBox_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el MaskedTextBox de la cedula
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        ApellidosTextBox.Focus();
                        break;

                    case Keys.Down:
                        TelefonoMaskedTextBox.Focus();
                        break;

                    case Keys.Enter:
                        TelefonoMaskedTextBox.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelefonoMaskedTextBox_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el MaskedTextBox del telefono
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        CedulaMaskedTextBox.Focus();
                        break;

                    case Keys.Down:
                        FechaDeRegistroDateTimePicker.Focus();
                        break;

                    case Keys.Enter:
                        FechaDeRegistroDateTimePicker.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FechaDeRegistroDateTimePicker_CloseUp(object sender, EventArgs e) // Si el DateTimePicker de la fecha se cierra
        {
            try
            {
                UsuarioTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FechaDeRegistroDateTimePicker_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el DateTimePicker de la fecha
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    UsuarioTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsuarioTextBox_KeyDown(object sender, KeyEventArgs e)  // Al pulsar una tecla en el TextBox del usuario
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        FechaDeRegistroDateTimePicker.Focus();
                        break;

                    case Keys.Down:
                        NivelDeUsuarioComboBox.Focus();
                        break;

                    case Keys.Enter:
                        NivelDeUsuarioComboBox.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NivelDeUsuarioComboBox_DropDownClosed(object sender, EventArgs e) // Cuando el combobox del nivel del usuario se cerra
        {
            try
            {
                ContrasenaTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NivelDeUsuarioComboBox_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el combobox del nivel de usuario
        {
            if (e.KeyCode == Keys.Enter)
                ContrasenaTextBox.Focus();
        }

        private void ContrasenaTextBox_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el Textbox de la contraseña
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        NivelDeUsuarioComboBox.Focus();
                        break;

                    case Keys.Down:
                        ConfirmarContrasenaTextBox.Focus();
                        break;

                    case Keys.Enter:
                        ConfirmarContrasenaTextBox.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfirmarContrasenaTextBox_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el Textbox de confirmar la contraseña
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        ContrasenaTextBox.Focus();
                        break;

                    case Keys.Down:
                        GuardarButton.Focus();
                        break;

                    case Keys.Enter:
                        GuardarButton.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarButton_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el boton Limpiar
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        ConfirmarContrasenaTextBox.Focus();
                        break;

                    case Keys.Down:
                        GuardarButton.Focus();
                        break;

                    case Keys.Left:
                        EliminarButton.Focus();
                        break;

                    case Keys.Right:
                        GuardarButton.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarButton_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el boton Guardar
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        ConfirmarContrasenaTextBox.Focus();
                        break;

                    case Keys.Down:
                        EliminarButton.Focus();
                        break;

                    case Keys.Left:
                        LimpiarButton.Focus();
                        break;

                    case Keys.Right:
                        EliminarButton.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el boton eliminar
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        ConfirmarContrasenaTextBox.Focus();
                        break;

                    case Keys.Down:
                        LimpiarButton.Focus();
                        break;

                    case Keys.Left:
                        GuardarButton.Focus();
                        break;

                    case Keys.Right:
                        LimpiarButton.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

