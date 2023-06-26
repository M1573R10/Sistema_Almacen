using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaEntidad
{
    public class entProducto
    {
        public int CodPro { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int CodTipPro { get; set; }
        public int CodMarca { get; set; }
        public int stock { get; set; }
    }
}
