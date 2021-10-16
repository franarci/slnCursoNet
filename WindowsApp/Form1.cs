﻿using System;
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
    }
}
