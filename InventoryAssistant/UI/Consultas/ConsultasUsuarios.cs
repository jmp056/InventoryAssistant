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
    public partial class ConsultasUsuarios : Form
    {
        private List<Usuarios> listaUsuario;

        public ConsultasUsuarios()
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
            RepositorioBase<Usuarios> repositorioE = new RepositorioBase<Usuarios>();

            var listado = new List<Usuarios>();

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
                            listado = repositorioE.GetList(p => p.UsuarioId == id);
                        }
                        break;
                    case 2://Todo: Nombres
                        if (CristerioTextBox.Text == string.Empty)
                        {
                            return;
                        }
                        else
                            listado = repositorioE.GetList(p => p.Nombres.Contains(CristerioTextBox.Text));
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

            cUsuariosdataGridView.DataSource = null;

            cUsuariosdataGridView.DataSource = listado;
            listaUsuario = listado;

            cUsuariosdataGridView.Columns[0].HeaderText = "ID";
            cUsuariosdataGridView.Columns[0].Width = 40;
            cUsuariosdataGridView.Columns[1].HeaderText = "Nombres";
            cUsuariosdataGridView.Columns[1].Width = 120;
            cUsuariosdataGridView.Columns[2].HeaderText = "Apellidos";
            cUsuariosdataGridView.Columns[2].Width = 120;
            cUsuariosdataGridView.Columns[3].HeaderText = "Cedula";
            cUsuariosdataGridView.Columns[3].Width = 80;
            cUsuariosdataGridView.Columns[4].HeaderText = "Celular";
            cUsuariosdataGridView.Columns[4].Width = 80;
            cUsuariosdataGridView.Columns[5].HeaderText = "Fecha Ingreso";
            cUsuariosdataGridView.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
            // cUsuariosdataGridView.Columns[4].Visible = false;
            cUsuariosdataGridView.Columns[6].Visible = false;
            // cUsuariosdataGridView.Columns[6].Width = 100;
            cUsuariosdataGridView.Columns[7].Visible = false;
            cUsuariosdataGridView.Columns[8].Visible = false;
            cUsuariosdataGridView.Columns[9].Visible = false;
            cUsuariosdataGridView.Columns[10].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
