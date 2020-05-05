using InventoryAssistant.BLL;
using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InventoryAssistant.UI.Registros
{
    public partial class rCategorias : Form
    {
        string NombreUsuario;
        int CategoriaId;

        public rCategorias(string nombreUsuario, int categoriaId)
        {
            try
            {
                this.NombreUsuario = nombreUsuario;
                this.CategoriaId = categoriaId;
                InitializeComponent();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Limpiar() // Funcion encargada de limpiar todos los campos del registro
        {
            try
            {
                CategoriaIdNumericUpDown.Value = 0;
                NombreTextBox.Text = string.Empty;
                MyErrorProvider.Clear();
                NombreTextBox.Focus();

                EstadoToolStripStatusLabel.Text = string.Empty;
                UsuarioToolStripStatusLabel.Text = string.Empty;
                CategoriaIdNumericUpDown.Enabled = true;
                BuscarButton.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Categorias LlenaClase()  // Funcion encargada de llenar el objeto
        {
            Categorias Categoria = new Categorias();

            try
            {
                Categoria.CategoriaId = (int)CategoriaIdNumericUpDown.Value;
                Categoria.Nombre = NombreTextBox.Text;

                Categoria.Estado = (Categoria.CategoriaId == 0) ? false : true;
                Categoria.UsuarioR = NombreUsuario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Categoria;

        }

        private void LlenaCampo(Categorias Categoria)  // Funcion encargada de llenar los campos del registro con los datos de un objeto
        {
            try
            {
                CategoriaIdNumericUpDown.Value = Categoria.CategoriaId;
                NombreTextBox.Text = Categoria.Nombre;

                EstadoToolStripStatusLabel.Text = (Categoria.Estado == false) ? "Agregado por: " : "Modificado por: ";
                UsuarioToolStripStatusLabel.Text = Categoria.UsuarioR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar() //Funcion que valida todo el registro
        {
            bool Paso = true;

            try
            {
                MyErrorProvider.Clear();

                if (NombreTextBox.Text == string.Empty) // Condicion encargada de validar que el campo nombre no este vacio
                {
                    MyErrorProvider.SetError(NombreTextBox, "El nombre no puede estar vacío!");
                    NombreTextBox.Focus();
                    Paso = false;
                }
                else if(NombreTextBox.Text.Length > 50)
                {
                    MyErrorProvider.SetError(NombreTextBox, "El nombre de la categoría es demasiado largo!");
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
                            MyErrorProvider.SetError(NombreTextBox, "Ya existe una categoría con este nombre!");
                            NombreTextBox.Focus();
                            Paso = false;
                        }
                    }
                    else if (Listado.Count > 1)
                    {
                        MyErrorProvider.SetError(NombreTextBox, "Ya existe una categoría con este nombre!");
                        NombreTextBox.Focus();
                        Paso = false;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return Paso;
        }

        private bool ExisteEnLaBaseDeDatos() // Funcnion encargada de verificar si un usuario exist en una base de datos!
        {
            Categorias Categoria = new Categorias();

            try
            {
                RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();
                Categoria = Repositorio.Buscar((int)CategoriaIdNumericUpDown.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (Categoria != null);
        }

        private void Buscar() // Funcion encargada de realizar la busqueda
        {
            try
            {
                RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();
                Categorias Categoria = new Categorias();

                int.TryParse(CategoriaIdNumericUpDown.Text, out int id);

                Categoria = Repositorio.Buscar(id);

                if (Categoria != null)
                {
                    MyErrorProvider.Clear();
                    LlenaCampo(Categoria);
                    CategoriaIdNumericUpDown.Enabled = false;
                    BuscarButton.Enabled = false;
                }
                else
                {
                    Limpiar();
                    MyErrorProvider.SetError(CategoriaIdNumericUpDown, "No existe una categoria con este codigo!");
                    NombreTextBox.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }  
        
        private void rCategorias_Load(object sender, EventArgs e) // Al cargar el form
        {
            try
            {
                if (CategoriaId > 0)
                {
                    CategoriaIdNumericUpDown.Value = CategoriaId;
                    Buscar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //Botones -------------------------------------------------------------------------------------------------
        private void Buscarbutton_Click(object sender, EventArgs e) // Clic al boton buscar
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

        private void LimpiarButton_Click(object sender, EventArgs e) // Clic al boton limpiar
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)//Clic al boton eliminar
        {
            try
            {
                /*RepositorioBase<Categorias> Repositorio = new RepositorioBase<Categorias>();
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
                NombreTextBox.Focus();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //---------------------------------------------------------------------------------------------------------

        //Moviendo el foco entre los campos del registro ----------------------------------------------------------
        private void CategoriaIdNumericUpDown_KeyDown(object sender, KeyEventArgs e) // Al presionar una tecla en el NumericUpDown del id
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

        private void BuscarButton_KeyDown(object sender, KeyEventArgs e) // Al precionar una tecla en el boton buscar
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        CategoriaIdNumericUpDown.Focus();
                        break;

                    case Keys.Left:
                        CategoriaIdNumericUpDown.Focus();
                        break;

                    case Keys.Right:
                        NombreTextBox.Focus();
                        break;

                    case Keys.Down:
                        NombreTextBox.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NombreTextBox_KeyDown(object sender, KeyEventArgs e) // Al precionar una tecla en el Textbox del nombre
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        BuscarButton.Focus();
                        break;

                    case Keys.Down:
                        GuardarButton.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarButton_KeyDown(object sender, KeyEventArgs e) // Al presionar una tecla en el boton Limpiar
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        NombreTextBox.Focus();
                        break;

                    case Keys.Left:
                        EliminarButton.Focus();
                        break;

                    case Keys.Right:
                        GuardarButton.Focus();
                        break;

                    case Keys.Down:
                        GuardarButton.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarButton_KeyDown(object sender, KeyEventArgs e) // Al presionar una tecla en el boton guardar
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        NombreTextBox.Focus();
                        break;

                    case Keys.Left:
                        LimpiarButton.Focus();
                        break;

                    case Keys.Right:
                        EliminarButton.Focus();
                        break;

                    case Keys.Down:
                        EliminarButton.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, contacte soporte e infórmele sobre este problema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_KeyDown(object sender, KeyEventArgs e) // Al presionar una tecla en el boton guardar 
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        NombreTextBox.Focus();
                        break;

                    case Keys.Left:
                        GuardarButton.Focus();
                        break;

                    case Keys.Right:
                        LimpiarButton.Focus();
                        break;

                    case Keys.Down:
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
