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
    public partial class ConsultaFacturas : Form
    {
        private List<Facturas> listaFactura;

        public ConsultaFacturas()
        {
            InitializeComponent();
        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (FiltroComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(FiltroComboBox, "No ha selecionado ningun filtro");
                FiltroComboBox.Focus();
                paso = false;
            }
            if (CristerioTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CristerioTextBox, "El campo Criterio esta vacio");
                CristerioTextBox.Focus();
                paso = false;
            }
            if (FiltroComboBox.Text =="Todo")
            {
                paso = true;
                MyErrorProvider.Clear();
            }

            return paso;
        }

        private void Buscar()
        {
            RepositorioBase<Facturas> repositorioE = new RepositorioBase<Facturas>();

            var listado = new List<Facturas>();

            if (!Validar())
                return;

            if (CristerioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo: todo
                        listado = repositorioE.GetList(p => true);
                        MyErrorProvider.Clear();
                        break;
                    case 1: //Todo: ID
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)) || CristerioTextBox.Text == string.Empty)
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int id = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorioE.GetList(p => p.FacturaId == id);
                        }
                        break;
                    case 2://Todo: Nombres
                        if (CristerioTextBox.Text == string.Empty)
                        {
                            return;
                        }
                        else
                            listado = repositorioE.GetList(p => p.Cliente.Contains(CristerioTextBox.Text));
                        break;
                    case 3://Usuarios
                        listado = repositorioE.GetList(p => p.Usuario.Contains(CristerioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = repositorioE.GetList(p => true);
            }

            cFacturasdataGridView.DataSource = null;

            cFacturasdataGridView.DataSource = listado;
            listaFactura = listado;

            cFacturasdataGridView.Columns[0].HeaderText = "ID";
            cFacturasdataGridView.Columns[0].Width = 50;
            cFacturasdataGridView.Columns[1].HeaderText = "Usuario";
            cFacturasdataGridView.Columns[1].Width = 120;
            cFacturasdataGridView.Columns[2].HeaderText = "Fecha Ingreso";
            cFacturasdataGridView.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            cFacturasdataGridView.Columns[3].HeaderText = "Cliente";
            cFacturasdataGridView.Columns[3].Width = 180;
            cFacturasdataGridView.Columns[4].HeaderText = "Total";
            cFacturasdataGridView.Columns[4].Width = 90;
        }
        private void RealizarBusquedaButton_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
