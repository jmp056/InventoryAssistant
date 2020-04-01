using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
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
                MessageBox.Show("Logeado","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña y/o Usuario Incorrectos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ContrasenaTextBox.Text = string.Empty;
            }
        }

        private bool Validar() //Funcion encargada de validar el login
        {
            bool paso = true;
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

            return paso;
        }

        //Botones -------------------------------------------------------------------------------------------------------------------------
        private void Entrarbutton_Click_1(object sender, EventArgs e) //Boton entrar
        {
            MyErrorProvider.Clear();
            if (!Validar())
                return;
            Logins();
        }
        
        private void CancelarButton_Click(object sender, EventArgs e) // Boton cancelar
        {
            this.Close();
        }
        
        //---------------------------------------------------------------------------------------------------------------------------------
        
        
        //Moviendo el foco entre los campos -----------------------------------------------------------------------------------------------
        private void Login_Load(object sender, EventArgs e) //Cuando la ventana termina de cargar, el foco va hacia el Usuario
        {
            UsuariotextBox.Focus();
        }

        private void UsuariotextBox_KeyPress(object sender, KeyPressEventArgs e)//Del usuario a la contraseña al pulsar enter
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                ContrasenaTextBox.Focus();
            }
        }

        private void ContrasenaTextBox_KeyPress(object sender, KeyPressEventArgs e) //De la contraseña al la funcion de loguearse
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                MyErrorProvider.Clear();
                if (!Validar())
                    return;
                Logins();
            }
        }
    }
}
