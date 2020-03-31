using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using InventoryAssistant.Entidades.EntidadesParaConsultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            InitializeComponent();
        }

        private bool Validar() //Funcion encargada de validar la busqueda 
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (FiltroComboBox.SelectedIndex > 0 && CriterioTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CriterioTextBox, "Debe escribir algún criterio de búsqueda!");
                CriterioTextBox.Focus();
                paso = false;
            }
            else
            {
                if (FiltroComboBox.SelectedIndex == 1 && CriterioTextBox.Text.Any(x => !char.IsNumber(x)) )
                {
                    MyErrorProvider.SetError(CriterioTextBox, "Si desea filtrar por código, solo digite números!");
                    CriterioTextBox.Focus();
                    paso = false;
                }
                else if (FiltroComboBox.SelectedIndex == 4 && CriterioTextBox.Text.Any(x => !char.IsNumber(x)))
                {
                    MyErrorProvider.SetError(CriterioTextBox, "Si desea filtrar por cantidad, solo digite números!");
                    CriterioTextBox.Focus();
                    paso = false;
                }
                else if (FiltroComboBox.SelectedIndex == 5 && CriterioTextBox.Text.Any(x => !char.IsNumber(x)))
                {
                    MyErrorProvider.SetError(CriterioTextBox, "Si desea filtrar por precio, solo digite números!");
                    CriterioTextBox.Focus();
                    paso = false;
                }

            }

            return paso;
        }

        private List<ProductosConsulta> CargarLista(List<Productos> ListaSinProcesar)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            List<ProductosConsulta> ListaProcesada = new List<ProductosConsulta>();
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

            return ListaProcesada;
        }

        private void Buscar() // Funcion que realiza las bsquedas
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

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
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

                    case 4: //Filtrar por cantidad
                        ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.Cantidad.ToString().Contains(CriterioTextBox.Text)).ToList();
                        break;

                    case 5: //Filtrar por precio
                        ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.Precio.ToString().Contains(CriterioTextBox.Text)).ToList();
                        break;
                }
            }

            ProductosDataGridView.DataSource = null;
            ProductosDataGridView.DataSource = ListadoProductosConsulta;
            Formato();
            ProductosDataGridView.ClearSelection();
        }

        private void AnadirProductoButton_Click(object sender, EventArgs e) //Retorna el id del producto seleccionado a la factura
        {
            IdProductoSeleccionado = Convert.ToInt32(ProductosDataGridView.CurrentRow.Cells["ProductoId"].Value);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CProductos_Factura_Load(object sender, EventArgs e)
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

        private void Formato()//Le da el formato a la consulta
        {
            ProductosDataGridView.Columns[0].HeaderText = "Codigo";
            ProductosDataGridView.Columns[0].Width = 60;
            ProductosDataGridView.Columns[1].HeaderText = "Descripcion";
            ProductosDataGridView.Columns[1].Width = 275;
            ProductosDataGridView.Columns[2].HeaderText = "Categoria";
            ProductosDataGridView.Columns[2].Width = 150;
            ProductosDataGridView.Columns[3].HeaderText = "Cantidad";
            ProductosDataGridView.Columns[3].Width = 95;
            ProductosDataGridView.Columns[4].HeaderText = "Precio";
            ProductosDataGridView.Columns[4].Width = 95;
        }

        private void ProductosDataGridView_Click(object sender, EventArgs e)//Verifica que haya un producto seleccionado
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

        private void RealizarBusquedaButton_Click(object sender, EventArgs e)
        {
            Buscar();
            SeleccionarProductoButton.Enabled = false;
        }

        private void ProductosDataGridView_DoubleClick(object sender, EventArgs e)
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
    }
}
