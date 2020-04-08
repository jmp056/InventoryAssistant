using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using InventoryAssistant.UI.Registros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Consultas
{
    public partial class cFacturas : Form
    {
        string NombreUsuario;
        int Nivel;
        public int IdFacturaSeleccionada { get; set; }
        private List<Facturas> ListadoFacturas = new List<Facturas>();

        public cFacturas(string nombreUsuario, int nivel)
        {
            try
            {
                this.NombreUsuario = nombreUsuario;
                this.Nivel = nivel;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar() // Funcion encargada de validar la busqueda 
        {
            bool paso = true;

            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return paso;
        }

        private void Buscar() // Funcion que realiza las bsquedas
        {
            try
            {
                RepositorioBase<Facturas> Repositorio = new RepositorioBase<Facturas>();
                ListadoFacturas = new List<Facturas>();
                ListadoFacturas = Repositorio.GetList(p => true);

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
                        ListadoFacturas = ListadoFacturas.Where(l => l.FacturaId.ToString().Contains(CriterioTextBox.Text)).ToList();
                        break;

                    case 2://Filtrar por Vendedor
                        ListadoFacturas = ListadoFacturas.Where(l => l.Usuario.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                        break;

                    case 3://Filtrar por Cliente
                        ListadoFacturas = ListadoFacturas.Where(l => l.Cliente.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                        break;

                    case 4://Filtrar por Monto
                        ListadoFacturas = ListadoFacturas.Where(l => Convert.ToInt32(l.Total) >= DesdeNumericUpDown.Value && Convert.ToInt32(l.Total) <= HastaNumericUpDown.Value).ToList();
                        break;
                }

                if (FiltrarPorFechaCheckBox.Checked == true)
                {
                    ListadoFacturas = ListadoFacturas.Where(l => l.Fecha.Date >= DesdeDateTimePicker.Value.Date && l.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
                }

                DatosDeLaFacturaButton.Enabled = false;
                FacturaDataGridView.DataSource = null;
                FacturaDataGridView.DataSource = ListadoFacturas;
                Formato();
                FacturaDataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato() // Le da el formato a la consulta
        {
            try
            {
                FacturaDataGridView.Columns[0].HeaderText = "Código";
                FacturaDataGridView.Columns[0].Width = 60;
                FacturaDataGridView.Columns[1].HeaderText = "Vendedor";
                FacturaDataGridView.Columns[1].Width = 200;
                FacturaDataGridView.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy - hh:mm:ss tt";
                FacturaDataGridView.Columns[2].HeaderText = "Fecha";
                FacturaDataGridView.Columns[2].Width = 140;
                FacturaDataGridView.Columns[3].HeaderText = "Cliente";
                FacturaDataGridView.Columns[3].Width = 200;
                FacturaDataGridView.Columns[4].HeaderText = "Monto";
                FacturaDataGridView.Columns[4].Width = 80;
                FacturaDataGridView.Columns[4].DefaultCellStyle.Format = "N2";
                FacturaDataGridView.Columns[5].Visible = false;
                FacturaDataGridView.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatosDeLaEntradaButton_Click(object sender, EventArgs e) // Clic al boton datos de la entrada
        {
            try
            {
                IdFacturaSeleccionada = Convert.ToInt32(FacturaDataGridView.CurrentRow.Cells["FacturaId"].Value);
                rFacturas rF = new rFacturas(NombreUsuario, Nivel, IdFacturaSeleccionada);
                rF.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RealizarBusquedaButton_Click(object sender, EventArgs e) // Clic al Boton Realizar Busqueda
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e) // Cambia la saleccion del ComboBox
        {
            try
            {
                MyErrorProvider.Clear();
                CriterioTextBox.Width = 180;
                if (FiltroComboBox.SelectedIndex == 4)
                    BuscarPorRango();
                else
                    BuscarPorCriterio();
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

        private void cFacturas_Load(object sender, EventArgs e) // Al cargar el Form
        {
            try
            {
                HastaDateTimePicker.Value = DateTime.Now;
                DesdeDateTimePicker.Value = DateTime.Now;

                BuscarPorCriterio();

                //RepositorioBase<Facturas> Repositorio = new RepositorioBase<Facturas>();
                //ListadoFacturas = new List<Facturas>();
                //ListadoFacturas = Repositorio.GetList(p => true);

                //if (ListadoFacturas.Count > 0)
                //{
                //    FacturaDataGridView.DataSource = null;
                //    FacturaDataGridView.DataSource = ListadoFacturas;
                //    Formato();
                //    FacturaDataGridView.ClearSelection();
                //}

                //DatosDeLaFacturaButton.Enabled = false;
                FiltroComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FacturaDataGridView_Click(object sender, EventArgs e) // Un clic al DataGridView
        {
            try
            {
                if (ListadoFacturas.Count > 0)
                {
                    if (FacturaDataGridView.CurrentRow.Index >= 0)
                    {
                        DatosDeLaFacturaButton.Enabled = true;
                    }
                    else
                    {
                        DatosDeLaFacturaButton.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FacturaDataGridView_DoubleClick(object sender, EventArgs e) // Dos clics al DataGridVew
        {
            try
            {
                if (ListadoFacturas.Count > 0)
                {
                    if (FacturaDataGridView.CurrentRow.Index >= 0)
                    {
                        DatosDeLaFacturaButton.Enabled = true;
                        IdFacturaSeleccionada = Convert.ToInt32(FacturaDataGridView.CurrentRow.Cells["FacturaId"].Value);
                        rFacturas rF = new rFacturas(NombreUsuario, Nivel, IdFacturaSeleccionada);
                        rF.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cFacturas_Activated(object sender, EventArgs e)
        {
            try
            {
                Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
