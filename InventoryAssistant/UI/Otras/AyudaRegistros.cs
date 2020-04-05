using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Otras
{
    public partial class AyudaRegistros : Form
    {
        public AyudaRegistros()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pagina1()//Oculta los GroupBox del 4 en adelante y el boton de la pagina anterior y presenta los primeros 3 GroupBox y el boton de la pagina siguiente
        {
            try
            {
                GroupBox4.Visible = false;
                GroupBox5.Visible = false;
                GroupBox6.Visible = false;
                PaginaAnteriorButton.Visible = false;

                GroupBox1.Visible = true;
                GroupBox2.Visible = true;
                GroupBox3.Visible = true;
                PaginaSiguienteButton.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pagina2()//Oculta los Primeros 3 GroupBox y el boton de la pagina siguiente y muesta los GroupBox del 4 en adelante mas el boton de la pagina anterior
        {
            try
            {
                GroupBox1.Visible = false;
                GroupBox2.Visible = false;
                GroupBox3.Visible = false;
                PaginaSiguienteButton.Visible = false;

                GroupBox4.Visible = true;
                GroupBox5.Visible = true;
                GroupBox6.Visible = true;
                PaginaAnteriorButton.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AyudaRegistros_Load(object sender, EventArgs e)
        {
            try
            {
                Pagina1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PaginaAnteriorButton_Click(object sender, EventArgs e) //Boton de la pagina anterior
        {
            try
            {
                Pagina1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PaginaSiguienteButton_Click(object sender, EventArgs e) //Boton de la pagina siguiente
        {
            try
            {
                Pagina2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
