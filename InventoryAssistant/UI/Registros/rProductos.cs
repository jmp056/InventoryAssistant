using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Registros
{
    public partial class rProductos : Form
    {
        string NombreUsuario;
        int Nivel;
        int ProductoId;

        public rProductos(string nombreUsuario, int nivel, int productoId)
        {
            try
            {
                this.NombreUsuario = nombreUsuario;
                this.Nivel = nivel;
                this.ProductoId = productoId;
                InitializeComponent();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rProductos_Activated(object sender, EventArgs e) // Llena el ComboBox de las categorias cuando la ventana gana el foco
        {
            try
            {
                if (ProductoId <= 0)
                {
                    LlenaComboBoxCategorias();
                    CategoriaComboBox.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void rProductos_Load(object sender, EventArgs e) // Al cargar el Form
        {
            try
            {
                FechaDeRegistroDateTimePicker.Value = DateTime.Now;
            
                LlenaComboBoxCategorias();

                if (ProductoId > 0)
                {
                    ProductoIdNumericUpDown.Value = ProductoId;
                    Buscar();
                }

                MyToolTip.SetToolTip(AnadirCategoriasButton, "Agregar una nueva categoría");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()// Funcion encargada de limpiar todos los campos del registro
        {
            try
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
                ProductoIdNumericUpDown.Enabled = true;
                BuscarButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Productos LlenaClase()// Funcion encargada de llenar el objeto
        {
            Productos Producto = new Productos();

            try
            {
                Producto.ProductoId = (int)ProductoIdNumericUpDown.Value;
                Producto.Descripcion = DescripcionTextBox.Text.ToUpper();
                Producto.CategoriaId = Convert.ToInt32(CategoriaComboBox.SelectedValue);
                Producto.ControlAlmacen = ControlAlmacenCheckBox.Checked;
                Producto.Cantidad = Convert.ToInt32(CantidadNumericUpDown.Value);
                Producto.Precio = Convert.ToInt32(PrecioNumericUpDown.Value);
                Producto.FechaDeRegistro = FechaDeRegistroDateTimePicker.Value;

                Producto.Estado = (Producto.ProductoId == 0) ? false : true;
                Producto.UsuarioR = NombreUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Producto;
        }

        private void LlenaCampo(Productos Producto)// Funcion encargada de llenar los campos del registro con los datos de un objeto
        {
            try
            {
                ProductoIdNumericUpDown.Value = Producto.ProductoId;
                DescripcionTextBox.Text = Producto.Descripcion;
                CategoriaComboBox.SelectedValue = Producto.CategoriaId;
                ControlAlmacenCheckBox.Checked = Producto.ControlAlmacen;
                CantidadNumericUpDown.Value= Producto.Cantidad;
                PrecioNumericUpDown.Value = Convert.ToDecimal(Producto.Precio);
                FechaDeRegistroDateTimePicker.Value = Producto.FechaDeRegistro;

                EstadoToolStripStatusLabel.Text = (Producto.Estado == false) ? "Agregado por: " : "Modificado por: ";
                UsuarioToolStripStatusLabel.Text = Producto.UsuarioR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LlenaComboBoxCategorias() // Funcion encargada de llenar el ComboBox de las categorias
        {
            try
            {
                RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();
                var categorias = new List<Categorias>();
                categorias = Repositorio.GetList(p => true);
                CategoriaComboBox.DataSource = categorias;
                CategoriaComboBox.ValueMember = "CategoriaId";
                CategoriaComboBox.DisplayMember = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()//Funcion que valida todo el registro
        {
            bool Paso = true;
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Paso;
        }

        private bool ExisteEnLaBaseDeDatos()// Funcnion encargada de verificar si un producto existe en una base de datos!
        {
            Productos producto = new Productos();

            try
            {
                RepositorioBase<Productos> repositorio = new RepositorioBase<Productos>();
                producto = repositorio.Buscar((int)ProductoIdNumericUpDown.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (producto != null);
        }
        
        private void Buscar() // Funcion encargada de realizar la busqueda
        {
            try
            {
                RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();
                Productos Producto = new Productos();

                int.TryParse(ProductoIdNumericUpDown.Text, out int id);

                Producto = Repositorio.Buscar(id);

                if (Producto != null)
                {
                    MyErrorProvider.Clear();
                    LlenaCampo(Producto);
                    ProductoIdNumericUpDown.Enabled = false;
                    BuscarButton.Enabled = false;
                }
                else
                {
                    Limpiar();
                    MyErrorProvider.SetError(ProductoIdNumericUpDown, "No existe un producto con este codigo!");
                    DescripcionTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //Botones -------------------------------------------------------------------------------------------------
        private void Buscarbutton_Click(object sender, EventArgs e)// Clic al boton buscar
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

        private void LimpiarButton_Click(object sender, EventArgs e)// Clic al boton limpiar
        {
            try
            {
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarButton_Click(object sender, EventArgs e) // Clic al boton guardar
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e) // Clic al boton Eliminar
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnadirCategoriasButton_Click(object sender, EventArgs e) // Clic al boton agregar categoria
        {
            try
            {
                rCategorias rcategorias= new rCategorias(NombreUsuario, 0);
                rcategorias.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //---------------------------------------------------------------------------------------------------------

        //Moviendo el foco entre los campos del registro ----------------------------------------------------------
        private void ProductoIdNumericUpDown_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el NumericUpDown del codigo
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    BuscarButton.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BuscarButton_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el boton buscar
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        ProductoIdNumericUpDown.Focus();
                        break;

                    case Keys.Left:
                        ProductoIdNumericUpDown.Focus();
                        break;

                    case Keys.Right:
                        DescripcionTextBox.Focus();
                        break;

                    case Keys.Down:
                        DescripcionTextBox.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DescripcionTextBox_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el Textbox de la descripcion
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        BuscarButton.Focus();
                        break;

                    case Keys.Left:
                        BuscarButton.Focus();
                        break;

                    case Keys.Right:
                        CategoriaComboBox.Focus();
                        break;

                    case Keys.Down:
                        CategoriaComboBox.Focus();
                        break;

                    case Keys.Enter:
                        CategoriaComboBox.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CategoriaComboBox_Enter(object sender, EventArgs e) // Si el combobox de la categoria gana el foco
        {
            try
            {
                CategoriaComboBox.DroppedDown = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CategoriaComboBox_DropDownClosed(object sender, EventArgs e) // Si el combobox de la categoria se cierra
        {
            try
            {
                CantidadNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ControlAlmacenCheckBox_CheckedChanged(object sender, EventArgs e) // Si cambia el estado del CheckBox de llevar el control en el almacen
        {
            try
            {
                CantidadNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CantidadNumericUpDown_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el NumericUpDown de la cantidad
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    PrecioNumericUpDown.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrecioNumericUpDown_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el NumericUpDown del precio
        {

            try
            {
                if (e.KeyCode == Keys.Enter)
                    FechaDeRegistroDateTimePicker.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FechaDeRegistroDateTimePicker_CloseUp(object sender, EventArgs e) // Si se cierra el DateTimePicker de la fecha
        {
            try
            {
                GuardarButton.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FechaDeRegistroDateTimePicker_KeyDown(object sender, KeyEventArgs e) // Al pulsar enter en el DateTimePicker de la fecha
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    GuardarButton.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarButton_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el boton de Guardar
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        FechaDeRegistroDateTimePicker.Focus();
                        break;

                    case Keys.Down:
                        EliminarButton.Focus();
                        break;

                    case Keys.Left:
                        LimpiarButton.Focus();
                        break;

                    case Keys.Right:
                        EliminarButton.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarButton_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el boton de Limpiar
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        FechaDeRegistroDateTimePicker.Focus();
                        break;

                    case Keys.Down:
                        GuardarButton.Focus();
                        break;

                    case Keys.Left:
                        EliminarButton.Focus();
                        break;

                    case Keys.Right:
                        GuardarButton.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_KeyDown(object sender, KeyEventArgs e) // Al pulsar una tecla en el boton de Eliminar
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        FechaDeRegistroDateTimePicker.Focus();
                        break;

                    case Keys.Down:
                        LimpiarButton.Focus();
                        break;

                    case Keys.Left:
                        GuardarButton.Focus();
                        break;

                    case Keys.Right:
                        LimpiarButton.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
