using InventoryAssistant.DAL;
using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.BLL
{
   public  class EntradaProductosBLL
    {
        public static bool Guardar(EntradaProductos entradaProducto)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.EntradaProductos.Add(entradaProducto) != null)
                {
                    contexto.Productos.Find(entradaProducto.ProductoId).Cantidad += entradaProducto.Cantidad;

                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(EntradaProductos entradaProductos)
        {
            bool paso = false;

            Contexto contexto = new Contexto();

            RepositorioBase<Entidades.EntradaProductos> repositorio = new RepositorioBase<Entidades.EntradaProductos>();

            try
            {
                Entidades.EntradaProductos entradaProductosAnterior = repositorio.Buscar(entradaProductos.EntradaProductoId);

                int diferencia;
                diferencia = entradaProductos.Cantidad - entradaProductosAnterior.Cantidad;

                var Producto = contexto.Productos.Find(entradaProductosAnterior.ProductoId);

                Producto.Cantidad += diferencia;

                contexto.Entry(entradaProductos).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Entidades.EntradaProductos entradaProducto = contexto.EntradaProductos.Find(id);

                if (entradaProducto != null)
                {
                    var Producto = contexto.Productos.Find(entradaProducto.ProductoId);
                    //Reduce la cantidad
                    Producto.Cantidad -= entradaProducto.Cantidad;

                    contexto.Entry(entradaProducto).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
    }
}
