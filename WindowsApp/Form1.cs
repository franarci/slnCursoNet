using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un nombre");
            string descripcion = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una descripcion");
            decimal precioCosto = Convert.ToDecimal(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un precio costo(solo numeros)"));
            double margen = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un margen(solo numeros)"));
            double iva = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un iva(solo numeros)"));
            string proveedor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un proveedor");
            string categoria = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una categoria");
            string subCategoria = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una subcategoria");

            Producto producto = new Producto(nombre, descripcion, precioCosto, margen, iva, proveedor, categoria, subCategoria);

            lstInstancias.Items.Add("Producto: "+ producto.Nombre + " " + producto.Descripcion + "    Margen: " +producto.Margen +"    IVA: " + producto.IVA+ "   Proveedor: " + producto.Proovedor + "   Categoria: "+ producto.Categoria + "   Subcategoria: " + producto.SubCategoria);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un nombre");
            string cuit = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un cuit");
            string contacto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un contacto");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un email");
            string telefono = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un telefono");
            string direccion = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una direccion");

            Proveedor proveedor = new Proveedor(nombre, cuit, contacto, email, telefono, direccion);

            lstInstancias.Items.Add("Proveedor: " + proveedor.Nombre + " " + proveedor.CUIT + "    Contacto: " + proveedor.Contacto + "    Email: " + proveedor.Email + "   Telefono: " + proveedor.Telefono + "   Direccion: " + proveedor.Direccion);
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            string nombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un nombre");
            string apellido = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un apellido");
            string dni = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un dni");
            string email = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un email");
            string telefono = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un telefono");
            string direccion = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una direccion");

            Vendedor vendedor = new Vendedor(nombre, apellido, dni, email, telefono, direccion);

            lstInstancias.Items.Add("Vendedor: " + vendedor.Nombre + " " + vendedor.Apellido + "    DNI: " + vendedor.DNI + "    Email: " + vendedor.Email + "   Telefono: " + vendedor.Telefono + "   Direccion: " + vendedor.Direccion);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            string tipo = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un tipo");
            string numero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero");
            DateTime fecha = Convert.ToDateTime(Microsoft.VisualBasic.Interaction.InputBox("Ingrese una fecha de facturacion  (Ej: 04/10/2000)"));
            string cliente = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un cliente");
            string direccion = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una direccion");
            string condicionIVA = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una condicion iva");
            string condicionVenta = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una condicion venta");
            string detalle = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un detalle");
            decimal total = Convert.ToDecimal(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un monto total (solo numeros)"));

            Factura factura = new Factura(tipo, numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total);

            lstInstancias.Items.Add("Factura Tipo " + factura.Tipo + "  Numero: " + factura.Numero + "    Fecha: " + factura.Fecha + "    Cliente: " + factura.Cliente + "   Direccion: " + factura.Direccion + "   CondicionIVA: " + factura.CondicionIVA + "   CondicionVenta: " + factura.CondicionVenta + "   Detalle: " + factura.Detalle + "   Total: " + factura.Total);
        }

        private void btnRemito_Click(object sender, EventArgs e)
        {
            string numero = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un numero");
            DateTime fecha = Convert.ToDateTime(Microsoft.VisualBasic.Interaction.InputBox("Ingrese una fecha de facturacion  (Ej: 04/10/2000)"));
            string cliente = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un cliente");
            string direccion = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una direccion");
            string condicionIVA = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una condicion iva");
            string condicionVenta = Microsoft.VisualBasic.Interaction.InputBox("Ingrese una condicion venta");
            DateTime fechaEntrega = Convert.ToDateTime(Microsoft.VisualBasic.Interaction.InputBox("Ingrese una fecha de entrega  (Ej: 04/10/2000)"));
            string detalle = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un detalle");
            decimal total = Convert.ToDecimal(Microsoft.VisualBasic.Interaction.InputBox("Ingrese un monto total (solo numeros)"));

            Remito remito = new Remito(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, fechaEntrega, total);

            lstInstancias.Items.Add("Remito: " + remito.Numero + "    Fecha: " + remito.Fecha + "    Cliente: " + remito.Cliente + "   Direccion: " + remito.Direccion + "   CondicionIVA: " + remito.CondicionIVA + "   CondicionVenta: " + remito.CondicionVenta +"   Fecha Entrega: " +remito.FechaEntrega+ "   Detalle: " + remito.Detalle + "   Total: " + remito.Total);
        }
    }
}
