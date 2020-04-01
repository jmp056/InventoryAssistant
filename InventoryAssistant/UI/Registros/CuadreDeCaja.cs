﻿using InventoryAssistant.BLL;
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
    public partial class CuadreDeCaja : Form
    {
        List<Facturas> ListadoFacturas = new List<Facturas>();
        string Decimas = ".00";
        public CuadreDeCaja()
        {
            InitializeComponent();
        }

        private void CuadreDeCaja_Load(object sender, EventArgs e)
        {
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

            FechaDateTimePicker.Value = DateTime.Now;
            CargarFacturas();
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
            CargarFacturas();
            TotalVendido();
        }

        private void Diferencia() // Funcion encargada de calcular la diferencia entre lo cobrado y lo que hay en caja
        {
            DiferenciaTextBox.Text = Convert.ToString(Convert.ToDecimal(TotalEnCajaTextBox.Text) - Convert.ToDecimal(TotalVendidoTextBox.Text));
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }

        private void DosMilNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MilNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

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
    }
}
