﻿using InventoryAssistant.BLL;
using InventoryAssistant.DAL;
using InventoryAssistant.Entidades;
using InventoryAssistant.UI.Consultas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Registros
{
    public partial class rFacturas : Form
    {
        public List<DetalleFacturas> Detalle;
        string NombreUsuario;
        int Nivel;
        int FacturaId;
        public rFacturas(string nombreUsuario,int nivel, int facturaId)
        {
            this.NombreUsuario = nombreUsuario;
            this.Nivel = nivel;
            this.FacturaId = facturaId;
            InitializeComponent();
            Detalle = new List<DetalleFacturas>();
            Limpiar();
        }

        //Limpiadores -------------------------------------------------------------------------------------------
        private void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            if(Nivel <= 1)
            {
                FacturaIdNumericUpDown.Enabled = true;
                BuscarButton.Enabled = true;
            }
            FacturaIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            UsuarioTextBox.Text = string.Empty;
            ClienteTextBox.Text = string.Empty;
            LimpiarProductoGroupBox();
            this.Detalle = new List<DetalleFacturas>();
            CargaGrid();
            LimpiarProductoGroupBox();
            UsuarioTextBox.Text = NombreUsuario;

            EstadoToolStripStatusLabel.Text = string.Empty;
            UsuarioToolStripStatusLabel.Text = string.Empty;
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
            Factura.Usuario = UsuarioTextBox.Text.ToUpper();
            Factura.Cliente = ClienteTextBox.Text.ToUpper();
            Factura.Detalle = this.Detalle;
            Factura.Total = Convert.ToInt32(TotalTextBox.Text);

            Factura.Estado = (Factura.FacturaId== 0) ? false : true;
            Factura.UsuarioR = NombreUsuario;

            return Factura;
        }

        private void LlenaCamposProducto(Productos Producto)
        {
            ProductoIdNumericUpDown.Value = (int)Producto.ProductoId;
            DescripcionTextBox.Text = Producto.Descripcion;
            PrecioNumericUpDown.Value = Convert.ToInt32(Producto.Precio);

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
                MyErrorProvider.SetError(ProductoIdNumericUpDown, "Debe cargar el producto!");
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

        private bool SiProductoExiste() //Valida si existe un producto en la factura
        {
            bool Existe = false;
            int Posicion = 0;

            foreach (DataGridViewRow Producto in DetalleDataGridView.Rows) //BUsca por el id del producto si este se encuentra en el detalle
            {

                if (ProductoIdNumericUpDown.Value == Convert.ToInt32(Producto.Cells["ProductoId"].Value))
                {

                    Existe = true;
                    Posicion = Convert.ToInt32(Producto.Index);
                    break;
                }
            }

            if (Existe) //SI estan en el detalle entonces
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

                    List<DetalleFacturas> items = new List<DetalleFacturas>(); //Crea una lista con todos los productos, exepto el que va a modificar
                    foreach (DataGridViewRow dr in DetalleDataGridView.Rows)//Llena la lista
                    {
                        DetalleFacturas Producto = new DetalleFacturas();
                        Producto.ProductoId = (int)dr.Cells["ProductoId"].Value;
                        if (Producto.ProductoId != (int)ProductoIdNumericUpDown.Value)//Impide que el producto a modificar entre en la lista
                        {
                            Producto.DetalleFacturaId = (int)dr.Cells["DetalleFacturaId"].Value;
                            Producto.FacturaId = (int)dr.Cells["FacturaId"].Value;
                            Producto.Cantidad = (int)dr.Cells["Cantidad"].Value;
                            Producto.DescripcionProducto = dr.Cells["DescripcionProducto"].Value.ToString();
                            Producto.Precio = Convert.ToInt32(dr.Cells["Precio"].Value);
                            Producto.Importe = Convert.ToInt32(dr.Cells["Importe"].Value);

                            items.Add(Producto);
                        }
                    }

                    this.Detalle = items;//Iguala el detalle a la lista sin el producto a modificar
                    CargaGrid();
                }
                else
                {
                    LimpiarProductoGroupBox();
                }
            }

            return Existe;
        }

        private bool Validar() //Funcion encargada de validar el registro
        {
            bool Paso = true;

            if (UsuarioTextBox.Text == string.Empty) //Valida que el vendedor no este vacio
            {
                MyErrorProvider.SetError(UsuarioTextBox, "La factura debe tener un vendedor asignado!");
                UsuarioTextBox.Focus();
                Paso = false;
            }

            if (ClienteTextBox.Text == string.Empty) //Valida que el cliente no este vacio
            {
                MyErrorProvider.SetError(ClienteTextBox, "La factura debe tener un cliente!");
                ClienteTextBox.Focus();
                Paso = false;
            }

            if (DetalleDataGridView.Rows.Count <= 0 || Convert.ToSingle(TotalTextBox.Text) == 0) //Valida que el cliente no este vacio
            {
                MyErrorProvider.SetError(DetalleDataGridView, "La factura debe tener al menos un producto vendido!");
                ProductoIdNumericUpDown.Focus();
                Paso = false;
            }

            return Paso;
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
            Buscar();
        }

        private void Buscar()
        {
            MyErrorProvider.Clear();
            int Id;
            Facturas Factura = new Facturas();
            RepositorioBase<Facturas> Repositorio = new RepositorioBase<Facturas>();

            int.TryParse(FacturaIdNumericUpDown.Text, out Id);
            Factura = FacturasBLL.Buscar(Id);

            if (Factura != null)
            {
                if(Factura.Fecha.Date == DateTime.Now.Date || Nivel <= 0)
                {
                    LlenaCampos(Factura);
                    FacturaIdNumericUpDown.Enabled = false;
                    BuscarButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Usted no tiene acceso a esta factura!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }
            }
            else
            {
                MessageBox.Show("No existe una factura con este código!");
                FacturaIdNumericUpDown.Focus();
            }
        }

        private void LlenaCampos(Facturas Factura)
        {

            Contexto contexto = new Contexto();

            FacturaIdNumericUpDown.Value = Factura.FacturaId;
            FechaDateTimePicker.Value = Factura.Fecha;
            UsuarioTextBox.Text = Factura.Usuario;
            ClienteTextBox.Text = Factura.Cliente;
            this.Detalle = Factura.Detalle;
            CargaGrid();

            EstadoToolStripStatusLabel.Text = (Factura.Estado == false) ? "Agregado por: " : "Modificado por: ";
            UsuarioToolStripStatusLabel.Text = Factura.UsuarioR;
        }
        private void BuscarProductoButton_Click(object sender, EventArgs e) //Boton de buscar producto
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

        private void VerProductosButton_Click(object sender, EventArgs e) //Boton ver lista de productos
        {
            LimpiarProductoGroupBox();
            SeleccionProducto TraeProducto = new SeleccionProducto();
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

        private void AgregarProductoButton_Click(object sender, EventArgs e) //Boton agregar producto al detalle
        {
            MyErrorProvider.Clear();

            if (!ValidaProducto())
                return;

            if (SiProductoExiste())
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
                    precio: Convert.ToInt32(PrecioNumericUpDown.Value),
                    importe: Convert.ToInt32(ImporteTextBox.Text)
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
            if(DetalleDataGridView.SelectedRows.Count > 0)
            {
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index); //Eliminando el registro
                CargaGrid();
            }
            else
                MessageBox.Show("Debe seleccionar el producto que desea eliminar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            Facturas Factura = new Facturas();
            bool Paso = false;
            if (!Validar())
                return;

            Factura = LlenaClase();
            if (FacturaIdNumericUpDown.Value == 0)
            {

                Paso = FacturasBLL.Guardar(Factura);
                MessageBox.Show("Factura guardada de manera exitosa!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {

                    MessageBox.Show("Este numero de factura no existe, por ende, no puede ser modificada!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Esta seguro que desea modificar esta factura?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    Paso = FacturasBLL.Modificar(Factura);
                    MessageBox.Show("Factura modificada!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                    return;

                if (!Paso)
                    MessageBox.Show("La factura no pudo ser guardada!", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 

        private bool ExisteEnLaBaseDeDatos() //Funcion que valida si existe en la base de datos
        {
            RepositorioBase<Facturas> Repositorio = new RepositorioBase<Facturas>();
            Facturas Factura = Repositorio.Buscar((int)FacturaIdNumericUpDown.Value);
            return Factura != null;
        }


        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(FacturaIdNumericUpDown, "Factura no existe!!!");
                return;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar esta factura?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {

                    MyErrorProvider.Clear();
                    int id;
                    int.TryParse(FacturaIdNumericUpDown.Text, out id);

                    if (FacturasBLL.Eliminar(id))
                    {

                        MessageBox.Show("La factura fue eliminada de manera exitosa", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("La factura no pudo ser eliminada!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
       
        }

        private void rFacturas_Load(object sender, EventArgs e)
        {
            FechaDateTimePicker.Value = DateTime.Now;
            FacturaIdNumericUpDown.Enabled = (Nivel <= 1) ? true : false;
            BuscarButton.Enabled = (Nivel <= 1) ? true : false;
            FechaDateTimePicker.Enabled = (Nivel <= 0) ? true : false;
            PrecioNumericUpDown.ReadOnly = (Nivel <= 1) ? false : true;

            if (FacturaId > 0)
            {
                FacturaIdNumericUpDown.Value = FacturaId;
                Buscar();
            }
            else
            {
                RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
                UsuarioTextBox.Text = repositorio.ReturnUsuario().Nombres;
            }
        }
    }
}
