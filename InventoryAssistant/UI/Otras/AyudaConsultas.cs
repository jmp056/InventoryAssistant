using System;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Otras
{
    public partial class AyudaConsultas : Form
    {
        public AyudaConsultas()
        {
            InitializeComponent();
        }

        private void AyudaConsultas_Load(object sender, EventArgs e)
        {
            Pagina1();
        }

        private void Pagina1()//Oculta los GroupBox del 4 en adelante y el boton de la pagina anterior y presenta los primeros 3 GroupBox y el boton de la pagina siguiente
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

        private void Pagina2()//Oculta los Primeros 3 GroupBox y el boton de la pagina siguiente y muesta los GroupBox del 4 en adelante mas el boton de la pagina anterior
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

        private void PaginaAnteriorButton_Click(object sender, EventArgs e) //Boton de la pagina anterior
        {
            Pagina1();
        }

        private void PaginaSiguienteButton_Click(object sender, EventArgs e) //Boton de la pagina siguiente
        {
            Pagina2();
        }
    }
}
