using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Registros
{
    public partial class rCuadreDeCaja : Form
    {
        string NombreUsuario;
        int Nivel;
        int CuadreDeCajaId;

        List<Facturas> ListadoFacturas = new List<Facturas>();
        string Decimas = ".00";
        
        public rCuadreDeCaja(string nombreUsuario, int nivel, int cuadreDeCajaId)
        {
            try
            {
                this.NombreUsuario = nombreUsuario;
                this.Nivel = nivel;
                this.CuadreDeCajaId = cuadreDeCajaId;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar() // Funcion encargada de limiar todo el registro
        {
            try
            {
                // Limpiar los NumericUpDown del desglose
                DosMilNumericUpDown.Value = 0;
                MilNumericUpDown.Value = 0;
                QuinientosNumericUpDown.Value = 0;
                DoscientosNumericUpDown.Value = 0;
                CienNumericUpDown.Value = 0;
                CincuentaNumericUpDown.Value = 0;
                VeinticincoNumericUpDown.Value = 0;
                VeinteNumericUpDown.Value = 0;
                DiezNumericUpDown.Value = 0;
                CincoNumericUpDown.Value = 0;
                UnoNumericUpDown.Value = 0;

                // Limpiar los Textbox del desglose
                DosmilTextBox.Text = "0.00";
                MilTextBox.Text = "0.00";
                QuinientosTextBox.Text = "0.00";
                DoscientosTextBox.Text = "0.00";
                CienTextBox.Text = "0.00";
                CincuentaTextBox.Text = "0.00";
                VeinticincoTextBox.Text = "0.00";
                VeinteTextBox.Text = "0.00";
                DiezTextBox.Text = "0.00";
                CincoTextBox.Text = "0.00";
                UnoTextBox.Text = "0.00";

                //Limpiar Textbox de totales
                TotalEnCajaTextBox.Text = "0.00";
                DiferenciaTextBox.Text = "0.00";
                TotalVendidoTextBox.Text = "0.00";

                //Limpiar el DataGridView
                FacturasDataGridView.DataSource = null;

                UsuarioTextBox.Text = NombreUsuario;
                EstadoToolStripStatusLabel.Text = string.Empty;
                UsuarioToolStripStatusLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CuadreDeCaja_Load(object sender, EventArgs e) // Cargar el Form
        {
            try
            {
                FechaDateTimePicker.Enabled = (Nivel <= 0) ? true : false;

                DosMilNumericUpDown.Controls[0].Visible = false;
                MilNumericUpDown.Controls[0].Visible = false;
                QuinientosNumericUpDown.Controls[0].Visible = false;
                DoscientosNumericUpDown.Controls[0].Visible = false;
                CienNumericUpDown.Controls[0].Visible = false;
                CincuentaNumericUpDown.Controls[0].Visible = false;
                VeinticincoNumericUpDown.Controls[0].Visible = false;
                VeinteNumericUpDown.Controls[0].Visible = false;
                DiezNumericUpDown.Controls[0].Visible = false;
                CincoNumericUpDown.Controls[0].Visible = false;
                UnoNumericUpDown.Controls[0].Visible = false;

                if (CuadreDeCajaId == 0)
                {
                    FechaDateTimePicker.Value = DateTime.Now;
                }
                else
                {
                    Buscar();
                    FechaDateTimePicker.Enabled = false;
                }

                CargarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private CuadresDeCaja LlenaClase()  // Funcion encargada de llenar el objeto
        {
            CuadresDeCaja CuadreDeCaja = new CuadresDeCaja();

            try
            {
                CuadreDeCaja.CuadreDeCajaId = Convert.ToInt32(Convert.ToString(FechaDateTimePicker.Value.Day) + Convert.ToString(FechaDateTimePicker.Value.Month) + Convert.ToString(FechaDateTimePicker.Value.Year));
                CuadreDeCaja.Fecha = FechaDateTimePicker.Value;
                CuadreDeCaja.Usuario = UsuarioTextBox.Text;
                CuadreDeCaja.Dosmil = Convert.ToInt32(DosMilNumericUpDown.Value);
                CuadreDeCaja.Mil = Convert.ToInt32(MilNumericUpDown.Value);
                CuadreDeCaja.Quinientos = Convert.ToInt32(QuinientosNumericUpDown.Value);
                CuadreDeCaja.Doscientos = Convert.ToInt32(DoscientosNumericUpDown.Value);
                CuadreDeCaja.Cien = Convert.ToInt32(CienNumericUpDown.Value);
                CuadreDeCaja.Cincuenta = Convert.ToInt32(CincuentaNumericUpDown.Value);
                CuadreDeCaja.Veinticinco = Convert.ToInt32(VeinticincoNumericUpDown.Value);
                CuadreDeCaja.Veinte = Convert.ToInt32(VeinteNumericUpDown.Value);
                CuadreDeCaja.Diez = Convert.ToInt32(DiezNumericUpDown.Value);
                CuadreDeCaja.Cinco = Convert.ToInt32(CincoNumericUpDown.Value);
                CuadreDeCaja.Uno = Convert.ToInt32(UnoNumericUpDown.Value);
                CuadreDeCaja.TotalVendido = Convert.ToSingle(TotalVendidoTextBox.Text);
                CuadreDeCaja.Diferencia = Convert.ToSingle(DiferenciaTextBox.Text);
                CuadreDeCaja.TotalEnCaja = Convert.ToSingle(TotalEnCajaTextBox.Text);
                CuadreDeCaja.Estado = (ExisteEnLaBaseDeDatos()) ? true : false;
                CuadreDeCaja.UsuarioR = NombreUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return CuadreDeCaja;
        }

        private void LlenaCampo(CuadresDeCaja CuadreDeCaja)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
        {
            try
            {
                UsuarioTextBox.Text = CuadreDeCaja.Usuario;
                DosMilNumericUpDown.Value = CuadreDeCaja.Dosmil;
                MilNumericUpDown.Value = CuadreDeCaja.Mil;
                QuinientosNumericUpDown.Value = CuadreDeCaja.Quinientos;
                DoscientosNumericUpDown.Value = CuadreDeCaja.Doscientos;
                CienNumericUpDown.Value = CuadreDeCaja.Cien;
                CincuentaNumericUpDown.Value = CuadreDeCaja.Cincuenta;
                VeinticincoNumericUpDown.Value = CuadreDeCaja.Veinticinco;
                VeinteNumericUpDown.Value = CuadreDeCaja.Veinte;
                DiezNumericUpDown.Value = CuadreDeCaja.Diez;
                CincoNumericUpDown.Value = CuadreDeCaja.Cinco;
                UnoNumericUpDown.Value = CuadreDeCaja.Uno;

                EstadoToolStripStatusLabel.Text = (CuadreDeCaja.Estado == false) ? "Agregado por: " : "Modificado por: ";
                UsuarioToolStripStatusLabel.Text = CuadreDeCaja.UsuarioR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ExisteEnLaBaseDeDatos() // Funcnion encargada de verificar si un usuario exist en una base de datos!
        {
            CuadresDeCaja CuadreDeCaja = new CuadresDeCaja();

            try
            {
                RepositorioBase<CuadresDeCaja> Repositorio = new RepositorioBase<CuadresDeCaja>();
                int Codigo = Convert.ToInt32(Convert.ToString(FechaDateTimePicker.Value.Day) + Convert.ToString(FechaDateTimePicker.Value.Month) + Convert.ToString(FechaDateTimePicker.Value.Year));
                CuadreDeCaja = Repositorio.Buscar(Codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (CuadreDeCaja != null);
        }

        private void Buscar() // Funcion encargada de realizar la busqueda
        {
            try
            {
                RepositorioBase<CuadresDeCaja> Repositorio = new RepositorioBase<CuadresDeCaja>();
                CuadresDeCaja CuadreDeCaja = new CuadresDeCaja();
                int Codigo;

                if (CuadreDeCajaId == 0)
                {
                    Codigo = Convert.ToInt32(Convert.ToString(FechaDateTimePicker.Value.Day) + Convert.ToString(FechaDateTimePicker.Value.Month) + Convert.ToString(FechaDateTimePicker.Value.Year));
                }
                else
                {
                    Codigo = CuadreDeCajaId;
                }

                CuadreDeCaja = Repositorio.Buscar(Codigo);

                if (CuadreDeCaja != null)
                {
                    LlenaCampo(CuadreDeCaja);
                    FechaDateTimePicker.Value = CuadreDeCaja.Fecha;
                    CalcularTotales();
                    CalcularTotalEnCaja();
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarFacturas() // Funcion encargada de cargar las facturas
        {
            try
            {
                RepositorioBase<Facturas> Repositorio = new RepositorioBase<Facturas>();
                DateTime FechaDesde = FechaDateTimePicker.Value.AddDays(-2);
                DateTime FechaHasta = FechaDateTimePicker.Value.AddDays(2);

                ListadoFacturas = Repositorio.GetList(e => e.Fecha > FechaDesde && e.Fecha < FechaHasta);
                ListadoFacturas = ListadoFacturas.Where(e => e.Fecha.Date == FechaDateTimePicker.Value.Date).ToList();

                FacturasDataGridView.DataSource = null;
                if(ListadoFacturas.Count > 0)
                {
                    FacturasDataGridView.DataSource = ListadoFacturas;
                    Formato();
                    FacturasDataGridView.ClearSelection();
                    TotalVendido();
                }

                FuenteDelDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FuenteDelDataGridView() // Funcion encargada de cambiarle la fuente al DataGrisViiew
        {
            try
            {
                this.FacturasDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalVendido() // Funcion encargada de calcular el total vendido
        {
            try
            {
                double TotalVendido = 0;
                foreach (DataGridViewRow produ in FacturasDataGridView.Rows)
                {
                    TotalVendido += Convert.ToDouble(produ.Cells["Total"].Value);
                }
                TotalVendidoTextBox.Text = Convert.ToString(TotalVendido) + ".00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato()//Le da el formato al DataGridView
        {
            try
            {
                FacturasDataGridView.Columns[0].Visible = false;
                FacturasDataGridView.Columns[1].HeaderText = "Vendedor";
                FacturasDataGridView.Columns[1].Width = 200;
                FacturasDataGridView.Columns[2].Visible = false;
                FacturasDataGridView.Columns[3].HeaderText = "Cliente";
                FacturasDataGridView.Columns[3].Width = 200;
                FacturasDataGridView.Columns[4].HeaderText = "Monto";
                FacturasDataGridView.Columns[4].Width = 80;
                FacturasDataGridView.Columns[4].DefaultCellStyle.Format = "N2";
                FacturasDataGridView.Columns[5].Visible = false;
                FacturasDataGridView.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Diferencia() // Funcion encargada de calcular la diferencia entre lo cobrado y lo que hay en caja
        {
            try
            {
                DiferenciaTextBox.Text = Convert.ToString(Convert.ToDecimal(TotalEnCajaTextBox.Text) - Convert.ToDecimal(TotalVendidoTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e) // Clic al boton guardar
        {
            try
            {
                bool paso = false;

                CuadresDeCaja CuadreDeCaja = LlenaClase();

                if (ExisteEnLaBaseDeDatos())
                {
                    RepositorioBase<CuadresDeCaja> Repositorio = new RepositorioBase<CuadresDeCaja>();

                    var result = MessageBox.Show("¿Seguro que desea modificar este cuadre de caja?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        paso = Repositorio.Modificar(CuadreDeCaja);
                        if (paso)
                        {
                            MessageBox.Show("El cuadre de caja se modifico de manera exitosa!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            GuardarButton.Enabled = false;
                        }

                        else
                            MessageBox.Show("El cuadre de caja no se pudo modifico!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    paso = CuadresDeCajaBLL.Guardar(CuadreDeCaja);
                    if (paso)
                    {
                        MessageBox.Show("El cuadre de caja se guardó de manera exitosa!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GuardarButton.Enabled = false;
                    }
                    else
                        MessageBox.Show("El cuadre de caja no se pudo guardar!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void CalcularTotalEnCaja()//Funcion encargada de calcular el total en caja
        {
            try
            {
                double Total = 
                    Convert.ToDouble(DosmilTextBox.Text) +
                    Convert.ToDouble(MilTextBox.Text) +
                    Convert.ToDouble(QuinientosTextBox.Text) +
                    Convert.ToDouble(DoscientosTextBox.Text) +
                    Convert.ToDouble(CienTextBox.Text) +
                    Convert.ToDouble(CincuentaTextBox.Text) +
                    Convert.ToDouble(VeinticincoTextBox.Text) +
                    Convert.ToDouble(VeinteTextBox.Text) +
                    Convert.ToDouble(DiezTextBox.Text) +
                    Convert.ToDouble(CincoTextBox.Text) +
                    Convert.ToDouble(UnoTextBox.Text);

                TotalEnCajaTextBox.Text = Convert.ToString(Total) + Decimas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcularTotales() // Funcion encargada de calcular los totales de los TextBox del desglose
        {
            try
            {
                DosmilTextBox.Text = Convert.ToString(DosMilNumericUpDown.Value * 2000) + Decimas;
                MilTextBox.Text = Convert.ToString(MilNumericUpDown.Value * 1000) + Decimas;
                QuinientosTextBox.Text = Convert.ToString(QuinientosNumericUpDown.Value * 500) + Decimas;
                DoscientosTextBox.Text = Convert.ToString(DoscientosNumericUpDown.Value * 200) + Decimas;
                CienTextBox.Text = Convert.ToString(CienNumericUpDown.Value * 100) + Decimas;
                CincuentaTextBox.Text = Convert.ToString(CincuentaNumericUpDown.Value * 50) + Decimas;
                VeinticincoTextBox.Text = Convert.ToString(VeinticincoNumericUpDown.Value * 25) + Decimas;
                VeinteTextBox.Text = Convert.ToString(VeinteNumericUpDown.Value * 20) + Decimas;
                DiezTextBox.Text = Convert.ToString(DiezNumericUpDown.Value * 10) + Decimas;
                CincoTextBox.Text = Convert.ToString(CincoNumericUpDown.Value * 5) + Decimas;
                UnoTextBox.Text = Convert.ToString(UnoNumericUpDown.Value * 1) + Decimas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FacturasDataGridView_DoubleClick(object sender, EventArgs e) // Dos clic al DataGridView de las facturas
        {
            try
            {
                if (FacturasDataGridView.CurrentRow != null)
                {
                    if (ListadoFacturas.Count > 0)
                    {
                        if (FacturasDataGridView.CurrentRow.Index >= 0)
                        {
                            int IdFacturaSeleccionada = Convert.ToInt32(FacturasDataGridView.CurrentRow.Cells["FacturaId"].Value);
                            rFacturas rF = new rFacturas(NombreUsuario, Nivel, IdFacturaSeleccionada);
                            rF.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FechaDateTimePicker_ValueChanged(object sender, EventArgs e) // Al Cambiar el valor del DataTimePicker de la fecha
        {
            try
            {
                Buscar();
                CargarFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void TotalEnCajaTextBox_TextChanged(object sender, EventArgs e) // Calcula la diferencia si el total en caja cambia
        {
            try
            {
                Diferencia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TotalVendidoTextBox_TextChanged(object sender, EventArgs e) // Calcula la diferencia si el total vendido cambia
        {
            try
            {
                Diferencia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // ------------------------------------- Numeric's up downs ---------------------------------------------------------//
        
        // NUMERIC UP DOUWN DE DOSMIL -------------------------------------------------------------------------------------------------- 
        private void DosMilNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            try
            {
                if (DosMilNumericUpDown.Text == "")
                    DosMilNumericUpDown.Value = 0;

                DosmilTextBox.Text = Convert.ToString(DosMilNumericUpDown.Value * 2000) + Decimas;
                CalcularTotalEnCaja();

                if (e.KeyCode == Keys.Enter)
                    MilNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DosMilNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            try
            {
                if (DosMilNumericUpDown.Value == 0)
                    DosMilNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DosMilNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            try
            {
                if (DosMilNumericUpDown.Text == "")
                    DosMilNumericUpDown.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUMERIC UP DOUWN DE MIL -------------------------------------------------------------------------------------------------- 
        private void MilNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            try
            {
                if (MilNumericUpDown.Text == "")
                    MilNumericUpDown.Value = 0;

                MilTextBox.Text = Convert.ToString(MilNumericUpDown.Value * 1000) + Decimas;
                CalcularTotalEnCaja();

                if (e.KeyCode == Keys.Enter)
                    QuinientosNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MilNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            try
            {
                if (MilNumericUpDown.Value == 0)
                    MilNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MilNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            try
            {
                if (MilNumericUpDown.Text == "")
                    MilNumericUpDown.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUMERIC UP DOUWN DE QUINIENTOS -------------------------------------------------------------------------------------------------- 
        private void QuinientosNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            try
            {
                if (QuinientosNumericUpDown.Text == "")
                    QuinientosNumericUpDown.Value = 0;

                QuinientosTextBox.Text = Convert.ToString(QuinientosNumericUpDown.Value * 500) + Decimas;
                CalcularTotalEnCaja();

                if (e.KeyCode == Keys.Enter)
                    DoscientosNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuinientosNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            try
            {
                if (QuinientosNumericUpDown.Value == 0)
                    QuinientosNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuinientosNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            try
            {
                if (QuinientosNumericUpDown.Text == "")
                    QuinientosNumericUpDown.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUMERIC UP DOUWN DE DOSCIENTOS -------------------------------------------------------------------------------------------------- 
        private void DoscientosNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            try
            {
                if (DoscientosNumericUpDown.Text == "")
                    DoscientosNumericUpDown.Value = 0;

                DoscientosTextBox.Text = Convert.ToString(DoscientosNumericUpDown.Value * 200) + Decimas;
                CalcularTotalEnCaja();

                if (e.KeyCode == Keys.Enter)
                    CienNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoscientosNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            try
            {
                if (DoscientosNumericUpDown.Value == 0)
                    DoscientosNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoscientosNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            try
            {
                if (DoscientosNumericUpDown.Text == "")
                    DoscientosNumericUpDown.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUMERIC UP DOUWN DE CIEN -------------------------------------------------------------------------------------------------- 
        private void CienNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            try
            {
                if (CienNumericUpDown.Text == "")
                    CienNumericUpDown.Value = 0;

                CienTextBox.Text = Convert.ToString(CienNumericUpDown.Value * 100) + Decimas;
                CalcularTotalEnCaja();

                if (e.KeyCode == Keys.Enter)
                    CincuentaNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CienNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            try
            {
                if (CienNumericUpDown.Value == 0)
                    CienNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CienNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            try
            {
            if (CienNumericUpDown.Text == "")
                CienNumericUpDown.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUMERIC UP DOUWN DE CINCUENTA -------------------------------------------------------------------------------------------------- 
        private void CincuentaNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            try
            {
                if (CincuentaNumericUpDown.Text == "")
                    CincuentaNumericUpDown.Value = 0;

                CincuentaTextBox.Text = Convert.ToString(CincuentaNumericUpDown.Value * 50) + Decimas;
                CalcularTotalEnCaja();

                if (e.KeyCode == Keys.Enter)
                    VeinticincoNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CincuentaNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            try
            {
                if (CincuentaNumericUpDown.Value == 0)
                    CincuentaNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CincuentaNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            try
            {
                if (CincuentaNumericUpDown.Text == "")
                    CincuentaNumericUpDown.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUMERIC UP DOUWN DE VEINTICINCO -------------------------------------------------------------------------------------------------- 
        private void VeinticincoNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            try
            {
                if (VeinticincoNumericUpDown.Text == "")
                    VeinticincoNumericUpDown.Value = 0;

                VeinticincoTextBox.Text = Convert.ToString(VeinticincoNumericUpDown.Value * 25) + Decimas;
                CalcularTotalEnCaja();

                if (e.KeyCode == Keys.Enter)
                    VeinteNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VeinticincoNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            try
            {
                if (VeinticincoNumericUpDown.Value == 0)
                    VeinticincoNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VeinticincoNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            try
            {
                if (VeinticincoNumericUpDown.Text == "")
                    VeinticincoNumericUpDown.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUMERIC UP DOUWN DE VEINTE -------------------------------------------------------------------------------------------------- 
        private void VeinteNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            try
            {
                if (VeinteNumericUpDown.Text == "")
                    VeinteNumericUpDown.Value = 0;

                VeinteTextBox.Text = Convert.ToString(VeinteNumericUpDown.Value * 20) + Decimas;
                CalcularTotalEnCaja();

                if (e.KeyCode == Keys.Enter)
                    DiezNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VeinteNumericUpDown_Enter(object sender, EventArgs e) // Al salir el foco
        {
            try
            {
                if (VeinteNumericUpDown.Value == 0)
                    VeinteNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VeinteNumericUpDown_Leave(object sender, EventArgs e) // Al entrar el foco
        {
            try
            {
                if (VeinteNumericUpDown.Text == "")
                    VeinteNumericUpDown.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUMERIC UP DOUWN DE DIEZ -------------------------------------------------------------------------------------------------- 
        private void DiezNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            try
            {
                if (DiezNumericUpDown.Text == "")
                    DiezNumericUpDown.Value = 0;

                DiezTextBox.Text = Convert.ToString(DiezNumericUpDown.Value * 10) + Decimas;
                CalcularTotalEnCaja();

                if (e.KeyCode == Keys.Enter)
                    CincoNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DiezNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            try
            {
                if (DiezNumericUpDown.Value == 0)
                    DiezNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DiezNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            try
            {
                if (DiezNumericUpDown.Text == "")
                    DiezNumericUpDown.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUMERIC UP DOUWN DE CINCO -------------------------------------------------------------------------------------------------- 
        private void CincoNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            try
            {
                if (CincoNumericUpDown.Text == "")
                    CincoNumericUpDown.Value = 0;

                CincoTextBox.Text = Convert.ToString(CincoNumericUpDown.Value * 5) + Decimas;
                CalcularTotalEnCaja();

                if (e.KeyCode == Keys.Enter)
                    UnoNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CincoNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            try
            {
                if (CincoNumericUpDown.Value == 0)
                    CincoNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CincoNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            try
            {
                if (CincoNumericUpDown.Text == "")
                    CincoNumericUpDown.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // NUMERIC UP DOUWN DE UNO -------------------------------------------------------------------------------------------------- 
        private void UnoNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            try
            {
                if (UnoNumericUpDown.Text == "")
                    UnoNumericUpDown.Value = 0;

                UnoTextBox.Text = Convert.ToString(UnoNumericUpDown.Value * 1) + Decimas;
                CalcularTotalEnCaja();

                if (e.KeyCode == Keys.Enter)
                    GuardarButton.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnoNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            try
            {
                if (UnoNumericUpDown.Value == 0)
                    UnoNumericUpDown.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnoNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            try
            {
                if (UnoNumericUpDown.Text == "")
                    UnoNumericUpDown.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
