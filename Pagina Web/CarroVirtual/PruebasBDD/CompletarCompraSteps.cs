using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarroVirtual;
using System.Collections.Generic;

namespace PruebasBDD
{
    [Binding]
    public class CompletarCompraSteps
    {
        Factura factura = new Factura();
        List<ProductoCarrito> productos = new List<ProductoCarrito>();
        int affectedRow = 0;

        [Given(@"tengo un encabezado de factura con los siguientes datos ""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)""")]
        public void GivenTengoUnEncabezadoDeFacturaConLosSiguientesDatos(string p0, string p1, string p2, string p3, string p4)
        {
            DateTime fecha = DateTime.Now;
            string cadenafecha = fecha.ToString("yyyyMMdd");
            factura.Nombre = p0;
            factura.Apellido = p1;
            factura.Fecha = cadenafecha;
            factura.Dpi = p3;
            factura.Zona = p4;
        }
        
        [Given(@"una lista de productos con codigo (.*), nombre ""(.*)""")]
        public void GivenUnaListaDeProductosConCodigoNombre(int p0, string p1)
        {
            ProductoCarrito producto1 = new ProductoCarrito();
            producto1.codigo = p0;
            producto1.nombre = p1;
            productos.Add(producto1);
        }
        
        [Given(@"un segundo producto con codigo (.*), nombre ""(.*)""")]
        public void GivenUnSegundoProductoConCodigoNombre(int p0, string p1)
        {
            ProductoCarrito producto = new ProductoCarrito();

            producto.codigo = p0;
            producto.nombre = p1;
            productos.Add(producto);
        }
        
        [Given(@"un tercer producto con codigo (.*), nombre ""(.*)""")]
        public void GivenUnTercerProductoConCodigoNombre(int p0, string p1)
        {
            ProductoCarrito producto2 = new ProductoCarrito();
            producto2.codigo = p0;
            producto2.nombre = p1;
            productos.Add(producto2);
        }
        
        [When(@"yo presiono el boton de completar compra")]
        public void WhenYoPresionoElBotonDeCompletarCompra()
        {
            affectedRow = Facturacion.RealizarCompra(factura, productos);
        }

        [Then(@"se debe ingresar los datos y validarlo retornando un valor mayor que (.*)")]
        public void ThenSeDebeIngresarLosDatosYValidarloRetornandoUnValorMayorQue(int p0)
        {
            Assert.AreNotEqual(p0, affectedRow);
        }
    }
}
