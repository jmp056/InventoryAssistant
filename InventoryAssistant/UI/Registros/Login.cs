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
                //Limpiar();
            }

        }

        private void Entrarbutton_Click(object sender, EventArgs e)
        {
     


        }

        private void Entrarbutton_Click_1(object sender, EventArgs e)
        {
            Logins();

        }
    }
}
