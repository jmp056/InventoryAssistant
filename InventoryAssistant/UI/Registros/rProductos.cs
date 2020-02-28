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
        }

        private void Limpiar()// Funcion encargada de limpiar todos los campos del registro
        {
            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            CategoriaComboBox.SelectedIndex = -1;
            ControlAlmacenCheckBox.Checked = false;
            CantidadNumericUpDown.Value = 0;
            PrecioNumericUpDown.Value = 0;
            FechaDeRegistroDateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();
        }
        //************
        private void LlenarCategoria()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            CategoriaComboBox.DataSource = repositorio.GetList(p => true);
            CategoriaComboBox.ValueMember = "CategoriaId";
            CategoriaComboBox.DisplayMember = "Nombre";
        }

        private Productos LlenaClase()// Funcion encargada de llenar el objeto
        {
            Productos Producto = new Productos();

            Producto.ProductoId = (int)IdNumericUpDown.Value;
            Producto.Descripcion = DescripcionTextBox.Text;
            Producto.Categoria = Convert.ToInt32(CategoriaComboBox.SelectedIndex);
            Producto.ControlAlmacen = ControlAlmacenCheckBox.Checked;
            Producto.Cantidad = Convert.ToInt32(CantidadNumericUpDown.Value);
            Producto.Precio = Convert.ToInt32(PrecioNumericUpDown.Value);
            Producto.FechaDeRegistro = FechaDeRegistroDateTimePicker.Value;

            return Producto;
        }

        private void LlenaCampo(Productos Producto)// Funcion encargada de llenar los campos del registro con los datos de un objeto
        {
            IdNumericUpDown.Value = Producto.ProductoId;
            DescripcionTextBox.Text = Producto.Descripcion;
            CategoriaComboBox.SelectedIndex= Producto.Categoria;
            ControlAlmacenCheckBox.Checked = Producto.ControlAlmacen;
            CantidadNumericUpDown.Value= Producto.Cantidad;
            PrecioNumericUpDown.Value = Producto.Precio;
            FechaDeRegistroDateTimePicker.Value = Producto.FechaDeRegistro;
        }


        private bool Validar()//Funcion que valida todo el registro
        {
            bool Paso = true;
            MyErrorProvider.Clear();

            if (DescripcionTextBox.Text == string.Empty) // Condicion encargada de validar que el campo descripcion no este vacio
            {
                MyErrorProvider.SetError(DescripcionTextBox, "El descripcion no puede estar vacío!");
                DescripcionTextBox.Focus();
                Paso = false;
            }

            if (CategoriaComboBox.SelectedIndex < 0) // Condicion encargada de validar que el campo categoria este seleccionado
            {
                MyErrorProvider.SetError(CategoriaComboBox, "Debe seleccionar una categoría!");
                CategoriaComboBox.Focus();
                Paso = false;
            }

            if (PrecioNumericUpDown.Value == 0) // Condicion encargada de validar que el campo categoria este seleccionado
            {
                MyErrorProvider.SetError(PrecioNumericUpDown, "Debe seleccionar una categoría!");
                PrecioNumericUpDown.Focus();
                Paso = false;
            }
            return Paso;


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
