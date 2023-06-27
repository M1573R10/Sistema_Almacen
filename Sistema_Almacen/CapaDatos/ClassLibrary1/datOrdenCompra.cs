using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datOrdenCompra
    {
        public void GuardarOrdenCompra(string ruc, DateTime fecha, string productos)
        {
            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                try
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand("GuardarOrdenCompra", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RUC", ruc);
                        cmd.Parameters.AddWithValue("@Fecha", fecha);
                        cmd.Parameters.AddWithValue("@Productos", productos);

                        cmd.ExecuteNonQuery();
                    }
                }catch (Exception ex) { throw ex; }
               
            }

        }




    }
}
