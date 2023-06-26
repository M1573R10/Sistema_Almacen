using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;


namespace CapaDatos
{
    public class datMarca
    {
        #region singleton
        private static readonly datMarca _instancia = new datMarca();
        public static datMarca Instancia {  get { return datMarca._instancia; } }

        #endregion singleton

        #region metodos

        public Boolean RegistrarMarca(entMarca Registrar)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistroMarca", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Registrar.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Registrar.Descripcion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if(i > 0)
                {
                    inserta = true;
                }
            }catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close();}
            return inserta;
        }

        public Boolean ModificarMarca(entMarca Modificar)
        {
            SqlCommand cmd = null;
            Boolean modifica = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarMarca", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodMarca", Modificar.CodMarca);
                cmd.Parameters.AddWithValue("@Nombre", Modificar.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Modificar.Descripcion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if(i > 0) { modifica = true; }
            }catch(Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return modifica;
        }

        public List<entMarca> ListarMarca()
        {
            SqlCommand cmd = null;
            List<entMarca> Lista = new List<entMarca>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaMarca", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMarca Mostrar = new entMarca();
                    Mostrar.CodMarca = Convert.ToInt32(dr["CodMarca"].ToString());
                    Mostrar.Nombre = dr["Nombre"].ToString();
                    Mostrar.Descripcion = dr["Descripcion"].ToString();
                    Lista.Add( Mostrar );
                }
            }catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public Boolean EliminarMarca(entMarca Eliminar)
        {
            SqlCommand cmd = null;
            Boolean eliminar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminaMarca", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodMarca", Eliminar.CodMarca);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    eliminar = true;
                }
            }catch(Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return eliminar;
        }

        #endregion
    }
}
