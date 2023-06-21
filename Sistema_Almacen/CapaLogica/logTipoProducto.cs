using CapaDatos;
using CapaEntidad;
using System.Runtime.InteropServices;

namespace CapaLogica
{
    public class logTipoProducto
    {
        #region singleton
        private static readonly logTipoProducto _instancia = new logTipoProducto(); 
        public static logTipoProducto Instancia
        {
            get { return logTipoProducto._instancia; }
        }
        #endregion

        #region metodos
        public void RegistrarTipoProducto(entTipoProducto Registrar)
        {
            datTipoProducto.Instancia.RegistrarTipoProducto(Registrar);
        }
        public void ModificarTipoProducto(entTipoProducto Modificar)
        {
            datTipoProducto.Instancia.ModificarTipoProducto(Modificar);
        }

        #endregion
    }
}