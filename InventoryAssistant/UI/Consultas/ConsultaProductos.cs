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
    public partial class ConsultaProductos : Form
    {
        private List<Productos> listaProducto;

        public ConsultaProductos()
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

            return paso;
        }
        private void Buscar()
        {
            RepositorioBase<Productos> repositorioE = new RepositorioBase<Productos>();

            var listado = new List<Productos>();

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
                            listado = repositorioE.GetList(p => p.ProductoId == id);
                        }
                        break;
                    case 2://Todo: descripcion
                        if (CristerioTextBox.Text == string.Empty)
                        {
                            return;
                        }
                        else
                            listado = repositorioE.GetList(p => p.Descripcion.Contains(CristerioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = repositorioE.GetList(p => true);
            }

            cProductosdataGridView.DataSource = null;

            cProductosdataGridView.DataSource = listado;
            listaProducto = listado;

            cProductosdataGridView.Columns[0].HeaderText = "ID";
            cProductosdataGridView.Columns[0].Width = 40;
            cProductosdataGridView.Columns[1].HeaderText = "Descripcion";
            cProductosdataGridView.Columns[1].Width = 250;
            cProductosdataGridView.Columns[2].Visible = false;
            cProductosdataGridView.Columns[3].Visible = false;
            cProductosdataGridView.Columns[4].Visible = false;
            cProductosdataGridView.Columns[6].Width = 150;
            cProductosdataGridView.Columns[6].HeaderText = "Fecha de Registro";
            cProductosdataGridView.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void RealizarBusquedaButton_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
