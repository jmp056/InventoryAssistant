using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using InventoryAssistant.UI.Consultas;
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
            FormatoDataGridView();
            CalcularTotal();
            DetalleDataGridView.ClearSelection();
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

        private void LlenaCamposProducto(Productos Producto)
        {
            ProductoIdNumericUpDown.Value = (int)Producto.ProductoId;
            DescripcionTextBox.Text = Producto.Descripcion;
            PrecioNumericUpDown.Value = Producto.Precio;
        }
        //--------------------------------------------------------------------------------------------------------


        //Validadores -------------------------------------------------------------------------------------------
        private bool ValidaProducto() // Funcion encargada de validar que el producto este corrextamente llenado
        {
            Productos ProductoTemporal = BuscaProducto((int)ProductoIdNumericUpDown.Value);
            bool Paso = true;

            if (ProductoIdNumericUpDown.Value == 0 || 
                Convert.ToString(ProductoIdNumericUpDown.Value) == string.Empty ||
                DescripcionTextBox.Text == string.Empty ||
                DescripcionTextBox.Text != ProductoTemporal.Descripcion)// Valida que el producto este cargado
            {
                MyErrorProvider.SetError(BuscarProductoButton, "Debe cargar el producto!");
                BuscarProductoButton.Focus();
                Paso = false;
            }
            else
            {
                if (CantidadNumericUpDown.Value <= 0) //Valida que la cantidad sea mayor a 0
                {
                    MyErrorProvider.SetError(CantidadNumericUpDown, "La cantidad debe ser mayor a 0!");
                    CantidadNumericUpDown.Focus();
                    Paso = false;
                }
                else
                {
                    if (ProductoTemporal.ControlAlmacen == true)//Valida si el producto esta controlado en elmacen
                    {
                        if (ProductoTemporal.Cantidad < CantidadNumericUpDown.Value)//Valida que la cantidad a facturar no sea mayor a la que existe en el almacen
                        {
                            MyErrorProvider.SetError(CantidadNumericUpDown, "De este producto solo quedan \"" + ProductoTemporal.Cantidad + "\" unidades en almacen!");
                            CantidadNumericUpDown.Focus();
                            Paso = false;
                        }
                    }
                }

                if (PrecioNumericUpDown.Value <= 0)
                {
                    MyErrorProvider.SetError(PrecioNumericUpDown, "El precio del producto debe ser mayor a 0.00!");
                    PrecioNumericUpDown.Focus();
                    Paso = false;
                }
            }

            return Paso;
        }

        private bool SiProductoExiste()
        {
            bool Existe = false;
            int Posicion = 0;

            foreach (DataGridViewRow Producto in DetalleDataGridView.Rows)
            {

                if (ProductoIdNumericUpDown.Value == Convert.ToInt32(Producto.Cells["ProductoId"].Value))
                {

                    Existe = true;
                    Posicion = Convert.ToInt32(Producto.Index);
                    break;
                }
            }

            if (Existe)
            {

                var result = MessageBox.Show("Este producto ya se encuentra en la factura, ¿Desea modificarlo?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    ProductoIdNumericUpDown.Value = Convert.ToInt32(DetalleDataGridView.Rows[Posicion].Cells["ProductoId"].Value);
                    DescripcionTextBox.Text = DetalleDataGridView.Rows[Posicion].Cells["DescripcionProducto"].Value.ToString();
                    CantidadNumericUpDown.Value = Convert.ToInt32(DetalleDataGridView.Rows[Posicion].Cells["Cantidad"].Value);
                    PrecioNumericUpDown.Value = Convert.ToDecimal(DetalleDataGridView.Rows[Posicion].Cells["Precio"].Value);
                    ImporteTextBox.Text = DetalleDataGridView.Rows[Posicion].Cells["Importe"].Value.ToString();
                    DetalleDataGridView.ClearSelection();

                    List<DetalleFacturas> items = new List<DetalleFacturas>();
                    foreach (DataGridViewRow dr in DetalleDataGridView.Rows)
                    {
                        DetalleFacturas Producto = new DetalleFacturas();
                        Producto.ProductoId = (int)dr.Cells["ProductoId"].Value;
                        if (Producto.ProductoId != (int)ProductoIdNumericUpDown.Value)
                        {
                            Producto.DetalleFacturaId = (int)dr.Cells["DetalleFacturaId"].Value;
                            Producto.FacturaId = (int)dr.Cells["FacturaId"].Value;
                            Producto.Cantidad = (int)dr.Cells["Cantidad"].Value;
                            Producto.DescripcionProducto = dr.Cells["DescripcionProducto"].Value.ToString();
                            Producto.Precio = Convert.ToSingle(dr.Cells["Precio"].Value);
                            Producto.Importe = Convert.ToSingle(dr.Cells["Importe"].Value);
                        
                            items.Add(Producto);
                        }
                    }

                    this.Detalle = items;
                    CargaGrid();
                }
                else
                {
                    LimpiarProductoGroupBox();
                }
            }

            return Existe;
        }
        //--------------------------------------------------------------------------------------------------------
        
        private void CalcularTotal()//Funcion encargada de calcular el total de la compra
        {
            float Total = 0;

            foreach (DataGridViewRow produ in DetalleDataGridView.Rows)
            {
                Total += Convert.ToSingle(produ.Cells["Importe"].Value);
            }

            TotalTextBox.Text = Convert.ToString(Total);
        }

        private void BuscarButton_Click(object sender, EventArgs e)// Boton que busca el producto por el Id
        {

        }

        private void BuscarProductoButton_Click(object sender, EventArgs e)
        {
            Productos Producto = BuscaProducto(Convert.ToInt32(ProductoIdNumericUpDown.Value));
            LimpiarProductoGroupBox();
            if (Producto == null)
            {

                MyErrorProvider.SetError(ProductoIdNumericUpDown, "No existe un producto con este código!");
                ProductoIdNumericUpDown.Focus();
            }
            else
            {

                LlenaCamposProducto(Producto);
                CantidadNumericUpDown.Focus();
            }
        }

        private void CantidadNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ImporteTextBox.Text = Convert.ToString(CantidadNumericUpDown.Value * PrecioNumericUpDown.Value); //Calcula el valor del importe si la cantidad cambia
        }

        private void PrecioNumericUpDown_ValueChanged(object sender, EventArgs e) //Calcula el valor del importe si el precio cambia
        {
            ImporteTextBox.Text = Convert.ToString(CantidadNumericUpDown.Value * PrecioNumericUpDown.Value);
        }

        private void VerProductosButton_Click(object sender, EventArgs e) //Boton que va a la consulta y trae un producto
        {
            LimpiarProductoGroupBox();
            cProductos_Factura TraeProducto = new cProductos_Factura();
            if (TraeProducto.ShowDialog() == DialogResult.OK)
            {

                Productos ProductoTraido = BuscaProducto(TraeProducto.IdProductoSeleccionado);
                LlenaCamposProducto(ProductoTraido);
                CantidadNumericUpDown.Focus();
            }
        }

        private Productos BuscaProducto(int Id) // Funcion encargada de buscar el producto
        {
            RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();
            Productos Producto = Repositorio.Buscar(Id);

            return Producto;
        }

        private void AgregarProductoButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();

            if (!ValidaProducto())
                return;

            if(SiProductoExiste())
                return;

            RepositorioBase<DetalleFacturas> Repositorio = new RepositorioBase<DetalleFacturas>();

            if (DetalleDataGridView.DataSource != null)
                Detalle = (List<DetalleFacturas>)DetalleDataGridView.DataSource;
            this.Detalle.Add(
                new DetalleFacturas(
                    detalleFacturaId: 0,
                    facturaId: (int)FacturaIdNumericUpDown.Value,
                    productoId: (int)ProductoIdNumericUpDown.Value,
                    cantidad: (int)CantidadNumericUpDown.Value,
                    descripcionProducto: DescripcionTextBox.Text,
                    precio: Convert.ToSingle(PrecioNumericUpDown.Value),
                    importe: Convert.ToSingle(ImporteTextBox.Text)
                )
            );

            CargaGrid();
            LimpiarProductoGroupBox();
        }

        private void FormatoDataGridView()//Da el formato al DataGridView del detalle
        {
            DetalleDataGridView.Columns[0].Visible = false;
            DetalleDataGridView.Columns[1].Visible = false;
            DetalleDataGridView.Columns[2].HeaderText = "Codigo";
            DetalleDataGridView.Columns[2].Width = 58;
            DetalleDataGridView.Columns[3].HeaderText = "Cantidad";
            DetalleDataGridView.Columns[3].Width = 58;
            DetalleDataGridView.Columns[4].HeaderText = "Descripción";
            DetalleDataGridView.Columns[4].Width = 250;
            DetalleDataGridView.Columns[5].HeaderText = "Precio";
            DetalleDataGridView.Columns[5].Width = 69;
            DetalleDataGridView.Columns[6].HeaderText = "Importe";
            DetalleDataGridView.Columns[6].Width = 69;

        }

        private void EliminarProductoButton_Click(object sender, EventArgs e) //Boton eliminar producto!
        {
            Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index); //Eliminando el registro
            CargaGrid();
        }
    }
}
