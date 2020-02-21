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
    public partial class rCategoria : Form
    {
        public rCategoria()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private Categorias LlenaClase()
        {
            Categorias categoria = new Categorias();

            categoria.CategoriaId = (int)IdnumericUpDown.Value;
            categoria.Nombre = DescripciontextBox.Text;

            return categoria;
        }

        private void LlenaCampo(Categorias categoria)
        {
            IdnumericUpDown.Value = categoria.CategoriaId;
            DescripciontextBox.Text = categoria.Nombre;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias categoria = repositorio.Buscar((int)IdnumericUpDown.Value);
            return (categoria != null);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias categorias = new Categorias();

            int.TryParse(IdnumericUpDown.Text, out int id);

            categorias = repositorio.Buscar(id);

            if (categorias != null)
            {
                MyErrorProvider.Clear();
                Eliminarbutton.Enabled = true;
                LlenaCampo(categorias);

            }
            else
                MyErrorProvider.SetError(IdnumericUpDown, "Categoría no Encontrado");
        }

        private bool Validar()
        {
            bool paso = true;

            if (DescripciontextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripciontextBox, "Este Campo Esta Vacio");
                paso = false;
            }

            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();

            Categorias categoria = new Categorias();
            bool paso = false;

            if (!Validar())
                return;

            categoria = LlenaClase();

            if (IdnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(categoria);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Categoría que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (repositorio.Duplicado(p => p.Nombre == DescripciontextBox.Text))
                {
                    MyErrorProvider.SetError(DescripciontextBox, "Esta Categoría Ya existe!!!");
                    return;
                }
                paso = repositorio.Modificar(categoria);
            }
            if (paso)
            {
                MessageBox.Show("Categoría Guardada!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No Se Pudo Guardar!!", "Fallo!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            MyErrorProvider.Clear();
            int.TryParse(IdnumericUpDown.Text, out int id);

            if (!ExisteEnLaBaseDeDatos())
            {
                MyErrorProvider.SetError(IdnumericUpDown, "Categoría No Existe!!!");
                return;
            }
            if (repositorio.Eliminar(id))
            {
                Limpiar();
                MessageBox.Show("Categoría Eliminada!!", "Exito!!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
