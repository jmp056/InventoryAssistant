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

        internal Contexto _contexto;

        public RepositorioBase()
        {
            _contexto = new Contexto();
        }

        public virtual bool Guardar(T entity)
        {
            bool paso = false;

            try
            {
                if (_contexto.Set<T>().Add(entity) != null)
                    paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual bool Modificar(T entity)
        {
            bool paso = false;

            try
            {
                _contexto.Entry(entity).State = EntityState.Modified;
                paso = (_contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);

                paso = _contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public virtual T Buscar(int id)
        {
            T entity;

            try
            {
                entity = _contexto.Set<T>().Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> Lista = new List<T>();

            try
            {
                Lista = _contexto.Set<T>().Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }

        public virtual bool Duplicado(Expression<Func<T, bool>> descripcion)
        {
            bool paso = false;

            try
            {
                paso = _contexto.Set<T>().Any(descripcion);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _contexto.Dispose();
            }

            return paso;
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
