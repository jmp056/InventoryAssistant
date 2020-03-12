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
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rFacturas r = new rFacturas();
            r.Show();
        }



        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios rU = new rUsuarios();
            rU.ShowDialog();
        }

        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasUsuarios cU = new ConsultasUsuarios();
            cU.ShowDialog();
        }

        private void registroDeCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCategorias rc = new rCategorias();
            rc.ShowDialog();
        }

        private void registroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProductos rp = new rProductos();
            rp.ShowDialog();
        }

        private void entradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEntradaProductos rep = new rEntradaProductos();
            rep.ShowDialog();
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

            Userlabel.Text = repositorio.ReturnUsuario().Usuario;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
         
        }

        private void consultaDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFacturas cf = new ConsultaFacturas();
            cf.ShowDialog();
        }

        private void consultaDeEntradaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEntradaProductos cep = new ConsultaEntradaProductos();
            cep.ShowDialog();
        }
    }
}
