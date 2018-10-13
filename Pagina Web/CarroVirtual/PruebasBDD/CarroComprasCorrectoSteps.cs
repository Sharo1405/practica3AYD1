using System;
using CarroVirtual.Tienda;
using CarroVirtual;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PruebasBDD
{
    [Binding]
    public class CarroComprasCorrectoSteps
    {
        int codigo = 0;
        //int validacion = 0;
        List<ProductoCarrito> listaProductos;

        [Given(@"el codigo ""(.*)"" de un producto que está dentro del carro de compras")]
        public void GivenElCodigoDeUnProductoQueEstaDentroDelCarroDeCompras(int p0)
        {
            //ScenarioContext.Current.Pending();
            codigo = p0;
        }
        
        [When(@"al cargar la pantalla del carrito")]
        public void WhenAlCargarLaPantallaDelCarrito()
        {
            //validacion = ContrMostrarProductos.ValidarProductoCarroCompras(codigo);
            //Console.WriteLine("Según el BDD es "+validacion);
            listaProductos = ContrMostrarProductos.BuscarProductCar();
        }
        
        [Then(@"se encontrará dicho producto y devolverá un ""(.*)""")]
        public void ThenSeEncontraraDichoProductoYDevolveraUn(int p0)
        {
            //ScenarioContext.Current.Pending();
            //Console.WriteLine("Y la comparación es " + validacion+" y "+p0);
            //Assert.AreEqual(validacion, p0);
            Assert.AreEqual(true, listaProductos.Count > p0);
        }
    }
}
