using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logOrdenCompra1
    {

            public void GuardarOrdenCompra(string ruc, DateTime fecha, string productos)
            {
                datOrdenCompra datos = new datOrdenCompra();
                datos.GuardarOrdenCompra(ruc, fecha, productos);
            }
        

    }
}
