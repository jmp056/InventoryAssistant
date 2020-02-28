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
   public  class RepositorioEntrada : RepositorioBase<EntradaProductos>
    {
        public override bool Guardar(EntradaProductos entrada)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Entrada.Add(entrada) != null)
                {
                    contexto.Producto.Find(entrada.ProductoId).Cantidad += entrada.Cantidad;

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

        public override bool Modificar(EntradaProductos entrada)
        {
            bool paso = false;

            Contexto contexto = new Contexto();

            RepositorioBase<EntradaProductos> repositorio = new RepositorioBase<EntradaProductos>();

            try
            {
                EntradaProductos EntradaAnterior = repositorio.Buscar(entrada.EntradaId);

                int diferencia;
                diferencia = entrada.Cantidad - EntradaAnterior.Cantidad;

                var Producto = contexto.Producto.Find(EntradaAnterior.ProductoId);

                Producto.Cantidad += diferencia;

                contexto.Entry(entrada).State = EntityState.Modified;

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

        public override bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                EntradaProductos entradaProducto = contexto.Entrada.Find(id);

                if (entradaProducto != null)
                {
                    var Producto = contexto.Producto.Find(entradaProducto.ProductoId);
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
