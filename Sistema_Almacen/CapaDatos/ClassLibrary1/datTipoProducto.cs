using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class datTipoProducto
    {
        #region sigleton
        private static readonly datTipoProducto _instancia = new datTipoProducto(); 
        public static datTipoProducto Instancia { get { return datTipoProducto._instancia; } }

        #endregion singleton

        #region metodos

        public Boolean RegistrarTipoProducto(entTipoProducto Registrar)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spRegistroTipoProducto", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Registrar.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Registrar.Descripcion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close();}
            return inserta;
        }

        public Boolean ModificarTipoProducto(entTipoProducto Modificar)
        {
            SqlCommand cmd = null;
            Boolean modifica = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spActualizarTipoProducto", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodTipPro", Modificar.CodTipPro);
                cmd.Parameters.AddWithValue("@Nombre", Modificar.Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Modificar.Descripcion);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0) { modifica = true; }
            }catch (Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return modifica;
        }

        public List<entTipoProducto> ListarTipoProducto()
        {
            SqlCommand cmd = null;
            List<entTipoProducto> Lista = new List<entTipoProducto>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spListaTipoProducto", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoProducto Mostrar = new entTipoProducto();
                    Mostrar.CodTipPro = Convert.ToInt32(dr["CodTipPro"]);
                    Mostrar.Nombre = dr["Nombre"].ToString();
                    Mostrar.Descripcion = dr["Descripcion"].ToString();
                    Lista.Add(Mostrar);
                }
            }catch(Exception ex) { throw ex; }
            finally { cmd.Connection.Close(); }
            return Lista;
        }
        
        public Boolean eliminarTipoProducto(entTipoProducto Eliminar)
        {
            SqlCommand cmd = null;
            Boolean eliminar = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEliminarTipoProducto", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodTipPro", Eliminar.CodTipPro);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    eliminar = true;
                }
            }catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return eliminar;   

        }

           #endregion
        }
}