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

        internal Contexto contexto;

        public RepositorioBase()
        {
            contexto = new Contexto();
        }

        public virtual bool Guardar(T entity)
        {
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
                Dispose();
            }
            return paso;
        }

        public virtual bool Modificar(T entity)
        {
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
                Dispose();
            }
            return paso;
        }

        public virtual bool Eliminar(int id)
        {
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
                Dispose();
            }
            return paso;
        }

        public virtual T Buscar(int id)
        {
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
                Dispose();
            }
            return entity;
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
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
                Dispose();
            }
            return Lista;
        }

        public virtual bool Duplicado(Expression<Func<T, bool>> descripcion)
        {
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
            contexto.Dispose();
        }




    /*
        private static Usuarios usuario = new Usuarios();

        public virtual void NombreLogin(string Usuario, string tipodeusuario)
        {
            usuario.Usuario = Usuario;
            usuario.NivelUsuario = tipodeusuario;

        }
        public virtual Usuarios ReturnUsuario()
        {
            return usuario;
        }*/
    }
}
