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
            this.NombreUsuario = nombreUsuario;
            this.Nivel = nivel;
            this.CuadreDeCajaId = cuadreDeCajaId;
            InitializeComponent();
        }

        private void Limpiar() // Funcion encargada de limiar todo el registro
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

        private void CuadreDeCaja_Load(object sender, EventArgs e) // Cargar el Form
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

        private CuadresDeCaja LlenaClase()  // Funcion encargada de llenar el objeto
        {
            CuadresDeCaja CuadreDeCaja = new CuadresDeCaja();

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

            return CuadreDeCaja;
        }

        private void LlenaCampo(CuadresDeCaja CuadreDeCaja)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
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

        private bool ExisteEnLaBaseDeDatos() // Funcnion encargada de verificar si un usuario exist en una base de datos!
        {
            RepositorioBase<CuadresDeCaja> Repositorio = new RepositorioBase<CuadresDeCaja>();
            int Codigo = Convert.ToInt32(Convert.ToString(FechaDateTimePicker.Value.Day) + Convert.ToString(FechaDateTimePicker.Value.Month) + Convert.ToString(FechaDateTimePicker.Value.Year));
            CuadresDeCaja CuadreDeCaja = Repositorio.Buscar(Codigo);
            return (CuadreDeCaja != null);
        }

        private void Buscar() // Funcion encargada de realizar la busqueda
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

        public void CargarFacturas() // Funcion encargada de cargar las facturas
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

        private void FuenteDelDataGridView() // Funcion encargada de cambiarle la fuente al DataGrisViiew
        {
            this.FacturasDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        
        }

        private void TotalVendido() // Funcion encargada de calcular el total vendido
        {
            double TotalVendido = 0;
            foreach (DataGridViewRow produ in FacturasDataGridView.Rows)
            {
                TotalVendido += Convert.ToDouble(produ.Cells["Total"].Value);
            }
            TotalVendidoTextBox.Text = Convert.ToString(TotalVendido) + ".00";
        }

        private void Formato()//Le da el formato al DataGridView
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

        private void Diferencia() // Funcion encargada de calcular la diferencia entre lo cobrado y lo que hay en caja
        {
            DiferenciaTextBox.Text = Convert.ToString(Convert.ToDecimal(TotalEnCajaTextBox.Text) - Convert.ToDecimal(TotalVendidoTextBox.Text));
        }

        private void GuardarButton_Click(object sender, EventArgs e) // Clic al boton guardar
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

        private void CalcularTotalEnCaja()//Funcion encargada de calcular el total en caja
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

        private void CalcularTotales() // Funcion encargada de calcular los totales de los TextBox del desglose
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

        private void FacturasDataGridView_DoubleClick(object sender, EventArgs e) // Dos clic al DataGridView de las facturas
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

        private void FechaDateTimePicker_ValueChanged(object sender, EventArgs e) // Al Cambiar el valor del DataTimePicker de la fecha
        {
            Buscar();
            CargarFacturas();
        }
       
        private void TotalEnCajaTextBox_TextChanged(object sender, EventArgs e) // Calcula la diferencia si el total en caja cambia
        {
            Diferencia();
        }

        private void TotalVendidoTextBox_TextChanged(object sender, EventArgs e) // Calcula la diferencia si el total vendido cambia
        {
            Diferencia();
        }
        
        // ------------------------------------- Numeric's up downs ---------------------------------------------------------//
        
        // NUMERIC UP DOUWN DE DOSMIL -------------------------------------------------------------------------------------------------- 
        private void DosMilNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            if (DosMilNumericUpDown.Text == "")
                DosMilNumericUpDown.Value = 0;

            DosmilTextBox.Text = Convert.ToString(DosMilNumericUpDown.Value * 2000) + Decimas;
            CalcularTotalEnCaja();

            if (e.KeyCode == Keys.Enter)
                MilNumericUpDown.Focus();
        }

        private void DosMilNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            if (DosMilNumericUpDown.Value == 0)
                DosMilNumericUpDown.Text = "";
        }

        private void DosMilNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            if (DosMilNumericUpDown.Text == "")
                DosMilNumericUpDown.Text = "0";
        }

        // NUMERIC UP DOUWN DE MIL -------------------------------------------------------------------------------------------------- 
        private void MilNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            if (MilNumericUpDown.Text == "")
                MilNumericUpDown.Value = 0;

            MilTextBox.Text = Convert.ToString(MilNumericUpDown.Value * 1000) + Decimas;
            CalcularTotalEnCaja();

            if (e.KeyCode == Keys.Enter)
                QuinientosNumericUpDown.Focus();
        }

        private void MilNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            if (MilNumericUpDown.Value == 0)
                MilNumericUpDown.Text = "";
        }

        private void MilNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            if (MilNumericUpDown.Text == "")
                MilNumericUpDown.Text = "0";
        }

        // NUMERIC UP DOUWN DE QUINIENTOS -------------------------------------------------------------------------------------------------- 
        private void QuinientosNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            if (QuinientosNumericUpDown.Text == "")
                QuinientosNumericUpDown.Value = 0;

            QuinientosTextBox.Text = Convert.ToString(QuinientosNumericUpDown.Value * 500) + Decimas;
            CalcularTotalEnCaja();

            if (e.KeyCode == Keys.Enter)
                DoscientosNumericUpDown.Focus();
        }

        private void QuinientosNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            if (QuinientosNumericUpDown.Value == 0)
                QuinientosNumericUpDown.Text = "";
        }

        private void QuinientosNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            if (QuinientosNumericUpDown.Text == "")
                QuinientosNumericUpDown.Text = "0";
        }

        // NUMERIC UP DOUWN DE DOSCIENTOS -------------------------------------------------------------------------------------------------- 
        private void DoscientosNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            if (DoscientosNumericUpDown.Text == "")
                DoscientosNumericUpDown.Value = 0;

            DoscientosTextBox.Text = Convert.ToString(DoscientosNumericUpDown.Value * 200) + Decimas;
            CalcularTotalEnCaja();

            if (e.KeyCode == Keys.Enter)
                CienNumericUpDown.Focus();
        }

        private void DoscientosNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            if (DoscientosNumericUpDown.Value == 0)
                DoscientosNumericUpDown.Text = "";
        }

        private void DoscientosNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            if (DoscientosNumericUpDown.Text == "")
                DoscientosNumericUpDown.Text = "0";
        }

        // NUMERIC UP DOUWN DE CIEN -------------------------------------------------------------------------------------------------- 
        private void CienNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            if (CienNumericUpDown.Text == "")
                CienNumericUpDown.Value = 0;

            CienTextBox.Text = Convert.ToString(CienNumericUpDown.Value * 100) + Decimas;
            CalcularTotalEnCaja();

            if (e.KeyCode == Keys.Enter)
                CincuentaNumericUpDown.Focus();
        }

        private void CienNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            if (CienNumericUpDown.Value == 0)
                CienNumericUpDown.Text = "";
        }

        private void CienNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            if (CienNumericUpDown.Text == "")
                CienNumericUpDown.Text = "0";
        }

        // NUMERIC UP DOUWN DE CINCUENTA -------------------------------------------------------------------------------------------------- 
        private void CincuentaNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            if (CincuentaNumericUpDown.Text == "")
                CincuentaNumericUpDown.Value = 0;

            CincuentaTextBox.Text = Convert.ToString(CincuentaNumericUpDown.Value * 50) + Decimas;
            CalcularTotalEnCaja();

            if (e.KeyCode == Keys.Enter)
                VeinticincoNumericUpDown.Focus();
        }

        private void CincuentaNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            if (CincuentaNumericUpDown.Value == 0)
                CincuentaNumericUpDown.Text = "";
        }

        private void CincuentaNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            if (CincuentaNumericUpDown.Text == "")
                CincuentaNumericUpDown.Text = "0";
        }

        // NUMERIC UP DOUWN DE VEINTICINCO -------------------------------------------------------------------------------------------------- 
        private void VeinticincoNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            if (VeinticincoNumericUpDown.Text == "")
                VeinticincoNumericUpDown.Value = 0;

            VeinticincoTextBox.Text = Convert.ToString(VeinticincoNumericUpDown.Value * 25) + Decimas;
            CalcularTotalEnCaja();

            if (e.KeyCode == Keys.Enter)
                VeinteNumericUpDown.Focus();
        }

        private void VeinticincoNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            if (VeinticincoNumericUpDown.Value == 0)
                VeinticincoNumericUpDown.Text = "";
        }

        private void VeinticincoNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            if (VeinticincoNumericUpDown.Text == "")
                VeinticincoNumericUpDown.Text = "0";
        }

        // NUMERIC UP DOUWN DE VEINTE -------------------------------------------------------------------------------------------------- 
        private void VeinteNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            if (VeinteNumericUpDown.Text == "")
                VeinteNumericUpDown.Value = 0;

            VeinteTextBox.Text = Convert.ToString(VeinteNumericUpDown.Value * 20) + Decimas;
            CalcularTotalEnCaja();

            if (e.KeyCode == Keys.Enter)
                DiezNumericUpDown.Focus();
        }

        private void VeinteNumericUpDown_Enter(object sender, EventArgs e) // Al salir el foco
        {
            if (VeinteNumericUpDown.Value == 0)
                VeinteNumericUpDown.Text = "";
        }

        private void VeinteNumericUpDown_Leave(object sender, EventArgs e) // Al entrar el foco
        {
            if (VeinteNumericUpDown.Text == "")
                VeinteNumericUpDown.Text = "0";
        }

        // NUMERIC UP DOUWN DE DIEZ -------------------------------------------------------------------------------------------------- 
        private void DiezNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            if (DiezNumericUpDown.Text == "")
                DiezNumericUpDown.Value = 0;

            DiezTextBox.Text = Convert.ToString(DiezNumericUpDown.Value * 10) + Decimas;
            CalcularTotalEnCaja();

            if (e.KeyCode == Keys.Enter)
                CincoNumericUpDown.Focus();
        }

        private void DiezNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            if (DiezNumericUpDown.Value == 0)
                DiezNumericUpDown.Text = "";
        }

        private void DiezNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            if (DiezNumericUpDown.Text == "")
                DiezNumericUpDown.Text = "0";
        }

        // NUMERIC UP DOUWN DE CINCO -------------------------------------------------------------------------------------------------- 
        private void CincoNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            if (CincoNumericUpDown.Text == "")
                CincoNumericUpDown.Value = 0;

            CincoTextBox.Text = Convert.ToString(CincoNumericUpDown.Value * 5) + Decimas;
            CalcularTotalEnCaja();

            if (e.KeyCode == Keys.Enter)
                UnoNumericUpDown.Focus();
        }

        private void CincoNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            if (CincoNumericUpDown.Value == 0)
                CincoNumericUpDown.Text = "";
        }

        private void CincoNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            if (CincoNumericUpDown.Text == "")
                CincoNumericUpDown.Text = "0";
        }

        // NUMERIC UP DOUWN DE UNO -------------------------------------------------------------------------------------------------- 
        private void UnoNumericUpDown_KeyUp(object sender, KeyEventArgs e) // Al precionar una tecla
        {
            if (UnoNumericUpDown.Text == "")
                UnoNumericUpDown.Value = 0;

            UnoTextBox.Text = Convert.ToString(UnoNumericUpDown.Value * 1) + Decimas;
            CalcularTotalEnCaja();

            if (e.KeyCode == Keys.Enter)
                GuardarButton.Focus();
        }

        private void UnoNumericUpDown_Enter(object sender, EventArgs e) // Al entrar el foco
        {
            if (UnoNumericUpDown.Value == 0)
                UnoNumericUpDown.Text = "";
        }

        private void UnoNumericUpDown_Leave(object sender, EventArgs e) // Al salir el foco
        {
            if (UnoNumericUpDown.Text == "")
                UnoNumericUpDown.Text = "0";
        }

    }
}
