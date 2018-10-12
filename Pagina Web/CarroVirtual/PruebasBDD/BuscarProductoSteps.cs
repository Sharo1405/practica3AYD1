using CarroVirtual;
using CarroVirtual.Tienda;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace PruebasBDD
{
    [Binding]
    public class BuscarProductoSteps
    {
        String nombreABuscar;
        List<ProductoCarrito> listaProductos;

        [Given(@"El nombre de un producto ""(.*)""")]
        public void GivenElNombreDeUnProducto(string p0)
        {
            nombreABuscar = p0;
        }

        [When(@"clic en buscar")]
        public void WhenClicEnBuscar()
        {
            //Los parametros son: categoria, nombre a buscar y pagina de busqueda
            listaProductos = ContrMostrarProductos.BuscarProductos(null, nombreABuscar, 0);
        }

        [Then(@"el numero de productos es igual o mayor a (.*)")]
        public void ThenElNumeroDeProductosEsIgualOMayorA(int p0)
        {
            Assert.AreEqual(true, listaProductos.Count > p0);
        }
    }
}
