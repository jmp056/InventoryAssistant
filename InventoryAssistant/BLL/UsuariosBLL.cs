using InventoryAssistant.DAL;
using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.BLL
{
    public class UsuariosBLL
    {
        public static bool ExisteCedula(string cedula)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Usuarios.Any(p => p.Cedula.Equals(cedula)))
                {
                        paso = true;           
                }
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

        public static bool ExisteUsuario(string cedula, string usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Usuarios.Any(p => p.Cedula.Equals(cedula)))
                {
                    paso = true;
                }
                else
                if (contexto.Usuarios.Any(x => x.Usuario.Equals(usuario)))
                {
                    paso = true;
                }

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
    }
}
