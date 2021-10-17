using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.BaseModels;
namespace Entidades
{
    public class Factura : DocumentoComercial
    {
        public string Tipo { get; set; }

        public Factura(string tipo, string numero, DateTime fecha, string cliente, string dir, string condIva, string condVenta, string detalle, decimal total) : base (numero,fecha,cliente,dir,condIva,condVenta,detalle,total)
        {
            Tipo = tipo;
        }
    }
}
