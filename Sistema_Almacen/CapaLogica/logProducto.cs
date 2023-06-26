using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProducto
    {
        #region singleton
        private static readonly logProducto _instancia = new logProducto();
        public static logProducto Instancia { get 
            { return logProducto._instancia; } 
        }
        #endregion

        #region metodos
        public void RegistrarProducto(entProducto Registrar)
        {
            datProducto.Instancia.RegistrarProducto(Registrar);
        }

        public void ModificarProducto(entProducto Modificar)
        {
            datProducto.Instancia.ModificarProducto(Modificar);
        }

        public void DeshabilitaProducto(entProducto Deshabilita)
        {
            datProducto.Instancia.DeshabilitaProducto(Deshabilita);
        }
        public List<entProducto> ListarProducto()
        {
            return datProducto.Instancia.ListarProducto();
        }

        #endregion
    }
}
