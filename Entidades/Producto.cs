using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region props autoimplementadas
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public string Proovedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        #endregion
        #region propidades solo lectura
        public decimal PrecioBruto {
            get
            {
                return this.PrecioCosto * (Convert.ToDecimal(1 + this.Margen));
            }
        }
        public decimal PrecioVenta {
            get
            {
                return Convert.ToDecimal(IVA + 1) * PrecioBruto;

            }
        }
        #endregion

        #region constructor
        public Producto(string nombre, string descripcion, decimal precioCosto, double margen, double iva, string proveedor, string categoria, string subCategoria)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioCosto = precioCosto;
            Margen = margen;
            IVA = iva;
            Proovedor = proveedor;
            Categoria = categoria;
            SubCategoria = subCategoria;
        }
        #endregion

    }
}
