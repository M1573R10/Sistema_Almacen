using CapaEntidad;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datProducto
    {
        #region singleton
        private static readonly datProducto _instancia = new datProducto();
        public static datProducto Instancia { get { return datProducto._instancia; } }
        #endregion singleton

        #region metodos
        public Boolean RegistrarProducto(entProducto Registrar)
        {
            SqlCommand cmd = null;
            Boolean registra = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistroProducto", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Registrar.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Registrar.Descripcion);
                cmd.Parameters.AddWithValue("@CodTipPro", Registrar.CodTipPro);
                cmd.Parameters.AddWithValue("@CodMarca", Registrar.CodMarca);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    registra = true;
                }
            }
            catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return registra;
        }

        public Boolean ModificarProducto(entProducto Modificar)
        {
            SqlCommand cmd = null;
            Boolean modifica = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarProducto", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Descripcion", Modificar.Descripcion);
                cmd.Parameters.AddWithValue("@CodTipPro", Modificar.CodTipPro);
                cmd.Parameters.AddWithValue("@CodMarca", Modificar.CodMarca);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { modifica = true; }
            }catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return modifica;
        }

        public Boolean DeshabilitaProducto(entProducto Deshabilita)
        {
            SqlCommand cmd = null;
            Boolean deshabilita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaProducto", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodPro", Deshabilita.CodPro);
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

        public List<entProducto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<entProducto> Lista = new List<entProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaProducto", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entProducto Mostrar = new entProducto();
                    Mostrar.CodPro = Convert.ToInt32(dr["CodPro"].ToString());
                    Mostrar.Nombre = dr["Nombre"].ToString();
                    Mostrar.Descripcion = dr["Descripcion"].ToString();
                    Mostrar.CodTipPro = Convert.ToInt32(dr["CodTipPro"].ToString());
                    Mostrar.CodMarca = Convert.ToInt32(dr["CodMarca"].ToString());
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
