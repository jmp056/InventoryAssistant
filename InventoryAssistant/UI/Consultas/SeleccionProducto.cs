using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using InventoryAssistant.Entidades.EntidadesParaConsultas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Consultas
{
    public partial class SeleccionProducto : Form
    {
        public int IdProductoSeleccionado { get; set; }
        private List<Productos> ListadoProductos = new List<Productos>();
        private List<ProductosConsulta> ListadoProductosConsulta = new List<ProductosConsulta>();

        public SeleccionProducto()
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

        private bool Validar()//Funcion encargada de validar la busqueda 
        {
            bool paso = true;

            try
            {
                MyErrorProvider.Clear();

                if (FiltroComboBox.SelectedIndex > 0 && FiltroComboBox.SelectedIndex <= 3)
                {
                    if (CriterioTextBox.Text == string.Empty)
                    {
                        MyErrorProvider.SetError(CriterioTextBox, "Debe escribir algún criterio de búsqueda!");
                        CriterioTextBox.Focus();
                        paso = false;
                    }
                    else if (FiltroComboBox.SelectedIndex == 1 && CriterioTextBox.Text.Any(x => !char.IsNumber(x)))
                    {
                        MyErrorProvider.SetError(CriterioTextBox, "Si desea filtrar por código, solo digite números!");
                        CriterioTextBox.Focus();
                        paso = false;
                    }
                }
                else if (FiltroComboBox.SelectedIndex >= 4)
                {
                    if (DesdeNumericUpDown.Value > HastaNumericUpDown.Value)
                    {
                        MyErrorProvider.SetError(DesdeNumericUpDown, "El valor inicial no puede ser mayor al valor limite!");
                        DesdeNumericUpDown.Focus();
                        paso = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return paso;
        }

        private List<ProductosConsulta> CargarLista(List<Productos> ListaSinProcesar) // Funcion que cambia el codigo de la categoria del producto por el nombre de la categoria
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            List<ProductosConsulta> ListaProcesada = new List<ProductosConsulta>();

            try
            {
                foreach (var item in ListaSinProcesar)
                {
                    ProductosConsulta p = new ProductosConsulta();
                    p.ProductoId = item.ProductoId;
                    p.Descripcion = item.Descripcion;
                    Categorias c = repositorio.Buscar(item.CategoriaId);
                    p.Categoria = c.Nombre;
                    p.Cantidad = item.Cantidad;
                    p.Precio = item.Precio;

                    ListaProcesada.Add(p);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ListaProcesada;
        }

        private void Buscar() // Funcion que realiza las bsquedas
        {
            try
            {
                RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();
                ListadoProductos = new List<Productos>();
                ListadoProductos = Repositorio.GetList(p => true);
                ListadoProductosConsulta = new List<ProductosConsulta>();
                ListadoProductosConsulta = CargarLista(ListadoProductos);

                if (FiltroComboBox.SelectedIndex > 0)
                {
                    if (!Validar())
                        return;
                }

                switch (FiltroComboBox.SelectedIndex)
                {

                    case 1: //Filtrar por Id
                            ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.ProductoId.ToString().Contains(CriterioTextBox.Text)).ToList();   
                        break;

                    case 2://Filtrar por descripcion
                        ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.Descripcion.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                        break;

                    case 3://Filtrar por categoria
                        ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.Categoria.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                        break;

                    case 4://Filtrar por Cantidad
                        ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.Cantidad >= DesdeNumericUpDown.Value && l.Cantidad <= HastaNumericUpDown.Value).ToList();
                        break;

                    case 5://Filtrar por Precio
                        ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.Precio >= Convert.ToSingle(DesdeNumericUpDown.Value) && l.Precio <= Convert.ToSingle(HastaNumericUpDown.Value)).ToList();
                        break;
                }

                ProductosDataGridView.DataSource = null;
                ProductosDataGridView.DataSource = ListadoProductosConsulta;
                Formato();
                ProductosDataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnadirProductoButton_Click(object sender, EventArgs e) //Retorna el id del producto seleccionado a la factura
        {
            try
            {
                IdProductoSeleccionado = Convert.ToInt32(ProductosDataGridView.CurrentRow.Cells["ProductoId"].Value);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CProductos_Factura_Load(object sender, EventArgs e) // Carga el Form
        {
            try
            {
                SeleccionarProductoButton.Enabled = false;
                RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();
                ListadoProductos = new List<Productos>();
                ListadoProductos = Repositorio.GetList(p => true);
                ListadoProductosConsulta = CargarLista(ListadoProductos);

                if (ListadoProductosConsulta.Count > 0)
                {
                    ProductosDataGridView.DataSource = null;
                    ProductosDataGridView.DataSource = ListadoProductosConsulta;
                    Formato();
                    ProductosDataGridView.ClearSelection();
                    SeleccionarProductoButton.Enabled = false;
                }

                FiltroComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato()//Le da el formato a la consulta
        {
            try
            {
                ProductosDataGridView.Columns[0].HeaderText = "Codigo";
                ProductosDataGridView.Columns[0].Width = 60;
                ProductosDataGridView.Columns[1].HeaderText = "Descripcion";
                ProductosDataGridView.Columns[1].Width = 275;
                ProductosDataGridView.Columns[2].HeaderText = "Categoria";
                ProductosDataGridView.Columns[2].Width = 180;
                ProductosDataGridView.Columns[3].HeaderText = "Cantidad";
                ProductosDataGridView.Columns[3].Width = 95;
                ProductosDataGridView.Columns[4].HeaderText = "Precio";
                ProductosDataGridView.Columns[4].Width = 95;
                ProductosDataGridView.Columns[4].DefaultCellStyle.Format = "N2";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPorRango() // Funcion que activa los campos necesarios para la busqueda por un rango entre dos numeros
        {
            try
            {
                CriterioTextBox.Visible = false;
                CriterioLabel.Text = "Desde";
                HastaLabel.Visible = true;
                DesdeNumericUpDown.Visible = true;
                HastaNumericUpDown.Visible = true;
                DesdeNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarPorCriterio() // Funcion que activa los campos necesarios para la busqueda por un criterio
        {
            try
            {
                HastaLabel.Visible = false;
                DesdeNumericUpDown.Visible = false;
                HastaNumericUpDown.Visible = false;
                CriterioTextBox.Visible = true;
                CriterioLabel.Text = "Criterio";
                CriterioTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductosDataGridView_Click(object sender, EventArgs e)//Verifica que haya un producto seleccionado
        {
            try
            {
                if(ListadoProductosConsulta.Count > 0)
                {
                    if(ProductosDataGridView.CurrentRow.Index >= 0)
                    {
                        SeleccionarProductoButton.Enabled = true;
                    }
                    else
                    {
                        SeleccionarProductoButton.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RealizarBusquedaButton_Click(object sender, EventArgs e) // Clic al boton realizar busqueda
        {
            try
            {
                Buscar();
                SeleccionarProductoButton.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductosDataGridView_DoubleClick(object sender, EventArgs e) // Dos clics al dataGridView
        {
            try
            {
                if (ListadoProductosConsulta.Count > 0)
                {
                    if (ProductosDataGridView.CurrentRow.Index >= 0)
                    {
                        SeleccionarProductoButton.Enabled = true;
                        IdProductoSeleccionado = Convert.ToInt32(ProductosDataGridView.CurrentRow.Cells["ProductoId"].Value);
                        DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e) // Cambia la seleccion en el combobox
        {
            try
            {
                MyErrorProvider.Clear();
                CriterioTextBox.Focus();
                if (FiltroComboBox.SelectedIndex == 4 || FiltroComboBox.SelectedIndex == 5)
                    BuscarPorRango();
                else
                    BuscarPorCriterio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
