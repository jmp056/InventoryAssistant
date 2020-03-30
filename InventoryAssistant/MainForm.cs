using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using InventoryAssistant.UI.Consultas;
using InventoryAssistant.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAssistant
{
    public partial class MainForm : Form
    {

        RepositorioBase<Usuarios> RepositorioUsuario = new RepositorioBase<Usuarios>();
        string nombre = string.Empty;
        int nivel;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) //Funcion encargada de tomar los datos del usuario que esta logueado.
        {
            NombreUsuarioToolStripStatusLabel.Text = RepositorioUsuario.ReturnUsuario().Nombres;
            int nivel = RepositorioUsuario.ReturnUsuario().NivelDeUsuario;
            switch (nivel)
            {
                case 0:
                    {
                        NivelDeUsuarioToolStripStatusLabel.Text = "Administrador  ";
                        break;
                    }
                case 1:
                    {
                        NivelDeUsuarioToolStripStatusLabel.Text = "Supervisor   ";
                        break;
                    }
                default:
                    {
                        NivelDeUsuarioToolStripStatusLabel.Text = "Usuario   ";
                        break;
                    }
            }
        }
        
        private void NoTienePermiso() //Ventana para negar el acceso a usuarios sin permiso
        {
            MessageBox.Show("Usted no tiene permiso para realizar esta tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }   
        
        // R E G I S T R O S --------------------------------------------------------------------------------------
        private void registroDeFacturasToolStripMenuItem_Click(object sender, EventArgs e) //Registro de facturas
        {
            rFacturas rF = new rFacturas(nombre);
            rF.ShowDialog();
        }
       
        private void entradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e) // Entrada de productos
        {
            if (nivel <= 1)
            {
                rEntradaProductos rE = new rEntradaProductos(nombre, 0, 0);
                rE.ShowDialog();
            }
            else
                NoTienePermiso();

        }
        
        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e) //Registro de productos
        {

            if (nivel <= 1)
            {
                rProductos rP = new rProductos(nombre, nivel, 0);
                rP.ShowDialog();
            }
            else
                NoTienePermiso();

        }

        private void registroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e) //Registro de categorias
        {
            if (nivel <= 1)
            {
                rCategorias rC = new rCategorias(nombre, 0);
                rC.ShowDialog();
            }
            else
                NoTienePermiso();
        }
        
        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)//Registro de usuarios
        {
            if (nivel <= 0)
            {
                rUsuarios rU = new rUsuarios(nombre, 0);
                rU.ShowDialog();
            }
            else
                NoTienePermiso();
        }



        // C O N S U L T A S ------------------------------------------------------------------------------------
        
        private void consultaDeProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cProductos cP = new cProductos(nombre, nivel);
            cP.ShowDialog();
        }

        private void consultaDeCategoríasToolStripMenuItem_Click(object sender, EventArgs e) //Consulta de Categorías
        {
            if (nivel <= 1)
            {
                cCategorias cC = new cCategorias(nombre);
                cC.ShowDialog();
            }
            else
                NoTienePermiso();
        }

        private void ConsultaToolStripMenuItem_Click(object sender, EventArgs e)//Consulta de Usuarios
        {
            if (nivel <= 0)
            {
                cUsuarios cU = new cUsuarios(nombre);
                cU.ShowDialog();
            }
            else
                NoTienePermiso();
        }











        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();

            nombre = repositorio.ReturnUsuario().Nombres;
            NombreUsuarioToolStripStatusLabel.Text = nombre;
            nivel = repositorio.ReturnUsuario().NivelDeUsuario;
            switch (nivel)
            {
                case 0:
                    {
                        NivelDeUsuarioToolStripStatusLabel.Text = "Administrador  ";
                        break;
                    }
                case 1:
                    {
                        NivelDeUsuarioToolStripStatusLabel.Text = "Supervisor   ";
                        break;
                    }
                default:
                    {
                        NivelDeUsuarioToolStripStatusLabel.Text = "Usuario   ";
                        break;
                    }
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            cProductos cP = new cProductos(nombre, nivel);
            cP.ShowDialog();
        }


    }
}
