using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logProveedores
    {
        #region singleton

        private static readonly logProveedores _instancia = new logProveedores();
        public static logProveedores Instancia { get { return logProveedores._instancia; } }

        #endregion

        #region metodos

        public void RegistrarProveedores(entProveedores Registrar)
        {
            datProveedores.Instancia.RegistrarProveedores(Registrar);
        }

        #endregion
    }
}
