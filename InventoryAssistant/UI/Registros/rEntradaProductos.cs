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
    public partial class rEntradaProductos : Form
    {/*

        public rEntradaProductos()
        {
            InitializeComponent();
            LlenarComboBox();
        }
        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            ProductoComboBox.SelectedIndex = -1;
            CantidadtextBox
            FechadateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();
        }

        private EntradaProductos LlenaClase()
        {
            EntradaProductos entrada = new EntradaProductos();

            entrada.EntradaId = (int)IdNumericUpDown.Value;
            entrada.ProductoId = Convert.ToInt32(ProductoComboBox.SelectedValue);
            entrada.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            entrada.Fecha = FechadateTimePicker.Value;

            return entrada;
        }

        private void LlenaCampo(EntradaProductos entrada)
        {
            IdNumericUpDown.Value = entrada.EntradaId;
            ProductoComboBox.SelectedValue = entrada.ProductoId;
            CantidadtextBox.Text = entrada.Cantidad.ToString();
            FechadateTimePicker.Value = entrada.Fecha;
        }

        private void LlenarComboBox()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            ProductoComboBox.DataSource = repositorio.GetList(c => true);
            ProductoComboBox.ValueMember = "ProductoId";
            ProductoComboBox.DisplayMember = "Descripcion";
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();
            EntradaProductos entrada = repositorio.Buscar((int)IdNumericUpDown.Value);
            return (entrada != null);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;

            RepositorioEntradaProductos db = new RepositorioEntradaProductos();

            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();
            //if (!Validar())
             //   return;

            EntradaProductos entrada = LlenaClase();


            entrada = LlenaClase();

            if (IdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(entrada);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Entrada de Producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else
                paso = db.Modificar(entrada);
            }
            if (paso)
            {
                MessageBox.Show("Entrada de Producto Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();
            EntradaProductos entrada = new EntradaProductos();

            int.TryParse(IdNumericUpDown.Text, out int id);

            entrada = repositorio.Buscar(id);

            if (entrada != null)
            {
                MyErrorProvider.Clear();
                //Eliminarbutton.Enabled = true;
                LlenaCampo(entrada);
            }
            else
                MyErrorProvider.SetError(IdNumericUpDown, "Entrada de Producto no Encontrado");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioEntradaProductos db = new RepositorioEntradaProductos();

                MyErrorProvider.Clear();
                int.TryParse(IdNumericUpDown.Text, out int id);

                if (!ExisteEnLaBaseDeDatos())
                {
                    MyErrorProvider.SetError(IdNumericUpDown, "Entrada de Producto No Existe!!!");
                    return;
                }
                if (db.Eliminar(id))
                {
                    Limpiar();
                    MessageBox.Show("Entrada de Producto Eliminado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }       
        }
    */}
}
