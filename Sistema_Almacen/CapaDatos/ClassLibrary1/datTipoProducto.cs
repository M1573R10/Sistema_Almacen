using CapaEntidad;
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

        #endregion
    }
}