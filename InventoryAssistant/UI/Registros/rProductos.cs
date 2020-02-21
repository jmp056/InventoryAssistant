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
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
            LlenarCategoria();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            CategoriaComboBox.SelectedItem = null;
            ControlAlmacenCheckBox.Checked = false;
            CantidadNumericUpDown.Text = string.Empty;
            PreciotextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }
        private void LlenarCategoria()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            CategoriaComboBox.DataSource = repositorio.GetList(p => true);
            CategoriaComboBox.ValueMember = "CategoriaId";
            CategoriaComboBox.DisplayMember = "Nombre";
        }

        private Productos LlenaClase()
        {
            Productos producto = new Productos();

            producto.ProductoId = (int)IdNumericUpDown.Value;
            producto.Descripcion = DescripcionTextBox.Text;
            producto.Categoria = Convert.ToInt32(CategoriaComboBox.SelectedValue);
            producto.ControlAlmacen = ControlAlmacenCheckBox.Checked;
            // producto.Cantidad = Convert.ToInt32(CantidadNumericUpDown.Value);
            producto.Precio = Convert.ToInt32(PreciotextBox.Text);

            return producto;
        }

        private void LlenaCampo(Productos producto)
        {
            IdNumericUpDown.Value = producto.ProductoId;
            DescripcionTextBox.Text = producto.Descripcion;
            CategoriaComboBox.SelectedValue = producto.Categoria;
            ControlAlmacenCheckBox.Checked = producto.ControlAlmacen;
            CantidadNumericUpDown.Text = producto.Inventario.ToString();
            PreciotextBox.Text = producto.Precio.ToString();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos producto = new Productos();

            int.TryParse(IdNumericUpDown.Text, out int id);

            producto = repositorio.Buscar(id);

            if (producto != null)
            {
                MyErrorProvider.Clear();
               // Eliminarbutton.Enabled = true;
                LlenaCampo(producto);
            }
            else
                MyErrorProvider.SetError(IdNumericUpDown, "Producto no Encontrado");
        }

        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos producto = repositorio.Buscar((int)IdNumericUpDown.Value);
            return (producto != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();

            Productos producto = new Productos();
            bool paso = false;

           // if (!Validar())
              //  return;

            producto = LlenaClase();

            if (IdNumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(producto);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Producto que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (repositorio.Duplicado(p => p.Descripcion == DescripcionTextBox.Text))
                {
                    MyErrorProvider.SetError(DescripcionTextBox, "Este Producto ya Existe!!!");
                    return;
                }
                paso = repositorio.Modificar(producto);
            }
            if (paso)
            {
                MessageBox.Show("Producto Guardado!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
