﻿using InventoryAssistant.BLL;
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
    }
}
