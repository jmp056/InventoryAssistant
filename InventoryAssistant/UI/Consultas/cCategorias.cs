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
    public partial class cCategorias : Form
    {
        string NombreUsuario;
        int Nivel;
        public int IdCategoriaSeleccionada { get; set; }
        private List<Categorias> ListadoCatgorias = new List<Categorias>();

        public cCategorias(string nombreUsuario, int nivel) // Iniciador del form
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

                if (FiltroComboBox.SelectedIndex > 0) // Valida si el indice seleccionado en el combobox  es mayor a 0
                {
                    if (CriterioTextBox.Text == string.Empty) // En caso de ser mayor a 0, el criterio no este vacio
                    {
                        CriterioTextBox.Width = 175;
                        MyErrorProvider.SetError(CriterioTextBox, "Debe escribir algún criterio de búsqueda!");
                        CriterioTextBox.Focus();
                        paso = false;
                    }
                    else if (FiltroComboBox.SelectedIndex == 1 && CriterioTextBox.Text.Any(x => !char.IsNumber(x))) // Si desea filtrar por codigo, que el criterio solo tenga numeros
                    {
                        CriterioTextBox.Width = 175;
                        MyErrorProvider.SetError(CriterioTextBox, "Si desea filtrar por código, solo digite números!");
                        CriterioTextBox.Focus();
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

                DatosDeLaCategoriaButton.Enabled = false;
                CategoriasDataGridView.DataSource = null;
                CategoriasDataGridView.DataSource = ListadoCatgorias;
                Formato();
                CategoriasDataGridView.ClearSelection();
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
                CategoriasDataGridView.Columns[0].HeaderText = "Codigo";
                CategoriasDataGridView.Columns[0].Width = 50;
                CategoriasDataGridView.Columns[1].HeaderText = "Nombre";
                CategoriasDataGridView.Columns[1].Width = 300;
                CategoriasDataGridView.Columns[2].Visible = false;
                CategoriasDataGridView.Columns[3].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DatosDeLaCategoriaButton_Click(object sender, EventArgs e) // Boton de ver datos de la categoria
        {
            try
            {
                if (Nivel <= 0)
                {
                    IdCategoriaSeleccionada = Convert.ToInt32(CategoriasDataGridView.CurrentRow.Cells["CategoriaId"].Value);
                    rCategorias rC = new rCategorias(NombreUsuario, IdCategoriaSeleccionada);
                    rC.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usted no tiene permiso para realizar esta tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RealizarBusquedaButton_Click(object sender, EventArgs e) // Boton de realizar la busqueda
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

        private void CategoriasDataGridView_Click(object sender, EventArgs e) // Evento de un clic al DataGridView
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CategoriasDataGridView_DoubleClick(object sender, EventArgs e) // Evento de dos clics al DataGridView
        {
            try
            {
                if (Nivel <= 0)
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
                else
                {
                    MessageBox.Show("Usted no tiene permiso para realizar esta tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cCategorias_Load(object sender, EventArgs e) // Evento al cargar el Form
        {
            try
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
                }

                FiltroComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e) // Evento al cambiar la seleccion en el Combobox
        {
            try
            {
                MyErrorProvider.Clear();
                CriterioTextBox.Width = 195;
                CriterioTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
