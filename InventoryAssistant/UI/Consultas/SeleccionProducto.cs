using InventoryAssistant.BLL;
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

namespace InventoryAssistant.UI.Consultas
{
    public partial class SeleccionProducto : Form
    {
        public int IdProductoSeleccionado { get; set; }
        private List<Productos> ListadoProductos = new List<Productos>();

        public SeleccionProducto()
        {
            InitializeComponent();
        }

        private bool Validar() //Funcion encargada de validar la busqueda 
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (FiltroComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(FiltroComboBox, "Debe seleccionar una opción para filtrar!");
                FiltroComboBox.DroppedDown = true;
                FiltroComboBox.Focus();
                paso = false;
            }
            if (CriterioTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CriterioTextBox, "El campo criterio esta vacío!");
                CriterioTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Buscar() // Funcion que realiza las bsquedas
        {
            RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();
            ListadoProductos = new List<Productos>();

            if(FiltroComboBox.SelectedIndex > 0)
            {
                if (!Validar())
                    return;
            }

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Filtra por todo
                        ListadoProductos = Repositorio.GetList(p => true);
                        MyErrorProvider.Clear();
                        break;

                    case 1: //Filtrar por Id
                        if (CriterioTextBox.Text.Any(x => !char.IsNumber(x)) || CriterioTextBox.Text == string.Empty)
                        {
                            MyErrorProvider.SetError(CriterioTextBox, "Si desea filtrar por código, solo digite números!");
                        }
                        else
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            ListadoProductos = Repositorio.GetList(p => p.ProductoId == id);
                        }
                        break;

                    case 2://Filtrar por descripcion
                        if (CriterioTextBox.Text == string.Empty)
                        {
                            return;
                        }
                        else
                        {
                            ListadoProductos = Repositorio.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        }

                        break;
                }
            }
            else
            {
                ListadoProductos = Repositorio.GetList(p => true);
            }

            ProductosDataGridView.DataSource = null;

            ProductosDataGridView.DataSource = ListadoProductos;
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
            AnadirProductoButton.Enabled = false;
            RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();
            ListadoProductos = new List<Productos>();
            ListadoProductos = Repositorio.GetList(p => true);
            if (ListadoProductos.Count > 0)
            {
                ProductosDataGridView.DataSource = null;
                ProductosDataGridView.DataSource = ListadoProductos;
                Formato();
                ProductosDataGridView.ClearSelection();
                AnadirProductoButton.Enabled = false;
            }

        }

        private void Formato()//Le da el formato a la consulta
        {
            ProductosDataGridView.Columns[0].HeaderText = "Codigo";
            ProductosDataGridView.Columns[0].Width = 60;
            ProductosDataGridView.Columns[1].HeaderText = "Descripcion";
            ProductosDataGridView.Columns[1].Width = 275;
            ProductosDataGridView.Columns[2].HeaderText = "Categoria";
            ProductosDataGridView.Columns[2].Width = 150;
            ProductosDataGridView.Columns[3].Visible = false;
            ProductosDataGridView.Columns[4].HeaderText = "Cantidad";
            ProductosDataGridView.Columns[4].Width = 95;
            ProductosDataGridView.Columns[5].HeaderText = "Precio";
            ProductosDataGridView.Columns[5].Width = 95;
            ProductosDataGridView.Columns[6].Visible = false;
        }

        private void ProductosDataGridView_Click(object sender, EventArgs e)//Verifica que haya un producto seleccionado
        {
            if(ListadoProductos.Count > 0)
            {
                if(ProductosDataGridView.CurrentRow.Index >= 0)
                {
                    AnadirProductoButton.Enabled = true;
                }
                else
                {
                    AnadirProductoButton.Enabled = false;
                }
            }
        }

        private void RealizarBusquedaButton_Click(object sender, EventArgs e)
        {
            Buscar();
            AnadirProductoButton.Enabled = false;
        }
    }
}
