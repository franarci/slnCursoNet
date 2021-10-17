using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.BaseModels;

namespace Entidades
{
    public class Remito : DocumentoComercial
    {
        public DateTime FechaEntrega { get; set; }

        public Remito(string numero, DateTime fecha, string cliente, string dir, string condIva, string condVenta, string detalle, DateTime fechaEntrega, decimal total) : base(numero, fecha, cliente, dir, condIva, condVenta, detalle, total)
        {
            FechaEntrega = fechaEntrega;
        }
    }

    
}
