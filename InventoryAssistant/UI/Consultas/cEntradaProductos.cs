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
    public partial class cEntradaProductos : Form
    {
        string NombreUsuario;
        public int IdEntradaProductoSeleccionada { get; set; }
        private List<EntradaProductos> ListadoEntradasProductos = new List<EntradaProductos>();
        private List<EntradaProductosConsulta> ListadoEntradasProductosConsulta = new List<EntradaProductosConsulta>();

        public cEntradaProductos(string nombreUsuario)
        {
            this.NombreUsuario = nombreUsuario;
            InitializeComponent();
        }

        private bool Validar()//Funcion encargada de validar la busqueda 
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (FiltroComboBox.SelectedIndex > 0 && FiltroComboBox.SelectedIndex <= 2)
            {
                if (CriterioTextBox.Text == string.Empty)
                {
                    CriterioTextBox.Width = 160;
                    MyErrorProvider.SetError(CriterioTextBox, "Debe escribir algún criterio de búsqueda!");
                    CriterioTextBox.Focus();
                    paso = false;
                }
                else if (FiltroComboBox.SelectedIndex == 1 && CriterioTextBox.Text.Any(x => !char.IsNumber(x)))
                {
                    CriterioTextBox.Width = 160;
                    MyErrorProvider.SetError(CriterioTextBox, "Si desea filtrar por código, solo digite números!");
                    CriterioTextBox.Focus();
                    paso = false;
                }
            }
            else if (FiltroComboBox.SelectedIndex >= 3)
            {
                if (DesdeNumericUpDown.Value > HastaNumericUpDown.Value)
                {
                    MyErrorProvider.SetError(DesdeNumericUpDown, "El valor inicial no puede ser mayor al valor limite!");
                    DesdeNumericUpDown.Focus();
                    paso = false;
                }
            }


            return paso;
        }

        private List<EntradaProductosConsulta> CargarLista(List<EntradaProductos> ListaSinProcesar)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            List<EntradaProductosConsulta> ListaProcesada = new List<EntradaProductosConsulta>();
            foreach (var item in ListaSinProcesar)
            {
                EntradaProductosConsulta e = new EntradaProductosConsulta();
                Productos p = new Productos();
                e.EntradaProductoId = item.EntradaProductoId;
                p = repositorio.Buscar(item.ProductoId);
                e.Producto = (p != null) ? p.Descripcion : "No fue posible recuperar el dato";
                e.Cantidad = item.Cantidad;
                e.Fecha = item.Fecha.Date; 

                ListaProcesada.Add(e);
            }

            return ListaProcesada;
        }

        private void Buscar() // Funcion que realiza las bsquedas
        {
            RepositorioBase<EntradaProductos> Repositorio = new RepositorioBase<EntradaProductos>();
            ListadoEntradasProductos = new List<EntradaProductos>();
            ListadoEntradasProductos = Repositorio.GetList(p => true);
            ListadoEntradasProductosConsulta = new List<EntradaProductosConsulta>();
            ListadoEntradasProductosConsulta = CargarLista(ListadoEntradasProductos);

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
                    ListadoEntradasProductosConsulta = ListadoEntradasProductosConsulta.Where(l => l.EntradaProductoId.ToString().Contains(CriterioTextBox.Text)).ToList();
                    break;

                case 2://Filtrar por descripcion
                    ListadoEntradasProductosConsulta = ListadoEntradasProductosConsulta.Where(l => l.Producto.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                    break;

                case 3://Filtrar por Cantidad
                    ListadoEntradasProductosConsulta = ListadoEntradasProductosConsulta.Where(l => l.Cantidad >= DesdeNumericUpDown.Value && l.Cantidad <= HastaNumericUpDown.Value).ToList();
                    break;
            }

            if (FiltrarPorFechaCheckBox.Checked == true)
            {
                ListadoEntradasProductosConsulta = ListadoEntradasProductosConsulta.Where(l => l.Fecha.Date >= DesdeDateTimePicker.Value.Date && l.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }

            DatosDeLaEntradaButton.Enabled = false;
            EntradasProductosDataGridView.DataSource = null;
            EntradasProductosDataGridView.DataSource = ListadoEntradasProductosConsulta;
            Formato();
            EntradasProductosDataGridView.ClearSelection();
        }

        private void Formato()//Le da el formato a la consulta
        {
            EntradasProductosDataGridView.Columns[0].HeaderText = "Código";
            EntradasProductosDataGridView.Columns[0].Width = 60;
            EntradasProductosDataGridView.Columns[1].HeaderText = "Producto";
            EntradasProductosDataGridView.Columns[1].Width = 275;
            EntradasProductosDataGridView.Columns[2].HeaderText = "Cantidad";
            EntradasProductosDataGridView.Columns[2].Width = 95;
            EntradasProductosDataGridView.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            EntradasProductosDataGridView.Columns[3].HeaderText = "Fecha";
            EntradasProductosDataGridView.Columns[3].Width = 80;

        }


        private void DatosDeLaEntradaButton_Click(object sender, EventArgs e)
        {
            IdEntradaProductoSeleccionada = Convert.ToInt32(EntradasProductosDataGridView.CurrentRow.Cells["EntradaProductoId"].Value);
            rEntradaProductos rE = new rEntradaProductos(NombreUsuario, IdEntradaProductoSeleccionada, 0);
            rE.ShowDialog();
        }

        private void RealizarBusquedaButton_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FiltroComboBox.SelectedIndex == 3)
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

        private void cEntradaProductos_Load(object sender, EventArgs e)
        {
            BuscarPorCriterio();

            RepositorioBase<EntradaProductos> Repositorio = new RepositorioBase<EntradaProductos>();
            ListadoEntradasProductos = new List<EntradaProductos>();
            ListadoEntradasProductos = Repositorio.GetList(p => true);
            ListadoEntradasProductosConsulta = CargarLista(ListadoEntradasProductos);

            if (ListadoEntradasProductosConsulta.Count > 0)
            {
                EntradasProductosDataGridView.DataSource = null;
                EntradasProductosDataGridView.DataSource = ListadoEntradasProductosConsulta;
                Formato();
                EntradasProductosDataGridView.ClearSelection();
            }

            DatosDeLaEntradaButton.Enabled = false;
            FiltroComboBox.SelectedIndex = 0;
        }

        private void EntradasProductosDataGridView_Click(object sender, EventArgs e)
        {
            if (ListadoEntradasProductosConsulta.Count > 0)
            {
                if (EntradasProductosDataGridView.CurrentRow.Index >= 0)
                {
                    DatosDeLaEntradaButton.Enabled = true;
                }
                else
                {
                    DatosDeLaEntradaButton.Enabled = false;
                }
            }
        }

        private void EntradasProductosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ListadoEntradasProductosConsulta.Count > 0)
            {
                if (EntradasProductosDataGridView.CurrentRow.Index >= 0)
                {
                    DatosDeLaEntradaButton.Enabled = true;
                    IdEntradaProductoSeleccionada = Convert.ToInt32(EntradasProductosDataGridView.CurrentRow.Cells["EntradaProductoId"].Value);
                    rEntradaProductos rE = new rEntradaProductos(NombreUsuario, IdEntradaProductoSeleccionada, 0);
                    rE.ShowDialog();
                }
            }
        }

        private void EntradasProductosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FiltrarPorlabel_Click(object sender, EventArgs e)
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

        private void DatosDelUsuarioGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void FiltrarPorFechaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void HastaFechaLabel_Click(object sender, EventArgs e)
        {

        }

        private void HastaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DesdeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DesdeFechaLabel_Click(object sender, EventArgs e)
        {

        }

        private void FechaGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
