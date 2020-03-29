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
        string NombreUsuario;
        int Nivel;

        public rProductos(string nombreUsuario, int nivel)
        {
            this.NombreUsuario = nombreUsuario;
            this.Nivel = nivel;
            InitializeComponent();
            Limpiar();
        }

        private void rProductos_Activated(object sender, EventArgs e)//Llena el ComboBox de las categorias cuando la ventana gana el foco
        {
            LlenaComboBoxCategorias();
            CategoriaComboBox.SelectedIndex = -1;
        }
        private void rProductos_Load(object sender, EventArgs e)//Da el foco al TextBox Descripcion cuando la ventana carga
        {
            CantidadNumericUpDown.Enabled = (Nivel <= 0) ? true: false;
        }

        private void Limpiar()// Funcion encargada de limpiar todos los campos del registro
        {
            ProductoIdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            CategoriaComboBox.SelectedIndex = -1;
            ControlAlmacenCheckBox.Checked = true;
            CantidadNumericUpDown.Value = 0;
            PrecioNumericUpDown.Value = 0;
            FechaDeRegistroDateTimePicker.Value = DateTime.Now;
            MyErrorProvider.Clear();

            EstadoToolStripStatusLabel.Text = string.Empty;
            UsuarioToolStripStatusLabel.Text = string.Empty;
        }

        private Productos LlenaClase()// Funcion encargada de llenar el objeto
        {
            Productos Producto = new Productos();

            Producto.ProductoId = (int)ProductoIdNumericUpDown.Value;
            Producto.Descripcion = DescripcionTextBox.Text.ToUpper();
            Producto.CategoriaId = Convert.ToInt32(CategoriaComboBox.SelectedValue);
            Producto.ControlAlmacen = ControlAlmacenCheckBox.Checked;
            Producto.Cantidad = Convert.ToInt32(CantidadNumericUpDown.Value);
            Producto.Precio = Convert.ToInt32(PrecioNumericUpDown.Value);
            Producto.FechaDeRegistro = FechaDeRegistroDateTimePicker.Value;

            Producto.Estado = (Producto.ProductoId == 0) ? false : true;
            Producto.UsuarioR = NombreUsuario;

            return Producto;
        }

        private void LlenaCampo(Productos Producto)// Funcion encargada de llenar los campos del registro con los datos de un objeto
        {
            ProductoIdNumericUpDown.Value = Producto.ProductoId;
            DescripcionTextBox.Text = Producto.Descripcion;
            CategoriaComboBox.SelectedValue = Producto.CategoriaId;
            ControlAlmacenCheckBox.Checked = Producto.ControlAlmacen;
            CantidadNumericUpDown.Value= Producto.Cantidad;
            PrecioNumericUpDown.Value = Producto.Precio;
            FechaDeRegistroDateTimePicker.Value = Producto.FechaDeRegistro;

            EstadoToolStripStatusLabel.Text = (Producto.Estado == false) ? "Agregado por: " : "Modificado por: ";
            UsuarioToolStripStatusLabel.Text = Producto.UsuarioR;
        }

        public void LlenaComboBoxCategorias() // Funcion encargada de llenar el ComboBox de las categorias
        {
            RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();
            var categorias = new List<Categorias>();
            categorias = Repositorio.GetList(p => true);
            CategoriaComboBox.DataSource = categorias;
            CategoriaComboBox.ValueMember = "CategoriaId";
            CategoriaComboBox.DisplayMember = "Nombre";
        }


        private bool Validar()//Funcion que valida todo el registro
        {
            bool Paso = true;
            MyErrorProvider.Clear();

            if (DescripcionTextBox.Text == string.Empty) // Condicion encargada de validar que el campo descripcion no este vacio
            {
                MyErrorProvider.SetError(DescripcionTextBox, "La descripción no puede estar vacía!");
                DescripcionTextBox.Focus();
                Paso = false;
            }
            else // Validando que la descripcion del producto no este duplicada
            {
                if (ProductoIdNumericUpDown.Value == 0 || Convert.ToString(ProductoIdNumericUpDown.Value) == string.Empty) // Validando que la descripcion no exista, en caso de registrar un producto nuevo
                {
                    if (ProductosBLL.ExisteDescripcion(DescripcionTextBox.Text) == true)
                    {
                        MyErrorProvider.SetError(DescripcionTextBox, "Ya existe un producto con esta descripción, debe ingresar una diferente!");
                        DescripcionTextBox.Focus();
                        Paso = false;
                    }
                }
                else //Valida que si al modificar un producto, la descripcion sea unica
                {
                    RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();
                    var Listado = new List<Productos>();

                    Listado = Repositorio.GetList(p => p.Descripcion.Contains(DescripcionTextBox.Text));

                    if (Listado.Count == 1) // Confirma que solo exista un producto con esa descripcion
                    {
                        Productos ProductoTemporal = new Productos();
                        ProductoTemporal = Listado[0];
                        if (ProductoTemporal.ProductoId != ProductoIdNumericUpDown.Value) // Verifica si el producto que tiene esa descripcion en la base de datos no es al que se esta modificando!
                        {
                            MyErrorProvider.SetError(DescripcionTextBox, "Ya existe un producto con esta descripción, debe ingresar una diferente!");
                            DescripcionTextBox.Focus();
                            Paso = false;
                        }
                    }
                    else if (Listado.Count > 1)
                    {
                        MyErrorProvider.SetError(DescripcionTextBox, "Ya existe un producto con esta descripción, debe ingresar una diferente!");
                        DescripcionTextBox.Focus();
                        Paso = false;
                    }
                }
            }

            if (CategoriaComboBox.SelectedIndex < 0) // Condicion encargada de validar que haya una categoria seleccionada
            {
                MyErrorProvider.SetError(CategoriaComboBox, "Debe seleccionar una categoría!");
                CategoriaComboBox.Focus();
                Paso = false;
            }

            if (CantidadNumericUpDown.Value < 0) // Condicion encargada de validar que la cantidad no sea menor que 0
            {
                MyErrorProvider.SetError(CantidadNumericUpDown, "La cantidad disponible debe no puede ser menor que 0!");
                CantidadNumericUpDown.Focus();
                Paso = false;
            }

            if (PrecioNumericUpDown.Value <= 0) // Condicion encargada de validar que el precio sea mayor a 0
            {
                MyErrorProvider.SetError(PrecioNumericUpDown, "El precio del producto debe ser mayor a 0!");
                PrecioNumericUpDown.Focus();
                Paso = false;
            }
            return Paso;
        }
        private bool ExisteEnLaBaseDeDatos()// Funcnion encargada de verificar si un producto existe en una base de datos!
        {
            RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
            Productos producto = repositorio.Buscar((int)ProductoIdNumericUpDown.Value);
            return (producto != null);
        }

        //Botones -------------------------------------------------------------------------------------------------
        private void Buscarbutton_Click(object sender, EventArgs e)// Clic al boton buscar
        {
            RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();
            Productos Producto = new Productos();

            int.TryParse(ProductoIdNumericUpDown.Text, out int id);

            Producto = Repositorio.Buscar(id);

            if (Producto != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(Producto);
            }
            else
            {
                Limpiar();
                MyErrorProvider.SetError(ProductoIdNumericUpDown, "No existe un producto con este codigo!");
                DescripcionTextBox.Focus();
            }         
        }

        private void LimpiarButton_Click(object sender, EventArgs e)//Clic al boton limpiar
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e) //Clic al boton guardar
        {
            RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();

            Productos Producto = new Productos();

            bool Paso = false;

            if (!Validar())
                return;

            Producto = LlenaClase();

            if (ProductoIdNumericUpDown.Value == 0)
            {
                Paso = Repositorio.Guardar(Producto);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un producto que no existe!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("¿Seguro que desea modificar este producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Paso = Repositorio.Modificar(Producto);
                    if (Paso)
                    {
                        MessageBox.Show("El producto se modificó exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el producto!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                else
                {
                    return;
                }
            }

            if (Paso)
            {
                MessageBox.Show("El producto se guardado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo guardar el producto!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DescripcionTextBox.Focus();
            }

            DescripcionTextBox.Focus();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            /*RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();
            MyErrorProvider.Clear();
            bool Paso = false;
            int.TryParse(ProductoIdNumericUpDown.Text, out int Id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(ProductoIdNumericUpDown, "Este producto no existe!");
                return;
            }
            else
            {
                Productos Producto = Repositorio.Buscar(Convert.ToInt32(ProductoIdNumericUpDown.Value));
                if (Producto != null)
                {
                    var result = MessageBox.Show("¿Seguro que desea eliminar este producto?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Paso = Repositorio.Eliminar(Id);
                        if (Paso)
                        {
                            MessageBox.Show("El producto se elimino exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DescripcionTextBox.Focus();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el producto!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DescripcionTextBox.Focus();
                        }
                        return;
                    }
                }

            }
            DescripcionTextBox.Focus();*/
        }



        private void AnadirCategoriasButton_Click(object sender, EventArgs e)
        {
            rCategorias rcategorias= new rCategorias(NombreUsuario);
            rcategorias.ShowDialog();

        }
        //---------------------------------------------------------------------------------------------------------

        //Moviendo el foco entre los campos del registro ----------------------------------------------------------

        private void ProductoIdNumericUpDown_KeyPress(object sender, KeyPressEventArgs e) // Al precionar enter mueve el culsor del NumericUpDown del codigo del producto al Boton buscar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarButton.Focus();
            }
        }

        private void CategoriaComboBox_DropDownClosed(object sender, EventArgs e)//De la categoria a la cantidad
        {
            CantidadNumericUpDown.Focus();
        }
        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)//Al precionar enter mueve el culsor del TextBox del descripcion al al ComboBox de categoria        {
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                CategoriaComboBox.DroppedDown = true;
                CategoriaComboBox.Focus();
            }
        }

        private void CantidadNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)//De la canidad al precio
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                PrecioNumericUpDown.Focus();
            }
        }

        private void PrecioNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)//Del precio a la fecha de registro
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                FechaDeRegistroDateTimePicker.Focus();
            }
        }

        private void FechaDeRegistroDateTimePicker_ValueChanged(object sender, EventArgs e)// De la fecha de registro al boton guardar(Cuando el valor cambia)
        {
            GuardarButton.Focus();
        }

        private void FechaDeRegistroDateTimePicker_CloseUp(object sender, EventArgs e)//De la fecha de registro al boton guardar(Cuando el seleccionador sube)
        {
            GuardarButton.Focus();
        }


    }
}
