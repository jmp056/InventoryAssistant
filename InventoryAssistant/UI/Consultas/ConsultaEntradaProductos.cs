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
    public partial class ConsultaEntradaProductos : Form
    {
        private List<EntradaProductos> listaEntrada;

        public ConsultaEntradaProductos()
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
            if (FiltroComboBox.Text == "Todo")
            {
                paso = true;
                MyErrorProvider.Clear();
            }
            return paso;
        }

        private void Buscar()
        {
            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();

            var listado = new List<EntradaProductos>();

            if (!Validar())
                return;

            if (CristerioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo: todo
                        listado = repositorio.GetList(p => true);
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
                            listado = repositorio.GetList(p => p.EntradaProductoId == id);
                        }
                        break;
                    case 2://Todo: Productos Id
                        if (CristerioTextBox.Text.Any(x => !char.IsNumber(x)) || CristerioTextBox.Text == string.Empty)
                        {
                            MyErrorProvider.SetError(CristerioTextBox, "No es Un Numero,Digite el ID");
                        }
                        else
                        {
                            int id = Convert.ToInt32(CristerioTextBox.Text);
                            listado = repositorio.GetList(p => p.ProductoId == id);
                        }
                        break;
                    case 3://Usuarios
                      //  listado = repositorio.GetList(p => p.Usuario.Contains(CristerioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            cEntradasdataGridView.DataSource = null;

            cEntradasdataGridView.DataSource = listado;
            listaEntrada = listado;

            cEntradasdataGridView.Columns[0].HeaderText = "ID";
            cEntradasdataGridView.Columns[0].Width = 80;
            cEntradasdataGridView.Columns[1].HeaderText = "Producto Id";
            cEntradasdataGridView.Columns[1].Width = 120;
            cEntradasdataGridView.Columns[2].HeaderText = "Cantidad";
            cEntradasdataGridView.Columns[2].Width = 120;
            cEntradasdataGridView.Columns[3].Width = 150;
            cEntradasdataGridView.Columns[3].HeaderText = "Fecha de Registro";
            cEntradasdataGridView.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void RealizarBusquedaButton_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
