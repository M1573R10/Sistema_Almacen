using CapaEntidad;
using Microsoft.Win32;
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

        public Boolean ModificarProveedores(entProveedores Modificar)
        {
            SqlCommand cmd = null;
            Boolean modifica = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarProveedores", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@RUC", Modificar.RUC);
                //cmd.Parameters.AddWithValue("@RazonSocial", Modificar.RazonSocial);
                cmd.Parameters.AddWithValue("@Direccion", Modificar.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", Modificar.Telefono);
                cmd.Parameters.AddWithValue("@Contacto", Modificar.Contacto);
                cmd.Parameters.AddWithValue("@Correo", Modificar.Correo);
                cmd.Parameters.AddWithValue("@FechaInicio", Modificar.FechaInicio);
                cmd.Parameters.AddWithValue("@Estado", Modificar.Estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { modifica = true; }
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return modifica;
        }

        public Boolean DeshabilitaProveedores(entProveedores Deshabilita)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitaProveedores", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RUC", Deshabilita.RUC);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilita = true;
                }
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return deshabilita;
        }

        public List<entProveedores> ListarProveedores()
        {
            SqlCommand cmd = null;
            List<entProveedores> Lista = new List<entProveedores>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaProveedores", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProveedores Mostrar = new entProveedores();
                    Mostrar.RUC = dr["RUC"].ToString();
                    Mostrar.RazonSocial = dr["RazonSocial"].ToString();
                    Mostrar.Direccion = dr["Direccion"].ToString();
                    Mostrar.Telefono = dr["Telefono"].ToString();
                    Mostrar.Contacto = dr["Contacto"].ToString();
                    Mostrar.Correo = dr["Correo"].ToString();
                    Mostrar.FechaInicio = Convert.ToDateTime(dr["FechaInicio"]);
                    Mostrar.Estado = Convert.ToBoolean(dr["Estado"]);

                    Lista.Add(Mostrar);
                }
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        #endregion
    }
}
