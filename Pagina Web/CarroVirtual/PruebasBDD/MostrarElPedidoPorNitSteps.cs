using CarroVirtual;
using CarroVirtual.Tienda;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using TechTalk.SpecFlow;

namespace PruebasBDD
{
    [Binding]
    public class MostrarElPedidoPorNitSteps
    {
        private string NitABuscar;
        private DataTable DatosPedido = new DataTable();

        [Given(@"el nit del usuario ""(.*)""")]
        public void GivenElNitDelUsuario(string p0)
        {
            NitABuscar = p0;
        }

        [When(@"al momento de presionar el boton de Buscar Compra")]
        public void WhenAlMomentoDePresionarElBotonDeBuscarCompra()
        {

            DatosPedido = BuscarEstadoClass.obtenerPedidoDPI(NitABuscar);
        }

        [Then(@"Se retorne un pedido con identificador (.*), nombre ""(.*)"", apellido ""(.*)"" zona de entrega ""(.*)"" y estado (.*)")]
        public void ThenSeRetorneUnPedidoConIdentificadorNombreApellidoZonaDeEntregaYFecha(int p0, string p1, string p2, string p3, int p5)
        {
            Assert.AreEqual(p0, DatosPedido.Rows[0][0]);
            Assert.AreEqual(p1, DatosPedido.Rows[0][1]);
            Assert.AreEqual(p2, DatosPedido.Rows[0][2]);
            Assert.AreEqual(p3, DatosPedido.Rows[0][3]);
            Assert.AreEqual(p5, DatosPedido.Rows[0][5]);
        }
    }
}
