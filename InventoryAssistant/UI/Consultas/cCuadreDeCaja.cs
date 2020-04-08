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
    public partial class cCuadreDeCaja : Form
    {
        string NombreUsuario;
        int Nivel;

        public int IdCuadreSeleccionado { get; set; }
        private List<CuadresDeCaja> ListadoCuadres = new List<CuadresDeCaja>();

        public cCuadreDeCaja(string nombreUsuario, int nivel)
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

        private bool Validar()// Funcion encargada de validar la busqueda 
        {
            bool paso = true;

            try
            {
                MyErrorProvider.Clear();

                if (FiltroComboBox.SelectedIndex == 1)
                {
                    if (CriterioTextBox.Text == string.Empty)
                    {
                        CriterioTextBox.Width = 160;
                        MyErrorProvider.SetError(CriterioTextBox, "Debe escribir algún criterio de búsqueda!");
                        CriterioTextBox.Focus();
                        paso = false;
                    }
                }
                else if (FiltroComboBox.SelectedIndex >= 2)
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
                RepositorioBase<CuadresDeCaja> Repositorio = new RepositorioBase<CuadresDeCaja>();
                ListadoCuadres = new List<CuadresDeCaja>();
                ListadoCuadres = Repositorio.GetList(p => true);

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

                    case 1: //Filtrar por usuario
                        ListadoCuadres = ListadoCuadres.Where(l => l.Usuario.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                        break;

                    case 2://Filtrar por Total vendido
                        ListadoCuadres = ListadoCuadres.Where(l => Convert.ToInt32(l.TotalVendido) >= DesdeNumericUpDown.Value && Convert.ToInt32(l.TotalVendido) <= HastaNumericUpDown.Value).ToList();
                        break;

                    case 3://Filtrar por Diferencia
                        ListadoCuadres = ListadoCuadres.Where(l => Convert.ToInt32(l.Diferencia) >= DesdeNumericUpDown.Value && Convert.ToInt32(l.Diferencia) <= HastaNumericUpDown.Value).ToList();
                        break;

                    case 4://Filtrar por Total en caja
                        ListadoCuadres = ListadoCuadres.Where(l => Convert.ToInt32(l.TotalEnCaja) >= DesdeNumericUpDown.Value && Convert.ToInt32(l.TotalEnCaja) <= HastaNumericUpDown.Value).ToList();
                        break;
                }

                if (FiltrarPorFechaCheckBox.Checked == true)
                {
                    ListadoCuadres = ListadoCuadres.Where(l => l.Fecha.Date >= DesdeDateTimePicker.Value.Date && l.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
                }

                DatosDelCuadreButton.Enabled = false;
                CuadresDataGridView.DataSource = null;
                CuadresDataGridView.DataSource = ListadoCuadres;
                Formato();
                CuadresDataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato()// Le da el formato a la consulta
        {
            try
            {
                CuadresDataGridView.Columns[0].Visible = false;
                CuadresDataGridView.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
                CuadresDataGridView.Columns[1].Width = 70;
                CuadresDataGridView.Columns[2].HeaderText = "Usuario";
                CuadresDataGridView.Columns[2].Width = 200;
                CuadresDataGridView.Columns[3].Visible = false;
                CuadresDataGridView.Columns[4].Visible = false;
                CuadresDataGridView.Columns[5].Visible = false;
                CuadresDataGridView.Columns[6].Visible = false;
                CuadresDataGridView.Columns[7].Visible = false;
                CuadresDataGridView.Columns[8].Visible = false;
                CuadresDataGridView.Columns[9].Visible = false;
                CuadresDataGridView.Columns[10].Visible = false;
                CuadresDataGridView.Columns[11].Visible = false;
                CuadresDataGridView.Columns[12].Visible = false;
                CuadresDataGridView.Columns[13].Visible = false;
                CuadresDataGridView.Columns[14].HeaderText = "Total Vendido";
                CuadresDataGridView.Columns[14].Width = 100;
                CuadresDataGridView.Columns[14].DefaultCellStyle.Format = "N2";
                CuadresDataGridView.Columns[15].HeaderText = "Diferencia";
                CuadresDataGridView.Columns[15].Width = 70;
                CuadresDataGridView.Columns[15].DefaultCellStyle.Format = "N2";
                CuadresDataGridView.Columns[16].HeaderText = "Total en Caja";
                CuadresDataGridView.Columns[16].Width = 100;
                CuadresDataGridView.Columns[16].DefaultCellStyle.Format = "N2";
                CuadresDataGridView.Columns[17].Visible = false;
                CuadresDataGridView.Columns[18].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cCuadreDeCaja_Load(object sender, EventArgs e) // Evento de cargar el Form
        {
            try
            {
                DesdeDateTimePicker.Value = DateTime.Now;
                HastaDateTimePicker.Value = DateTime.Now;
                //BuscarPorCriterio();

                //RepositorioBase<CuadresDeCaja> Repositorio = new RepositorioBase<CuadresDeCaja>();
                //ListadoCuadres = new List<CuadresDeCaja>();
                //ListadoCuadres = Repositorio.GetList(p => true);

                //if (ListadoCuadres.Count > 0)
                //{
                //    CuadresDataGridView.DataSource = null;
                //    CuadresDataGridView.DataSource = ListadoCuadres;
                //    Formato();
                //    CuadresDataGridView.ClearSelection();
                //}

                //DatosDelCuadreButton.Enabled = false;
                FiltroComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RealizarBusquedaButton_Click(object sender, EventArgs e) // Clic al boton Realizar busqueda
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

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e) // Evento al cambiar seleccion del combobox
        {
            try
            {
                MyErrorProvider.Clear();
                if (FiltroComboBox.SelectedIndex <= 1)
                    BuscarPorCriterio();
                else
                    BuscarPorRango();
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

        private void CuadresDataGridView_Click(object sender, EventArgs e) // Evento de un clic al DataGridView
        {
            try
            {
                if (CuadresDataGridView.CurrentRow != null)
                {
                    if (ListadoCuadres.Count > 0)
                    {

                        if (CuadresDataGridView.CurrentRow.Index >= 0)
                        {
                            DatosDelCuadreButton.Enabled = true;
                        }
                        else
                        {
                            DatosDelCuadreButton.Enabled = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void CuadresDataGridView_DoubleClick(object sender, EventArgs e) // Evento de dos clics al DataGridView
        {
            try
            {
                if (CuadresDataGridView.CurrentRow != null)
                {
                    if (ListadoCuadres.Count > 0)
                    {
                        if (CuadresDataGridView.CurrentRow.Index >= 0)
                        {
                            DatosDelCuadreButton.Enabled = true;
                            IdCuadreSeleccionado = Convert.ToInt32(CuadresDataGridView.CurrentRow.Cells["CuadreDeCajaId"].Value);
                            rCuadreDeCaja rCC = new rCuadreDeCaja(NombreUsuario, Nivel, IdCuadreSeleccionado);
                            rCC.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatosDelCuadreButton_Click(object sender, EventArgs e) //Clic al Boton Datos del cuadre
        {
            try
            {
                IdCuadreSeleccionado = Convert.ToInt32(CuadresDataGridView.CurrentRow.Cells["CuadreDeCajaId"].Value);
                rCuadreDeCaja rCC = new rCuadreDeCaja(NombreUsuario, Nivel, IdCuadreSeleccionado);
                rCC.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cCuadreDeCaja_Activated(object sender, EventArgs e)
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
