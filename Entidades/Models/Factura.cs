using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }

        public Factura(string tipo, string numero, DateTime fecha, string cliente, string dir, string condIva, string condVenta, string detalle, decimal total)
        {
            Tipo = tipo;
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = dir;
            CondicionIVA = condIva;
            CondicionVenta = condVenta;
            Detalle = detalle;
            Total = total;
        }
    }
}
