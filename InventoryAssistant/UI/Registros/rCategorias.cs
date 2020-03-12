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
    public partial class rCategorias : Form
    {
        public rCategorias()
        {
            InitializeComponent();
            Limpiar();
        }

        public void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            CategoriaIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
            NombreTextBox.Focus();
        }

        private Categorias LlenaClase()  // Funcion encargada de llenar el objeto
        {
            Categorias Categoria = new Categorias();

            Categoria.CategoriaId = (int)CategoriaIdNumericUpDown.Value;
            Categoria.Nombre = NombreTextBox.Text.ToUpper();

            return Categoria;
        }

        private void LlenaCampo(Categorias Categoria)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
        {
            CategoriaIdNumericUpDown.Value = Categoria.CategoriaId;
            NombreTextBox.Text = Categoria.Nombre;
        }

        private bool Validar() //Funcion que valida todo el registro
        {
            bool Paso = true;
            MyErrorProvider.Clear();

            if (NombreTextBox.Text == string.Empty) // Condicion encargada de validar que el campo nombre no este vacio
            {
                MyErrorProvider.SetError(NombreTextBox, "El nombre no puede estar vacío!");
                NombreTextBox.Focus();
                Paso = false;
            }
            else //Valida que si al modificar una categoria, el nombre de categoria sea unico
            {
                RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();
                var Listado = new List<Categorias>();

                Listado = Repositorio.GetList(p => p.Nombre.Contains(NombreTextBox.Text));

                if (Listado.Count == 1) // Confirma que solo exista una categoria con ese nombre
                {
                    Categorias CategoriaTemporal = new Categorias();
                    CategoriaTemporal = Listado[0];
                    if (CategoriaTemporal.CategoriaId != CategoriaIdNumericUpDown.Value) // Verifica si la categoria que tiene ese nombre en la base de datos no es al que se esta modificando!
                    {
                        MyErrorProvider.SetError(NombreTextBox, "Ya este tipo de categoría existe!");
                        NombreTextBox.Focus();
                        Paso = false;
                    }
                }
                else if (Listado.Count > 1)
                {
                    MyErrorProvider.SetError(NombreTextBox, "Ya este tipo de categoría existe!");
                    NombreTextBox.Focus();
                    Paso = false;
                }
            }

            return Paso;
        }

        private bool ExisteEnLaBaseDeDatos() // Funcnion encargada de verificar si un usuario exist en una base de datos!
        {
            RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();
            Categorias Categoria = Repositorio.Buscar((int)CategoriaIdNumericUpDown.Value);
            return (Categoria != null);
        }

        //Botones -------------------------------------------------------------------------------------------------
        private void Buscarbutton_Click(object sender, EventArgs e)// Clic al boton buscar
        {
            RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();
            Categorias Categoria = new Categorias();

            int.TryParse(CategoriaIdNumericUpDown.Text, out int id);

            Categoria = Repositorio.Buscar(id);

            if (Categoria != null)
            {
                MyErrorProvider.Clear();
                LlenaCampo(Categoria);
            }
            else
            {
                Limpiar();
                MyErrorProvider.SetError(CategoriaIdNumericUpDown, "No existe una categoria con este codigo!");
                NombreTextBox.Focus();
            }
               
        }
        
        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        private void GuardarButton_Click(object sender, EventArgs e) //Clic al boton guardar
        {
            RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();

            Categorias Categoria = new Categorias();

            bool Paso = false;

            if (!Validar())
                return;

            Categoria = LlenaClase();

            if (CategoriaIdNumericUpDown.Value == 0)
            {
                Paso = Repositorio.Guardar(Categoria);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una categoría que no existe!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("¿Seguro que desea modificar la categoría " + Categoria.Nombre + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    Paso = Repositorio.Modificar(Categoria);
                    if (Paso)
                    {
                        MessageBox.Show("La categoría se modificó exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar la categoría!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("La categoria se guardado exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo Guardar la categoría!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NombreTextBox.Focus();
            }

            NombreTextBox.Focus();
        }

        private void EliminarButton_Click(object sender, EventArgs e)//Clic al boton eliminar
        {
            RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();
            MyErrorProvider.Clear();
            bool Paso = false;
            int.TryParse(CategoriaIdNumericUpDown.Text, out int Id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(CategoriaIdNumericUpDown, "Esta categoría no existe!");
                return;
            }
            else
            {
                Categorias Categoria = Repositorio.Buscar(Convert.ToInt32(CategoriaIdNumericUpDown.Value));
                if (Categoria != null)
                {
                    var result = MessageBox.Show("¿Seguro que desea eliminar la categoría " + Categoria.Nombre + "?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        Paso = Repositorio.Eliminar(Id);
                        if (Paso)
                        {
                            MessageBox.Show("La categoría se elimino exitosamente!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            NombreTextBox.Focus();
                            Limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la categoría!", "Fallo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            NombreTextBox.Focus();
                        }
                        return;
                    }
                }

            }
            NombreTextBox.Focus();
        }
        //---------------------------------------------------------------------------------------------------------

        //Moviendo el foco entre los campos del registro ----------------------------------------------------------
        private void CategoriaIdNumericUpDown_KeyPress(object sender, KeyPressEventArgs e) // Al precionar enter mueve el culsor del NumericUpDown del codigo de la categoria al Boton buscar
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                BuscarButton.Focus();
            }
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)//Al precionar enter mueve el culsor del TextBox del nombre al Boton guardar                                                                             
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                GuardarButton.Focus();
            }
        }
        //Moviendo el foco entre los campos del registro ----------------------------------------------------------
    }
}
