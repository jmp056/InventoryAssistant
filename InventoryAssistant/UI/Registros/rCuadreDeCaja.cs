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

        private void Limpiar()
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

        private void CuadreDeCaja_Load(object sender, EventArgs e)
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

            if(CuadreDeCajaId == 0)
            {
                FechaDateTimePicker.Value = DateTime.Now;
                CargarFacturas();

            }
            else
            {
                Buscar();

            }
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

        private void Buscar()
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

        public void CargarFacturas()
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

        private void FuenteDelDataGridView()
        {
            this.FacturasDataGridView.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        
        }

        private void TotalVendido()
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

        private void DesgloseGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void FechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Buscar();
            CargarFacturas();
            //if(CuadreDeCajaId == 0)
            //{
            //    CargarFacturas();
            //    TotalVendido();
            //}
            //else
            //{
            //    Buscar();
            //    CuadreDeCajaId = 0;
            //}

        }

        private void Diferencia() // Funcion encargada de calcular la diferencia entre lo cobrado y lo que hay en caja
        {
            DiferenciaTextBox.Text = Convert.ToString(Convert.ToDecimal(TotalEnCajaTextBox.Text) - Convert.ToDecimal(TotalVendidoTextBox.Text));
        }

        private void GuardarButton_Click(object sender, EventArgs e)
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

        private void QuinientosNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DoscientosNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CienNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CincuentaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void VeinticincoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void VeinteNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DiezNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CincoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UnoNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DosMilNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void DosMilNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            DosmilTextBox.Text = Convert.ToString(DosMilNumericUpDown.Value * 2000) + Decimas;
            CalcularTotalEnCaja();
        }

        private void MilNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            MilTextBox.Text = Convert.ToString(MilNumericUpDown.Value * 1000) + Decimas;
            CalcularTotalEnCaja();
        }

        private void QuinientosNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            QuinientosTextBox.Text = Convert.ToString(QuinientosNumericUpDown.Value * 500) + Decimas;
            CalcularTotalEnCaja();
        }

        private void DoscientosNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            DoscientosTextBox.Text = Convert.ToString(DoscientosNumericUpDown.Value * 200) + Decimas;
            CalcularTotalEnCaja();
        }

        private void CienNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            CienTextBox.Text = Convert.ToString(CienNumericUpDown.Value * 100) + Decimas;
            CalcularTotalEnCaja();
        }

        private void CincuentaNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            CincuentaTextBox.Text = Convert.ToString(CincuentaNumericUpDown.Value * 50) + Decimas;
            CalcularTotalEnCaja();
        }

        private void VeinticincoNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            VeinticincoTextBox.Text = Convert.ToString(VeinticincoNumericUpDown.Value * 25) + Decimas;
            CalcularTotalEnCaja();
        }

        private void VeinteNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            VeinteTextBox.Text = Convert.ToString(VeinteNumericUpDown.Value * 20) + Decimas;
            CalcularTotalEnCaja();
        }

        private void DiezNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            DiezTextBox.Text = Convert.ToString(DiezNumericUpDown.Value * 10) + Decimas;
            CalcularTotalEnCaja();
        }

        private void CincoNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            CincoTextBox.Text = Convert.ToString(CincoNumericUpDown.Value * 5) + Decimas;
            CalcularTotalEnCaja();
        }

        private void UnoNumericUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            UnoTextBox.Text = Convert.ToString(UnoNumericUpDown.Value * 1) + Decimas;
            CalcularTotalEnCaja();
        }

        private void TotalEnCajaTextBox_TextChanged(object sender, EventArgs e)
        {
            Diferencia();
        }

        private void DosMilNumericUpDown_Enter(object sender, EventArgs e)
        {

        }

        private void TotalVendidoTextBox_TextChanged(object sender, EventArgs e)
        {
            Diferencia();
        }

        private void CalcularTotales()
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

        private void FacturasDataGridView_DoubleClick(object sender, EventArgs e)
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
}
