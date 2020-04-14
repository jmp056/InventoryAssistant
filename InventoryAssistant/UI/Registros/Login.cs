using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using InventoryAssistant.UI.Otras;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Registros
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Logins() //Funcion para logearse
        {
            try
            {
                RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

                List<Usuarios> usuario = new List<Usuarios>();
                Expression<Func<Usuarios, bool>> filtrar = x => true;

                filtrar = t => t.Usuario.Equals(UsuariotextBox.Text);
                usuario = repositorio.GetList(filtrar);
           

                if (usuario.Exists(x => x.Usuario.ToUpper() == UsuariotextBox.Text.ToUpper()) && usuario.Exists(x => x.Contrasena == ContrasenaTextBox.Text))
                {
                    foreach (var item in repositorio.GetList(x => x.Usuario == UsuariotextBox.Text))
                    {
                        repositorio.NombreLogin(item.Nombres, item.Apellidos, item.NivelDeUsuario);
                    }
                    MessageBox.Show("Logeado, Por favor verifique que la hora y fecha de su dispositivo estén correctas", "Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    new MainForm().Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecto", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ContrasenaTextBox.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar() //Funcion encargada de validar el login
        {
            bool paso = true;

            try
            {
                MyErrorProvider.Clear();
                if (UsuariotextBox.Text == string.Empty)
                {
                    MyErrorProvider.SetError(UsuariotextBox, "El usuario no puede estar vacío!");
                    paso = false;
                }

                if (ContrasenaTextBox.Text == string.Empty)
                {
                    MyErrorProvider.SetError(ContrasenaTextBox, "La contraseña no puede estar vacía!");
                    paso = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return paso;
        }

        //Botones -------------------------------------------------------------------------------------------------------------------------
        private void Entrarbutton_Click_1(object sender, EventArgs e) //Boton entrar
        {
            try
            {
                MyErrorProvider.Clear();
                if (!Validar())
                    return;
                Logins();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void CancelarButton_Click(object sender, EventArgs e) // Boton cancelar
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //---------------------------------------------------------------------------------------------------------------------------------
        
        
        //Moviendo el foco entre los campos -----------------------------------------------------------------------------------------------
        private void UsuariotextBox_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el Textbox del usuario
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        CancelarButton.Focus();
                        break;

                    case Keys.Down:
                        ContrasenaTextBox.Focus();
                        break;

                    case Keys.Left:
                        CancelarButton.Focus();
                        break;

                    case Keys.Right:
                        ContrasenaTextBox.Focus();
                        break;

                    case Keys.Enter:
                        ContrasenaTextBox.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ContrasenaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        UsuariotextBox.Focus();
                        break;

                    case Keys.Down:
                        IngresarButton.Focus();
                        break;

                    case Keys.Left:
                        UsuariotextBox.Focus();
                        break;

                    case Keys.Right:
                        IngresarButton.Focus();
                        break;

                    case Keys.Enter:
                        MyErrorProvider.Clear();
                        if (!Validar())
                            return;
                        Logins();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IngresarButton_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        ContrasenaTextBox.Focus();
                        break;

                    case Keys.Down:
                        CancelarButton.Focus();
                        break;

                    case Keys.Left:
                        ContrasenaTextBox.Focus();
                        break;

                    case Keys.Right:
                        CancelarButton.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarButton_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        IngresarButton.Focus();
                        break;

                    case Keys.Down:
                        UsuariotextBox.Focus();
                        break;

                    case Keys.Left:
                        IngresarButton.Focus();
                        break;

                    case Keys.Right:
                        UsuariotextBox.Focus();
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
