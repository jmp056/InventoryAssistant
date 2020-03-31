using InventoryAssistant.BLL;
using InventoryAssistant.DAL;
using InventoryAssistant.Entidades;
using InventoryAssistant.UI.Consultas;
using System;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Registros
{
    public partial class rEntradaProductos : Form
    {
        private Productos Producto = new Productos();
        string NombreUsuario;
        int EntradaProductoId;
        int ProductoId;

        public rEntradaProductos(string nombreUsuario, int entradaProductoId, int productoId)
        {
            this.NombreUsuario = nombreUsuario;
            this.EntradaProductoId = entradaProductoId;
            this.ProductoId = productoId;
            InitializeComponent();
            Limpiar();
            Producto = new Productos();
        }

        public void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            EntradaIdNumericUpDown.Value = 0;
            ProductoTextBox.Text = string.Empty;
            CantidadNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            EntradaIdNumericUpDown.Focus();
            MyErrorProvider.Clear();

            EstadoToolStripStatusLabel.Text = string.Empty;
            UsuarioToolStripStatusLabel.Text = string.Empty;
        }

        private EntradaProductos LlenaClase()  // Funcion encargada de llenar el objeto
        {
            EntradaProductos entradaProductos = new EntradaProductos();

            entradaProductos.EntradaProductoId = (int)EntradaIdNumericUpDown.Value;
            entradaProductos.ProductoId = (int)Producto.ProductoId;
            entradaProductos.Cantidad = (int)CantidadNumericUpDown.Value;
            entradaProductos.Fecha = FechaDateTimePicker.Value;

            entradaProductos.Estado = (entradaProductos.EntradaProductoId == 0) ? false : true;
            entradaProductos.UsuarioR = NombreUsuario;

            return entradaProductos;
        }

        private void LlenaCampo(EntradaProductos entradaProductos)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
        {
            Producto = BuscaProducto(entradaProductos.ProductoId);

            EntradaIdNumericUpDown.Value = entradaProductos.EntradaProductoId;
            ProductoTextBox.Text = Producto.Descripcion;
            CantidadNumericUpDown.Value = entradaProductos.Cantidad;
            FechaDateTimePicker.Value = entradaProductos.Fecha;

            EstadoToolStripStatusLabel.Text = (entradaProductos.Estado == false) ? "Agregado por: " : "Modificado por: ";
            UsuarioToolStripStatusLabel.Text = entradaProductos.UsuarioR;
        }

        private bool Validar() //Funcion que valida todo el registro
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if(ProductoTextBox.Text == string.Empty)//Valida que haya un producto seleccionado
            {
                MyErrorProvider.SetError(ProductoTextBox, "Debe seleccionar un producto!");
                ProductoTextBox.Focus();
                paso = false;
            }

            if(EntradaIdNumericUpDown.Value > 0)//Valida que si se modifica una entrada el producto sea el mismo!
            {
                if (!ValidarProducto())
                {
                    MyErrorProvider.SetError(ProductoTextBox, "El producto de la entrada no puede variar!");
                    VerProductosButton.Focus();
                    paso = false;
                }
            }


            if (CantidadNumericUpDown.Value == 0)//Valida que la cantidad de entrada sea mayor a 0
            {
                MyErrorProvider.SetError(CantidadNumericUpDown, "La cantidad de la entrada debe ser mayor a 0!");
                CantidadNumericUpDown.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ValidarProducto()//Funcion que valida que si se modifica una entrada, el producto sea el mismo
        {
            bool Paso = true;

            EntradaProductos entradaProductos = BuscaEntrada((int)EntradaIdNumericUpDown.Value);
            Productos ProductoTemporal = BuscaProducto(entradaProductos.ProductoId);
            if(ProductoTemporal.Descripcion != ProductoTextBox.Text)
            {
                Paso = false;
            }

            return Paso;
        }


        private bool ExisteEnLaBaseDeDatos() // Funcnion encargada de verificar si un usuario existe en una base de datos!
        {
            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();
            EntradaProductos entradaProductos = repositorio.Buscar((int)EntradaIdNumericUpDown.Value);
            return (entradaProductos != null);
        }

        //Botones -------------------------------------------------------------------------------------------------
        private void BuscarButton_Click(object sender, EventArgs e)//Clic al boton buscar
        {
            Buscar();
        }

        private void Buscar()
        {
            EntradaProductos entradaProductos = BuscaEntrada((int)EntradaIdNumericUpDown.Value);

            if (entradaProductos != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(entradaProductos);
            }
            else
                MyErrorProvider.SetError(EntradaIdNumericUpDown, "No existe una entrada con este codigo!");
        }

        private void LimpiarButton_Click(object sender, EventArgs e)//Clic al boton limpiar
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)//Clic al boton guardar
        {
            EntradaProductos entradaProductos = new EntradaProductos();

            bool paso = false;

            if (!Validar())
                return;

            entradaProductos = LlenaClase();

            if (EntradaIdNumericUpDown.Value == 0)
            {
                paso = EntradaProductosBLL.Guardar(entradaProductos);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una entrada que no existe!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("¿Seguro que desea modificar esta entrada?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    paso = EntradaProductosBLL.Modificar(entradaProductos);
                    if (paso)
                    {
                        MessageBox.Show("La entrada se modificó de manera exitosa!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la entrada!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
                else
                {
                    return;
                }
            }

            if (paso)
            {
                MessageBox.Show("La entrada se guardado de manera exitosa!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo guardar la entrada!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            EntradaIdNumericUpDown.Focus();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            /*RepositorioBase<EntradaProductos> Repositorio = new RepositorioBase<EntradaProductos>();
            MyErrorProvider.Clear();
            bool paso = false;
            int.TryParse(EntradaIdNumericUpDown.Text, out int Id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(EntradaIdNumericUpDown, "Esta entrada no existe!");
                return;
            }
            else
            {
                EntradaProductos entradaProductos = Repositorio.Buscar(Convert.ToInt32(EntradaIdNumericUpDown.Value));
                if (entradaProductos != null)
                {
                    var result = MessageBox.Show("¿Seguro que desea eliminar esta entrada?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        paso = EntradaProductosBLL.Eliminar(Id);
                        if (paso)
                        {
                            MessageBox.Show("La entrada se elimino de manera exitosa!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            EntradaIdNumericUpDown.Focus();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("La entrada no pudo ser eliminada!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            EntradaIdNumericUpDown.Focus();
                        }
                        return;
                    }
                }

            }
            EntradaIdNumericUpDown.Focus();*/
        }

        private void VerProductosButton_Click(object sender, EventArgs e)
        {
            SeleccionProducto TraeProducto = new SeleccionProducto();
            if (TraeProducto.ShowDialog() == DialogResult.OK)
            {

                Producto = BuscaProducto(TraeProducto.IdProductoSeleccionado);
                ProductoTextBox.Text = Producto.Descripcion;
                CantidadNumericUpDown.Focus();
            }
        }
        private Productos BuscaProducto(int Id) // Funcion encargada de buscar el producto
        {
            RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();
            Productos Producto = Repositorio.Buscar(Id);

            return Producto;
        }

        private EntradaProductos BuscaEntrada(int Id)
        {
            RepositorioBase<EntradaProductos> Repositorio = new RepositorioBase<EntradaProductos>();
            EntradaProductos entradaProductos = Repositorio.Buscar(Id);

            return entradaProductos;
        }

        private void rEntradaProductos_Load(object sender, EventArgs e)
        {
            if(EntradaProductoId > 0)
            {
                EntradaIdNumericUpDown.Value = EntradaProductoId;
                Buscar();
            }
            else if (ProductoId > 0)
            {
                Producto = BuscaProducto(ProductoId);
                ProductoTextBox.Text = Producto.Descripcion;
                CantidadNumericUpDown.Focus();
            }
        }
    }
}
