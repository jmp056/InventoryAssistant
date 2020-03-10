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
    public class FacturasBLL
    {

        public static bool Guardar(Facturas Factura)
        {

            bool Paso = false;
            Contexto contexto = new Contexto();

            try
            {

                if (contexto.Facturas.Add(Factura) != null)
                {

                    foreach (var item in Factura.Detalle)
                    {

                        contexto.Productos.Find(item.ProductoId).Cantidad -= item.Cantidad;
                    }
                }
                Paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                contexto.Dispose();
            }

            return Paso;
        }


        public static bool Modificar(Facturas Factura)
        {

            bool Paso = false;
            Contexto contexto = new Contexto();
            RepositorioBase<Facturas> Repositorio = new RepositorioBase<Facturas>();

            try
            {

                Facturas Anterior = Buscar(Factura.FacturaId);
                foreach (var item in Anterior.Detalle)
                {

                    if (!Factura.Detalle.Any(d => d.DetalleFacturaId == item.DetalleFacturaId))
                    {

                        contexto.Productos.Find(item.ProductoId).Cantidad += item.Cantidad;
                        contexto.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in Factura.Detalle)
                {

                    if (item.DetalleFacturaId == 0)
                    {

                        contexto.Productos.Find(item.ProductoId).Cantidad -= item.Cantidad;
                        contexto.Entry(item).State = EntityState.Added;
                    }
                    else
                    {

                        contexto.Entry(item).State = EntityState.Modified;
                    }
                }
                contexto.Entry(Factura).State = EntityState.Modified;
                Paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                contexto.Dispose();
            }

            return Paso;
        }


        public static bool Eliminar(int Id)
        {

            bool Paso = false;
            Contexto contexto = new Contexto();

            try
            {

                Facturas Factura = contexto.Facturas.Find(Id);
                foreach (var item in Factura.Detalle)
                {

                    var EliminInventario = contexto.Productos.Find(item.ProductoId);
                    EliminInventario.Cantidad += item.Cantidad;
                }

                contexto.Facturas.Remove(Factura);
                Paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                contexto.Dispose();
            }

            return Paso;
        }

        public static Facturas Buscar(int id)
        {

            Contexto contexto = new Contexto();
            Facturas Factura = new Facturas();
            try
            {

                Factura = contexto.Facturas.Find(id);
                if (Factura!= null)
                    Factura.Detalle.Count();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                contexto.Dispose();
            }

            return Factura;
        }
    }
}
