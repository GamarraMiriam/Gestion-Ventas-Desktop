using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Consola

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fase 01" + Environment.NewLine);
            Producto objProducto = new Producto("Producto A", "Descripcion del producto A", 10, .25, .21, "Acme", "Categoria A", "Subcategoria A.b");
            Console.WriteLine("Producto" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objProducto.Nombre);
            Console.WriteLine("Descripcion: {0}", objProducto.Descripcion);
            Console.WriteLine("Precio de costo: {0}", objProducto.PrecioCosto.ToString("c"));
            Console.WriteLine("Margen: {0}", objProducto.Margen.ToString("p"));
            Console.WriteLine("IVA: {0}", objProducto.IVA.ToString("p"));
            Console.WriteLine("Precio bruto: {0}", objProducto.PrecioBruto.ToString("c"));
            Console.WriteLine("Precio venta: {0} ", objProducto.PrecioVenta.ToString("c"));
            Console.WriteLine("Proveedor:{0}", objProducto.Proveedor);
            Console.WriteLine("Categoria: {0}", objProducto.Categoria);
            Console.WriteLine("Subcategoria: {0}", objProducto.SubCategoria);

            seguir();

            ClienteIndividuo objClienteIndividuo = new ClienteIndividuo("Juan", "Perez", "27-30269857-3", "bastis26@hotmail.com", "1162598746", "Cordoba 882");

            Console.WriteLine("Nombre: {0}", objClienteIndividuo.Nombre);
            Console.WriteLine("Apellido: {0}", objClienteIndividuo.Apellido);
            Console.WriteLine("CUIT: {0}", objClienteIndividuo.CUIT);
            Console.WriteLine("Email: {0}", objClienteIndividuo.Email);
            Console.WriteLine("Telefono: {0}", objClienteIndividuo.Telefono);
            Console.WriteLine("Direccion: {0}", objClienteIndividuo.Direccion);

            seguir();

            ClienteEmpresa objclienteEmpresa = new ClienteEmpresa("Leda", "24-89562384-4", "Grupo Gonzalez", "ledaSofia@gamil.com", "1156404189", "Av. Del Libertador 2156","Leda.jpg");

            Console.WriteLine("ID: {0}", objclienteEmpresa.Id);
            Console.WriteLine("Nombre: {0}", objclienteEmpresa.Nombre);
            Console.WriteLine("Contacto:{0}", objclienteEmpresa.Contacto);
            Console.WriteLine("CUIT:{0}", objclienteEmpresa.CUIT);
            Console.WriteLine("Email: {0}", objclienteEmpresa.Email);
            Console.WriteLine("Telefono: {0}", objclienteEmpresa.Telefono);
            Console.WriteLine("Direccion: {0}", objclienteEmpresa.Direccion);
            Console.WriteLine("FOTO JPG: {0}", objclienteEmpresa.Fotojpg);


            seguir();

            Vendedor objVendedor = new Vendedor("Jose", "Mercado", "77.666.555");
            Console.WriteLine("Vendedor" + Environment.NewLine);

            Console.WriteLine("Nombre: {0}", objVendedor.Nombre);
            Console.WriteLine("Apellido: {0}", objVendedor.Apellido);
            Console.WriteLine("DNI: {0}", objVendedor.DNI);

            seguir();

            Console.WriteLine(Environment.NewLine + "pulse una tecla para continuar");
            Console.ReadKey();
        }
        private static void seguir()
        {
            Console.WriteLine(Environment.NewLine + "pulse una tecla para terminar");
            Console.ReadKey();
            Console.Clear();
        }

    }
}