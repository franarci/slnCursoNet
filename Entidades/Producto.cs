using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto {
            get
            {
                return Convert.ToDecimal(Margen) + PrecioCosto;
            }
        }
        public decimal PrecioVenta {
            get
            {
                Convert.ToDecimal(1 + this.IVA);
                return Convert.ToDecimal(IVA) + PrecioBruto;

            }
        }
        public string Proovedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }


    }
}
