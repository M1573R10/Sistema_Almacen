using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entOrdenCompra
    {
        public int CodOrdCompra { get; set; }
        public string RUC { get; set; } 
        public DateTime Fecha { get; set; } 
        public int CodPro { get; set; }
        public int Cantidad { get; set; }   
        public decimal Precio { get; set; } 
        public decimal PrecioTotal { get; set; } 
    }
}
