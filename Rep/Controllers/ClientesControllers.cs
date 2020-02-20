using Microsoft.EntityFrameworkCore;
using Rep.Data;
using Rep.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Rep.Controllers
{
    public class ClientesControllers
    {
        public bool Guardar(Clientes Cliente)
        {
            bool paso = false;
            if (Cliente.ClienteId == 0)
                paso = Insertar(Cliente);
            else
                paso = Modificar(Cliente);

            return paso;
        }

        public static bool Insertar(Clientes Cliente)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            contexto.Clientes.Add(Cliente);
            paso = contexto.SaveChanges() > 0;

            return paso;
        }

        public static bool Modificar(Clientes Cliente)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            contexto.Entry(Cliente).State = EntityState.Modified;
            paso = contexto.SaveChanges() > 0;

            return paso;
        }

        public Clientes Buscar(int Id)
        {
            Contexto contexto = new Contexto();

            Clientes Cliente = contexto.Clientes.Find(Id);

            return Cliente;
        }

        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Clientes Cliente = contexto.Clientes.Find(Id);
            try
            {
                contexto.Entry(Cliente).State = EntityState.Deleted;
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

        public List<Clientes> GetList(Expression<Func<Clientes, bool>> expression)
        {
            List<Clientes> ListadoClientes = new List<Clientes>();
            Contexto contexto = new Contexto();

            ListadoClientes = contexto.Clientes.Where(expression).ToList();

            return ListadoClientes;
        }
    }
}
