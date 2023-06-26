using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMarca
    {
        #region singleton
        private static readonly logMarca _instancia = new logMarca();
        public static logMarca Instancia
        {
            get { return logMarca._instancia; }
        }
        #endregion singleton

        #region metodos
        public void RegistrarMarca(entMarca Registrar)
        {
            datMarca.Instancia.RegistrarMarca(Registrar);
        }

        public void ModificarMarca(entMarca Modificar)
        {
            datMarca.Instancia.ModificarMarca(Modificar);
        }

        public List<entMarca> ListarMarca()
        {
            return datMarca.Instancia.ListarMarca();
        }


        public void EliminarMarca(entMarca Eliminar)
        {
            datMarca.Instancia.EliminarMarca(Eliminar);
        }
 

        #endregion
    }
}
