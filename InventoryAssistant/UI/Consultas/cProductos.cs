using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using InventoryAssistant.Entidades.EntidadesParaConsultas;
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

namespace InventoryAssistant.UI.Consultas
{
    public partial class cProductos : Form
    {
        string NombreUsuario;
        int Nivel;
        public int IdProductoeleccionado { get; set; }
        private List<Productos> ListadoProductos = new List<Productos>();
        private List<ProductosConsulta> ListadoProductosConsulta = new List<ProductosConsulta>();

        public cProductos(string nombreUsuario, int nivel)
        {
            this.NombreUsuario = nombreUsuario;
            this.Nivel = nivel;
            InitializeComponent();
        }

        private bool Validar()//Funcion encargada de validar la busqueda 
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (FiltroComboBox.SelectedIndex > 0 && FiltroComboBox.SelectedIndex < 4)
            {
                if(CriterioTextBox.Text == string.Empty || CriterioTextBox.Text.Trim().Length <= 0)
                {
                    CriterioTextBox.Width = 160;
                    MyErrorProvider.SetError(CriterioTextBox, "Debe escribir algún criterio de búsqueda!");
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
            else
            {
                MyErrorProvider.Clear();
            }

            CriterioTextBox.Width = 180;

                switch (FiltroComboBox.SelectedIndex)
                {

                    case 1: //Filtrar por Id
                        ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.ProductoId.ToString().Contains(CriterioTextBox.Text)).ToList();
                        break;

                    case 2://Filtrar por descripcion
                        ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.Descripcion.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                        break;

                    case 3://Filtrar por Categoría
                        ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.Categoria.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                        break;

                    case 4://Filtrar por Cantidad
                        ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.Cantidad >= DesdeNumericUpDown.Value && l.Cantidad <= HastaNumericUpDown.Value).ToList();
                        break;

                    case 5://Filtrar por Precio
                        ListadoProductosConsulta = ListadoProductosConsulta.Where(l => l.Precio >= DesdeNumericUpDown.Value && l.Precio <= HastaNumericUpDown.Value).ToList();
                        break;
                }


            ProductosDataGridView.DataSource = null;
            ProductosDataGridView.DataSource = ListadoProductosConsulta;
            Formato();
            ProductosDataGridView.ClearSelection();
        }

        private void Formato()//Le da el formato a la consulta
        {
            ProductosDataGridView.Columns[0].HeaderText = "Código";
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

        private void RealizarBusquedaButton_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 4 || FiltroComboBox.SelectedIndex == 5)
                BuscarPorRango();
            else
                BuscarPorCriterio();
        }

        private void BuscarPorRango()
        {
            CriterioTextBox.Visible = false;
            CriterioLabel.Text = "Desde";
            HastaLabel.Visible = true;
            DesdeNumericUpDown.Visible = true;
            HastaNumericUpDown.Visible = true;
        }

        private void BuscarPorCriterio()
        {
            HastaLabel.Visible = false;
            DesdeNumericUpDown.Visible = false;
            HastaNumericUpDown.Visible = false;
            CriterioTextBox.Visible = true;
            CriterioLabel.Text = "Criterio";
        }

        private void cProductos_Load(object sender, EventArgs e)
        {
            BuscarPorCriterio();

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
            }

            DatosDelProductoButton.Enabled = false;
            GenerarEntradaButton.Enabled = false;
            FiltroComboBox.SelectedIndex = 0;
        }

        private void ProductosDataGridView_Click(object sender, EventArgs e)
        {
            if (ListadoProductosConsulta.Count > 0)
            {
                if (ProductosDataGridView.CurrentRow.Index >= 0)
                {
                    DatosDelProductoButton.Enabled = true;
                    GenerarEntradaButton.Enabled = true;
                }
                else
                {
                    DatosDelProductoButton.Enabled = false;
                    GenerarEntradaButton.Enabled = false;
                }
            }
        }

        private void ProductosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ListadoProductosConsulta.Count > 0)
            {
                if (ProductosDataGridView.CurrentRow.Index >= 0)
                {
                    DatosDelProductoButton.Enabled = true;
                    GenerarEntradaButton.Enabled = true;
                    IdProductoeleccionado = Convert.ToInt32(ProductosDataGridView.CurrentRow.Cells["ProductoId"].Value);
                    rProductos rP = new rProductos(NombreUsuario, Nivel, IdProductoeleccionado);
                    rP.ShowDialog();
                }
            }
        }

        private void DatosDelProductoButton_Click(object sender, EventArgs e)
        {
            IdProductoeleccionado = Convert.ToInt32(ProductosDataGridView.CurrentRow.Cells["ProductoId"].Value);
            rProductos rP = new rProductos(NombreUsuario, Nivel, IdProductoeleccionado);
            rP.ShowDialog();
        }

        private void GenerarEntradaButton_Click(object sender, EventArgs e)
        {
            if (Nivel <= 1)
            {
                IdProductoeleccionado = Convert.ToInt32(ProductosDataGridView.CurrentRow.Cells["ProductoId"].Value);
                rEntradaProductos rE = new rEntradaProductos(NombreUsuario, 0, IdProductoeleccionado);
                rE.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usted no tiene permiso para realizar esta tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatosDelUsuarioGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FiltrarPorlabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CriterioLabel_Click(object sender, EventArgs e)
        {

        }

        private void HastaLabel_Click(object sender, EventArgs e)
        {

        }

        private void HastaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CriterioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DesdeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
