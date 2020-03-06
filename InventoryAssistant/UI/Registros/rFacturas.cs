using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Registros
{
    public partial class rFacturas : Form
    {
        public List<DetalleFacturas> Detalle;

        public rFacturas()
        {
            InitializeComponent();
            Detalle = new List<DetalleFacturas>();
        }

        //Limpiadores -------------------------------------------------------------------------------------------
        private void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            FacturaIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            UsuarioTextBox.Text = string.Empty;
            ClienteTextBox.Text = string.Empty;
            LimpiarProductoGroupBox();
            this.Detalle = new List<DetalleFacturas>();
            TotalTextBox.Text = "0.00";
        }

        private void LimpiarProductoGroupBox() // Funcion encargada de limpiar todos los campos de agregar productos
        {
            ProductoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            CantidadNumericUpDown.Value = 0;
            PrecioNumericUpDown.Value = 0;
            ImporteTextBox.Text = "0.00";
            MyErrorProvider.Clear();
        }
        //--------------------------------------------------------------------------------------------------------


        //Llenadores y cargadores --------------------------------------------------------------------------------
        private void CargaGrid() // Funcion encargada de cargar el Grid
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        }

        private Facturas LlenaClase() // Funcion encargada de llenar el objeto
        {
            Facturas Factura = new Facturas();

            Factura.FacturaId = (int)FacturaIdNumericUpDown.Value;
            Factura.Fecha = FechaDateTimePicker.Value;
            Factura.Usuario = UsuarioTextBox.Text;
            Factura.Cliente = ClienteTextBox.Text;
            Factura.Detalle = this.Detalle;
            Factura.Total = Convert.ToSingle(TotalTextBox.Text);

            return Factura;
        }
        //--------------------------------------------------------------------------------------------------------


        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
