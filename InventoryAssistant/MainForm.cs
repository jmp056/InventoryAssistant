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
        string nombre = "";
        int nivel;// = RepositorioUsuario.ReturnUsuario().NivelDeUsuario;

        public MainForm()
        {
            InitializeComponent();
        }

        private void registroDeFacturasToolStripMenuItem_Click(object sender, EventArgs e) //Registro de facturas
        {
            rFacturas rF = new rFacturas(nombre);
            rF.ShowDialog();
        }
       
        private void entradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e) // Entrada de productos
        {
            if (nivel <= 1)
            {
                rEntradaProductos rE = new rEntradaProductos(nombre);
                rE.ShowDialog();
            }
            else
                NoTienePermiso();

        }
        
        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e) //Registro de productos
        {

            if (nivel <= 1)
            {
                rProductos rP = new rProductos(nombre, nivel);
                rP.ShowDialog();
            }
            else
                NoTienePermiso();

        }

        private void registroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e) //Registro de categorias
        {
            if (nivel <= 1)
            {
                rCategorias rC = new rCategorias(nombre);
                rC.ShowDialog();
            }
            else
                NoTienePermiso();

        }
        
        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)//Registro de usuarios
        {
            if (nivel <= 0)
            {
                rUsuarios rU = new rUsuarios(nombre);
                rU.ShowDialog();
            }
            else
                NoTienePermiso();
        }












        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasUsuarios cU = new ConsultasUsuarios();
            cU.ShowDialog();
        }

        private void consultaDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFacturas cf = new ConsultaFacturas();
            cf.ShowDialog();
        }





        private void consultaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProductos cp = new ConsultaProductos();
            cp.ShowDialog();
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

        private void MainForm_Load(object sender, EventArgs e)
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

        private void NoTienePermiso()
        {
            MessageBox.Show("Usted no tiene permiso para realizar esta tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
