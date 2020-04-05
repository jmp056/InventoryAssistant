using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using InventoryAssistant.Entidades.EntidadesParaConsultas;
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
    public partial class cUsuarios : Form
    {
        string NombreUsuario;
        public int IdUsuarioSeleccionado { get; set; }
        private List<Usuarios> ListadoUsuarios = new List<Usuarios>();
        private List<UsuariosConsulta> ListadoUsuariosConsulta = new List<UsuariosConsulta>();

        public cUsuarios(string nombreUsuario)
        {
            try
            {
                this.NombreUsuario = nombreUsuario;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()//Funcion encargada de validar la busqueda 
        {
            bool paso = true;

            try
            {
                MyErrorProvider.Clear();

                if (FiltroComboBox.SelectedIndex > 0)
                {
                    if (CriterioTextBox.Text == string.Empty)
                    {
                        CriterioTextBox.Width = 160;
                        MyErrorProvider.SetError(CriterioTextBox, "Debe escribir algún criterio de búsqueda!");
                        CriterioTextBox.Focus();
                        paso = false;
                    }
                    else if (FiltroComboBox.SelectedIndex == 1 && CriterioTextBox.Text.Any(x => !char.IsNumber(x)))
                    {
                        CriterioTextBox.Width = 160;
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

        private List<UsuariosConsulta> CargarLista(List<Usuarios> ListaSinProcesar)
        {
            RepositorioBase<Usuarios> repositorio = new RepositorioBase<Usuarios>();
            List<UsuariosConsulta> ListaProcesada = new List<UsuariosConsulta>();

            try
            {
                foreach (var item in ListaSinProcesar)
                {
                    UsuariosConsulta u = new UsuariosConsulta();
                    u.UsuarioId = item.UsuarioId;
                    u.Nombres = item.Nombres + " " + item.Apellidos;
                    u.Cedula = item.Cedula;
                    u.Celular = item.Celular;
                    u.Usuario = item.Usuario;
                    if (item.NivelDeUsuario == 0)
                        u.NivelDeUsuario = "Administrador";
                    else if (item.NivelDeUsuario == 1)
                        u.NivelDeUsuario = "Supervisor";
                    else
                        u.NivelDeUsuario = "Usuario";

                    ListaProcesada.Add(u);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ListaProcesada;
        }

        private void Buscar() // Funcion que realiza las bsquedas
        {
            try
            {
                RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
                ListadoUsuarios = new List<Usuarios>();
                ListadoUsuarios = Repositorio.GetList(p => true);
                ListadoUsuariosConsulta = new List<UsuariosConsulta>();
                ListadoUsuariosConsulta = CargarLista(ListadoUsuarios);

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

                        case 1: //Filtrar por Id
                            ListadoUsuariosConsulta = ListadoUsuariosConsulta.Where(l => l.UsuarioId.ToString().Contains(CriterioTextBox.Text)).ToList();
                            break;

                        case 2://Filtrar por Nombre
                            ListadoUsuariosConsulta = ListadoUsuariosConsulta.Where(l => l.Nombres.Contains(CriterioTextBox.Text.ToUpper())).ToList();
                            break;

                        case 3://Filtrar por Cedula
                            ListadoUsuariosConsulta = ListadoUsuariosConsulta.Where(l => l.Cedula.Contains(CriterioTextBox.Text)).ToList();
                            break;

                        case 4://Filtrar por Celular
                            ListadoUsuariosConsulta = ListadoUsuariosConsulta.Where(l => l.Celular.Contains(CriterioTextBox.Text)).ToList();
                            break;

                        case 5://Filtrar por Usuario
                            ListadoUsuariosConsulta = ListadoUsuariosConsulta.Where(l => l.Usuario.Contains(CriterioTextBox.Text)).ToList();
                            break;

                        case 6://Filtrar por Nivel de usuario
                            ListadoUsuariosConsulta = ListadoUsuariosConsulta.Where(l => l.NivelDeUsuario.ToUpper().Contains(CriterioTextBox.Text.ToUpper())).ToList();
                            break;
                }

                DatosDelUsuarioButton.Enabled = false;
                UsuariosDataGridView.DataSource = null;
                UsuariosDataGridView.DataSource = ListadoUsuariosConsulta;
                Formato();
                UsuariosDataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Formato()//Le da el formato a la consulta
        {
            try
            {
                UsuariosDataGridView.Columns[0].HeaderText = "Codigo";
                UsuariosDataGridView.Columns[0].Width = 50;
                UsuariosDataGridView.Columns[1].HeaderText = "Nombres y Apellidos";
                UsuariosDataGridView.Columns[1].Width = 300;
                UsuariosDataGridView.Columns[2].HeaderText = "Cedula";
                UsuariosDataGridView.Columns[2].Width = 85;
                UsuariosDataGridView.Columns[3].HeaderText = "Celular";
                UsuariosDataGridView.Columns[3].Width = 80;
                UsuariosDataGridView.Columns[4].HeaderText = "Usuario";
                UsuariosDataGridView.Columns[4].Width = 70;
                UsuariosDataGridView.Columns[5].HeaderText = "Nivel de Usuario";
                UsuariosDataGridView.Columns[5].Width = 110;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConsultasUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
                ListadoUsuarios = new List<Usuarios>();
                ListadoUsuarios = Repositorio.GetList(p => true);
                ListadoUsuariosConsulta = CargarLista(ListadoUsuarios);

                if (ListadoUsuariosConsulta.Count > 0)
                {
                    UsuariosDataGridView.DataSource = null;
                    UsuariosDataGridView.DataSource = ListadoUsuariosConsulta;
                    Formato();
                    UsuariosDataGridView.ClearSelection();
                }

                DatosDelUsuarioButton.Enabled = false;
                FiltroComboBox.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsuariosDataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListadoUsuariosConsulta.Count > 0)
                {
                    if (UsuariosDataGridView.CurrentRow.Index >= 0)
                    {
                        DatosDelUsuarioButton.Enabled = true;
                    }
                    else
                    {
                        DatosDelUsuarioButton.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsuariosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ListadoUsuariosConsulta.Count > 0)
                {
                    if (UsuariosDataGridView.CurrentRow.Index >= 0)
                    {
                        DatosDelUsuarioButton.Enabled = true;
                        IdUsuarioSeleccionado = Convert.ToInt32(UsuariosDataGridView.CurrentRow.Cells["UsuarioId"].Value);
                        rUsuarios rU = new rUsuarios(NombreUsuario, IdUsuarioSeleccionado);
                        rU.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void DatosDelUsuarioButton_Click(object sender, EventArgs e)
        {
            try
            {
                IdUsuarioSeleccionado = Convert.ToInt32(UsuariosDataGridView.CurrentRow.Cells["UsuarioId"].Value);
                rUsuarios rU = new rUsuarios(NombreUsuario, IdUsuarioSeleccionado);
                rU.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RealizarBusquedaButton_Click(object sender, EventArgs e)
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

        private void FiltroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MyErrorProvider.Clear();
                CriterioTextBox.Width = 180;
                CriterioTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
