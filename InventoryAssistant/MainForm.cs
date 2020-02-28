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
            rCategorias r = new rCategorias();
            r.ShowDialog();
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
    }
}
