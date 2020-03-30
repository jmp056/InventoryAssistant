using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
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
    public partial class cCategorias : Form
    {
        string NombreUsuario;
        public int IdCategoriaSeleccionada { get; set; }
        private List<Categorias> ListadoCatgorias = new List<Categorias>();

        public cCategorias(string nombreUsuario)
        {
            this.NombreUsuario = nombreUsuario;
            InitializeComponent();
        }
        private bool Validar()//Funcion encargada de validar la busqueda 
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (FiltroComboBox.SelectedIndex > 0 && CriterioTextBox.Text == string.Empty || FiltroComboBox.SelectedIndex > 0 && CriterioTextBox.Text.Trim().Length > 0)
            {
                CriterioTextBox.Width = 175;
                MyErrorProvider.SetError(CriterioTextBox, "Debe escribir algún criterio de búsqueda!");
                CriterioTextBox.Focus();
                paso = false;
            }
            else
            {
                if (FiltroComboBox.SelectedIndex == 1 && CriterioTextBox.Text.Any(x => !char.IsNumber(x)))
                {
                    CriterioTextBox.Width = 175;
                    MyErrorProvider.SetError(CriterioTextBox, "Si desea filtrar por código, solo digite números!");
                    CriterioTextBox.Focus();
                    paso = false;
                }
            }

            return paso;
        }

        private void Buscar() // Funcion que realiza las bsquedas
        {
            RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();
            ListadoCatgorias = new List<Categorias>();
            ListadoCatgorias = Repositorio.GetList(p => true);

            if (FiltroComboBox.SelectedIndex > 0)
            {
                if (!Validar())
                    return;
            }
            else
            {
                MyErrorProvider.Clear();
            }
            CriterioTextBox.Width = 195;

                switch (FiltroComboBox.SelectedIndex)
                {

                    case 1: //Filtrar por Id
                        ListadoCatgorias = ListadoCatgorias.Where(l => l.CategoriaId.ToString().Contains(CriterioTextBox.Text)).ToList();
                        break;

                    case 2://Filtrar por Nombre
                        ListadoCatgorias = ListadoCatgorias.Where(l => l.Nombre.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                        break;

                }

            CategoriasDataGridView.DataSource = null;
            CategoriasDataGridView.DataSource = ListadoCatgorias;
            Formato();
            CategoriasDataGridView.ClearSelection();
        }

        private void Formato()//Le da el formato a la consulta
        {
            CategoriasDataGridView.Columns[0].HeaderText = "Codigo";
            CategoriasDataGridView.Columns[0].Width = 50;
            CategoriasDataGridView.Columns[1].HeaderText = "Nombre";
            CategoriasDataGridView.Columns[1].Width = 300;
            CategoriasDataGridView.Columns[2].Visible = false;
            CategoriasDataGridView.Columns[3].Visible = false;
        }

        private void DatosDeLaCategoriaButton_Click(object sender, EventArgs e)
        {
            IdCategoriaSeleccionada = Convert.ToInt32(CategoriasDataGridView.CurrentRow.Cells["CategoriaId"].Value);
            rCategorias rC = new rCategorias(NombreUsuario, IdCategoriaSeleccionada);
            rC.ShowDialog();
        }

        private void RealizarBusquedaButton_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void CategoriasDataGridView_Click(object sender, EventArgs e)
        {
            if (ListadoCatgorias.Count > 0)
            {
                if (CategoriasDataGridView.CurrentRow.Index >= 0)
                {
                    DatosDeLaCategoriaButton.Enabled = true;
                }
                else
                {
                    DatosDeLaCategoriaButton.Enabled = false;
                }
            }
        }

        private void CategoriasDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if (ListadoCatgorias.Count > 0)
            {
                if (CategoriasDataGridView.CurrentRow.Index >= 0)
                {
                    DatosDeLaCategoriaButton.Enabled = true;
                    IdCategoriaSeleccionada = Convert.ToInt32(CategoriasDataGridView.CurrentRow.Cells["CategoriaId"].Value);
                    rCategorias rC = new rCategorias(NombreUsuario, IdCategoriaSeleccionada);
                    rC.ShowDialog();
                }
            }
        }

        private void cCategorias_Load(object sender, EventArgs e)
        {
            DatosDeLaCategoriaButton.Enabled = false;
            RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();
            ListadoCatgorias = new List<Categorias>();
            ListadoCatgorias = Repositorio.GetList(p => true);

            if (ListadoCatgorias.Count > 0)
            {
                CategoriasDataGridView.DataSource = null;
                CategoriasDataGridView.DataSource = ListadoCatgorias;
                Formato();
                CategoriasDataGridView.ClearSelection();
                DatosDeLaCategoriaButton.Enabled = false;
            }

            FiltroComboBox.SelectedIndex = 0;
        }
    }
}
