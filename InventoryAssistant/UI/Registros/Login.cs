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

        public void Limpiar()
        {
            ContrasenatextBox.Text = "";
        }

        private void Logins()
        {

            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            List<Usuarios> usuario = new List<Usuarios>();
            Expression<Func<Usuarios, bool>> filtrar = x => true;

            filtrar = t => t.Usuario.Equals(UsuariotextBox.Text);
            usuario = repositorio.GetList(filtrar);
           

            if (usuario.Exists(x => x.Usuario == UsuariotextBox.Text) && usuario.Exists(x => x.Contrasena == ContrasenatextBox.Text))
            {
                foreach (var item in repositorio.GetList(x => x.Usuario == UsuariotextBox.Text))
                {
                    repositorio.NombreLogin(item.Usuario, item.NivelDeUsuario);
                }
                MessageBox.Show("Logeado","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña y/o Usuario Incorrectos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Limpiar();
            }
        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (UsuariotextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(UsuariotextBox, "Este Campo No puede Estar Vacio!!");
                paso = false;
            }

            if (ContrasenatextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ContrasenatextBox, "Este Campo No puede Estar Vacio!!");
                paso = false;
            }

            return paso;
        }
        private void Entrarbutton_Click_1(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            Logins();
        }

        private void ContrasenatextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (!Validar())
                return;
            if (e.KeyCode == Keys.Enter)
            {
                Logins();
            }
        }

        private void UsuariotextBox_Leave(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
        }
    }
}
