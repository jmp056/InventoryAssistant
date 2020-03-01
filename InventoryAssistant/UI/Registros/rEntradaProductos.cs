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
    {
        public rEntradaProductos()
        {
            InitializeComponent();
            LlenaComboBoxProductos();
            Limpiar();
        }

        public void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            EntradaIdNumericUpDown.Value = 0;
            ProductoComboBox.SelectedIndex = -1;
            CantidadNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            EntradaIdNumericUpDown.Focus();
        }

        public void LlenaComboBoxProductos() // Funcion encargada de llenar el ComboBox de los productos
        {
            RepositorioBase<Productos> Repositorio = new RepositorioBase<Productos>();
            var productos = new List<Productos>();
            productos = Repositorio.GetList(p => true);
            ProductoComboBox.DataSource = productos;
            ProductoComboBox.ValueMember = "ProductoId";
            ProductoComboBox.DisplayMember = "Descripcion";
        }

        private EntradaProductos LlenaClase()  // Funcion encargada de llenar el objeto
        {
            EntradaProductos entradaProductos = new EntradaProductos();

            entradaProductos.EntradaProductoId = (int)EntradaIdNumericUpDown.Value;
            entradaProductos.ProductoId = Convert.ToInt32(ProductoComboBox.SelectedValue);
            entradaProductos.Cantidad = (int)CantidadNumericUpDown.Value;
            entradaProductos.Fecha = FechaDateTimePicker.Value;

            return entradaProductos;
        }

        private void LlenaCampo(EntradaProductos entradaProductos)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
        {
            EntradaIdNumericUpDown.Value = entradaProductos.EntradaProductoId;
            ProductoComboBox.SelectedValue = entradaProductos.ProductoId;
            CantidadNumericUpDown.Value = entradaProductos.Cantidad;
            FechaDateTimePicker.Value = entradaProductos.Fecha;
        }

        private bool Validar() //Funcion que valida todo el registro
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if(ProductoComboBox.SelectedIndex < 0)//Valida que haya un producto seleccionado
            {
                MyErrorProvider.SetError(ProductoComboBox, "Debe seleccionar un producto!");
                ProductoComboBox.Focus();
                paso = false;
            }

            if (CantidadNumericUpDown.Value == 0)//Valida que la cantidad de entrada sea mayor a 0
            {
                MyErrorProvider.SetError(CantidadNumericUpDown, "La cantidad de la entrada debe ser mayor a 0!");
                CantidadNumericUpDown.Focus();
                paso = false;
            }

            return paso;
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
            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();
            EntradaProductos entradaProductos = new EntradaProductos();

            int.TryParse(EntradaIdNumericUpDown.Text, out int id);

            entradaProductos = repositorio.Buscar(id);

            if (entradaProductos != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(entradaProductos);
            }
            else
                MyErrorProvider.SetError(EntradaIdNumericUpDown, "No existe una entrada con este codigo!");
            ProductoComboBox.DroppedDown = true;
            ProductoComboBox.Focus();
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
            RepositorioBase<EntradaProductos> Repositorio = new RepositorioBase<EntradaProductos>();
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
            EntradaIdNumericUpDown.Focus();
        }
    }
}
