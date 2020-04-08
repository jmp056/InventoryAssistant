using InventoryAssistant.DAL;
using InventoryAssistant.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryAssistant.BLL
{
    public class CuadresDeCajaBLL
    {

        public static bool Guardar(CuadresDeCaja CuadreDeCaja)
        {
            bool paso = false;
            SqlConnection Conexion = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = InventoryAssistantDb; Integrated Security = True");

            try
            {

                string query = "INSERT INTO CuadresDeCajas (CuadreDeCajaId, Fecha, Usuario, Dosmil, Mil, Quinientos ,Doscientos, Cien, Cincuenta, Veinticinco, Veinte, Diez, Cinco, Uno, TotalVendido, Diferencia, TotalEnCaja, Estado, UsuarioR) VALUES" +
                                                          "(@CuadreDeCajaId, @Fecha, @Usuario, @Dosmil, @Mil, @Quinientos, @Doscientos, @Cien, @Cincuenta, @Veinticinco, @Veinte, @Diez, @Cinco, @Uno, @TotalVendido, @Diferencia, @TotalEnCaja, @Estado, @UsuarioR)";
                Conexion.Open();
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.AddWithValue("@CuadreDeCajaId", CuadreDeCaja.CuadreDeCajaId);
                comando.Parameters.AddWithValue("@Fecha", CuadreDeCaja.Fecha);
                comando.Parameters.AddWithValue("@Usuario", CuadreDeCaja.Usuario);
                comando.Parameters.AddWithValue("@Dosmil", CuadreDeCaja.Dosmil);
                comando.Parameters.AddWithValue("@Mil", CuadreDeCaja.Mil);
                comando.Parameters.AddWithValue("@Quinientos", CuadreDeCaja.Quinientos);
                comando.Parameters.AddWithValue("@Doscientos", CuadreDeCaja.Doscientos);
                comando.Parameters.AddWithValue("@Cien", CuadreDeCaja.Cien);
                comando.Parameters.AddWithValue("@Cincuenta", CuadreDeCaja.Cincuenta);
                comando.Parameters.AddWithValue("@Veinticinco", CuadreDeCaja.Veinticinco);
                comando.Parameters.AddWithValue("@Veinte", CuadreDeCaja.Veinte);
                comando.Parameters.AddWithValue("@Diez", CuadreDeCaja.Diez);
                comando.Parameters.AddWithValue("@Cinco", CuadreDeCaja.Cinco);
                comando.Parameters.AddWithValue("@Uno", CuadreDeCaja.Uno);
                comando.Parameters.AddWithValue("@TotalVendido", CuadreDeCaja.TotalVendido);
                comando.Parameters.AddWithValue("@Diferencia", CuadreDeCaja.Diferencia);
                comando.Parameters.AddWithValue("@TotalEnCaja", CuadreDeCaja.TotalEnCaja);
                comando.Parameters.AddWithValue("@Estado", CuadreDeCaja.Estado);
                comando.Parameters.AddWithValue("@UsuarioR", CuadreDeCaja.UsuarioR);

                int FilasAfectadas = comando.ExecuteNonQuery();
                if (FilasAfectadas > 0)
                    paso = true;

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                Conexion.Close();

            }

            return paso;
        }

    }
}
