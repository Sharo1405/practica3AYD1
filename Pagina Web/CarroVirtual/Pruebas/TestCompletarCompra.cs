using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarroVirtual;
using System.Collections.Generic;

namespace Pruebas
{
    [TestClass]
    public class TestCompletarCompra
    {
        [TestMethod]
        public void Facturar()
        {
            //Arrange
            Factura factura = new Factura();
            factura.Apellido = "Lima";
            factura.Nombre = "Juan";
            factura.Dpi = "2987";
            
            factura.Zona = "Zona 12";
            DateTime fecha = DateTime.Now;
            string cadenafecha = fecha.ToString("yyyyMMdd");
            factura.Fecha = cadenafecha;

            List<ProductoCarrito> productos = new List<ProductoCarrito>();
            ProductoCarrito producto = new ProductoCarrito();
            producto.codigo = 1;
            ProductoCarrito producto2 = new ProductoCarrito();
            producto2.codigo = 2;
            ProductoCarrito producto3 = new ProductoCarrito();
            producto3.codigo = 3;

            productos.Add(producto);
            productos.Add(producto2);
            productos.Add(producto3);

            //Act
            //se llama a los metodos
            int filasAfectadas = 0;
            filasAfectadas = Facturacion.RealizarCompra(factura,productos);

            //Assert
            Assert.AreNotEqual(0, filasAfectadas);
        }

        //Nombre: Facturar sin productos
        //Descripcion: se probara realizar una facturacion sin productos, la prueba sera fallida ya que no se puede realizar compra
        //Sin tener productos en el carrito
        //Resultado: Prueba superada
        [TestMethod]
        public void FacturarSinProductos()
        {
            //Arrange
            Factura factura = new Factura();
            factura.Apellido = "Lima";
            factura.Nombre = "Juan";
            factura.Dpi = "2987";

            factura.Zona = "Zona 12";
            DateTime fecha = DateTime.Now;
            string cadenafecha = fecha.ToString("yyyyMMdd");
            factura.Fecha = cadenafecha;

            List<ProductoCarrito> productos = new List<ProductoCarrito>();

            //Act
            //se llama a los metodos
            int filasAfectadas = 0;
            filasAfectadas = Facturacion.RealizarCompra(factura, productos);

            //Assert
            Assert.AreEqual(0, filasAfectadas);
        }

        //Nombre: Facturar sin productos
        //Descripcion: se probara realizar una facturacion sin un nombre de usuario, la prueba sera fallida ya que no se puede realizar compra
        //Sin tener un nombre de usuario
        //Resultado: Prueba superada
        [TestMethod]
        public void FacturarSinNombre()
        {
            //Arrange
            Factura factura = new Factura();
            factura.Apellido = "Lima";
            factura.Nombre = "";
            factura.Dpi = "2987";

            factura.Zona = "Zona 12";
            DateTime fecha = DateTime.Now;
            string cadenafecha = fecha.ToString("yyyyMMdd");
            factura.Fecha = cadenafecha;

            List<ProductoCarrito> productos = new List<ProductoCarrito>();
            ProductoCarrito producto = new ProductoCarrito();
            producto.codigo = 1;
            ProductoCarrito producto2 = new ProductoCarrito();
            producto2.codigo = 2;
            ProductoCarrito producto3 = new ProductoCarrito();
            producto3.codigo = 3;

            productos.Add(producto);
            productos.Add(producto2);
            productos.Add(producto3);

            //Act
            //se llama a los metodos
            int filasAfectadas = 0;
            filasAfectadas = Facturacion.RealizarCompra(factura, productos);

            //Assert
            Assert.AreEqual(0, filasAfectadas);
        }

        //Nombre: Facturar sin productos
        //Descripcion: se probara realizar una facturacion sin un Apellido de usuario, la prueba sera fallida ya que no se puede realizar compra
        //Sin tener un Apellido de usuario
        //Resultado: Prueba superada
        [TestMethod]
        public void FacturarSinApellido()
        {
            //Arrange
            Factura factura = new Factura();
            factura.Apellido = "";
            factura.Nombre = "Juan";
            factura.Dpi = "2987";

            factura.Zona = "Zona 12";
            DateTime fecha = DateTime.Now;
            string cadenafecha = fecha.ToString("yyyyMMdd");
            factura.Fecha = cadenafecha;

            List<ProductoCarrito> productos = new List<ProductoCarrito>();
            ProductoCarrito producto = new ProductoCarrito();
            producto.codigo = 1;
            ProductoCarrito producto2 = new ProductoCarrito();
            producto2.codigo = 2;
            ProductoCarrito producto3 = new ProductoCarrito();
            producto3.codigo = 3;

            productos.Add(producto);
            productos.Add(producto2);
            productos.Add(producto3);

            //Act
            //se llama a los metodos
            int filasAfectadas = 0;
            filasAfectadas = Facturacion.RealizarCompra(factura, productos);

            //Assert
            Assert.AreEqual(0, filasAfectadas);
        }

        //Nombre: Facturar sin productos
        //Descripcion: se probara realizar una facturacion sin un DPI de usuario, la prueba sera fallida ya que no se puede realizar compra
        //Sin tener un DPI de usuario
        //Resultado: Prueba superada
        [TestMethod]
        public void FacturarSinDPI()
        {
            //Arrange
            Factura factura = new Factura();
            factura.Apellido = "Lima";
            factura.Nombre = "Juan";
            factura.Dpi = "";

            factura.Zona = "Zona 12";
            DateTime fecha = DateTime.Now;
            string cadenafecha = fecha.ToString("yyyyMMdd");
            factura.Fecha = cadenafecha;

            List<ProductoCarrito> productos = new List<ProductoCarrito>();
            ProductoCarrito producto = new ProductoCarrito();
            producto.codigo = 1;
            ProductoCarrito producto2 = new ProductoCarrito();
            producto2.codigo = 2;
            ProductoCarrito producto3 = new ProductoCarrito();
            producto3.codigo = 3;

            productos.Add(producto);
            productos.Add(producto2);
            productos.Add(producto3);

            //Act
            //se llama a los metodos
            int filasAfectadas = 0;
            filasAfectadas = Facturacion.RealizarCompra(factura, productos);

            //Assert
            Assert.AreEqual(0, filasAfectadas);
        }

        //Nombre: Facturar sin productos
        //Descripcion: se probara realizar una facturacion sin un lugar de entrega, la prueba sera fallida ya que no se puede realizar compra
        //Sin tener un lugar de entrega
        //Resultado: Prueba superada
        [TestMethod]
        public void FacturarSinZonaDeEntrega()
        {
            //Arrange
            Factura factura = new Factura();
            factura.Apellido = "";
            factura.Nombre = "Juan";
            factura.Dpi = "2987";

            factura.Zona = "Zona 12";
            DateTime fecha = DateTime.Now;
            string cadenafecha = fecha.ToString("yyyyMMdd");
            factura.Fecha = cadenafecha;

            List<ProductoCarrito> productos = new List<ProductoCarrito>();
            ProductoCarrito producto = new ProductoCarrito();
            producto.codigo = 1;
            ProductoCarrito producto2 = new ProductoCarrito();
            producto2.codigo = 2;
            ProductoCarrito producto3 = new ProductoCarrito();
            producto3.codigo = 3;

            productos.Add(producto);
            productos.Add(producto2);
            productos.Add(producto3);

            //Act
            //se llama a los metodos
            int filasAfectadas = 0;
            filasAfectadas = Facturacion.RealizarCompra(factura, productos);

            //Assert
            Assert.AreEqual(0, filasAfectadas);
        }

        //Nombre: Facturar sin productos
        //Descripcion: se probara realizar una facturacion sin llenar el formulario de envio, la prueba sera fallida ya que no se puede realizar compra
        //Sin llenar todos los datos del formulario de envio
        //Resultado: Prueba superada
        [TestMethod]
        public void FacturarSinLlenarFormulario()
        {
            //Arrange
            Factura factura = new Factura();
            factura.Apellido = "";
            factura.Nombre = "";
            factura.Dpi = "";

            factura.Zona = "";
            DateTime fecha = DateTime.Now;
            string cadenafecha = fecha.ToString("yyyyMMdd");
            factura.Fecha = cadenafecha;

            List<ProductoCarrito> productos = new List<ProductoCarrito>();
            ProductoCarrito producto = new ProductoCarrito();
            producto.codigo = 1;
            ProductoCarrito producto2 = new ProductoCarrito();
            producto2.codigo = 2;
            ProductoCarrito producto3 = new ProductoCarrito();
            producto3.codigo = 3;

            productos.Add(producto);
            productos.Add(producto2);
            productos.Add(producto3);

            //Act
            //se llama a los metodos
            int filasAfectadas = 0;
            filasAfectadas = Facturacion.RealizarCompra(factura, productos);

            //Assert
            Assert.AreEqual(0, filasAfectadas);
        }
    }
}
