using System;
using TechTalk.SpecFlow;
using CarroVirtual;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasBDDFuncionales
{
    [Binding]
    public class RegistroDeProductoSteps
    {
        public Producto producto = new Producto();
        public Categoria categoria = new Categoria();
        public bool affectedrows = false;

        [Given(@"tengo nombre ""(.*)"" detalle ""(.*)"" precio (.*)")]
        public void GivenTengoNombreDetallePrecio(string p0, string p1, int p2)
        {
            producto.nombre = p0;
            producto.detalles = p1;
            producto.precio_venta = p2;
        }

        [When(@"presione el boton ingresar producto")]
        public void WhenPresioneElBotonIngresarProducto()
        {
            affectedrows = ContrProductos.CrearProducto(producto, categoria);
        }

        [Then(@"deberia retornarme una variable con valor distinto de (.*)")]
        public void ThenDeberiaRetornarmeUnaVariableConValorDistintoDe(int p0)
        {
            Assert.AreNotEqual(p0, affectedrows);
        }
    }
}
