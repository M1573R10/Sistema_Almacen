using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datProveedores
    {
        #region singleton

        private static readonly datProveedores _instancia = new datProveedores();
        public static datProveedores Instancia { get { return datProveedores._instancia; } }

        #endregion singleton

        #region metodos

        public Boolean RegistrarProveedores(entProveedores Registrar)
        {
            SqlCommand cmd = null;
            Boolean registra = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistroProveedores", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUC", Registrar.RUC);
                cmd.Parameters.AddWithValue("@RazonSocial", Registrar.RazonSocial);
                cmd.Parameters.AddWithValue("@Direccion", Registrar.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", Registrar.Telefono);
                cmd.Parameters.AddWithValue("@Contacto", Registrar.Contacto);
                cmd.Parameters.AddWithValue("@Correo", Registrar.Correo);
                cmd.Parameters.AddWithValue("@FechaInicio", Registrar.FechaInicio);
                cmd.Parameters.AddWithValue("@Estado", Registrar.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registra = true;
                }
            }catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return registra;
        }

        #endregion
    }
}
