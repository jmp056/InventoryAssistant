using InventoryAssistant.DAL;
using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.BLL
{
    public class RepositorioBase<T> : IDisposable, IRepository<T> where T : class
    {
        public virtual bool Guardar(T entity)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                if (contexto.Set<T>().Add(entity) != null)
                    paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public virtual bool Modificar(T entity)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Entry(entity).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public virtual bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                T entity = contexto.Set<T>().Find(id);
                contexto.Set<T>().Remove(entity);

                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public virtual T Buscar(int id)
        {
            Contexto contexto = new Contexto();
            T entity;

            try
            {
                entity = contexto.Set<T>().Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return entity;
        }


        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<T> Lista = new List<T>();

            try
            {
                Lista = contexto.Set<T>().Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return Lista;
        }

        public virtual bool Duplicado(Expression<Func<T, bool>> descripcion)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                paso = contexto.Set<T>().Any(descripcion);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        
        private static Usuarios usuario = new Usuarios();

        public virtual void NombreLogin(string Usuario, int NivelDeUsuario)
        {
             usuario.Usuario = Usuario;
             usuario.NivelDeUsuario = NivelDeUsuario;

        }
        public virtual Usuarios ReturnUsuario()
        {
           return usuario;
        }
    }
}
