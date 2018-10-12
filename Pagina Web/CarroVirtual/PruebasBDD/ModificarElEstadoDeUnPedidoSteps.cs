using CarroVirtual;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace PruebasBDD
{
    [Binding]
    public class ModificarElEstadoDeUnPedidoSteps
    {
        private int IdFactura;
        private int IdNuevoEstado;
        private int IdAnteriorEstado;
        private int resultado;
        private ClassEditarPedido classEPedido = new ClassEditarPedido();

        [Given(@"el codigo de la factura (.*)")]
        public void GivenElCodigoDeLaFactura(int p0)
        {
            IdFactura = p0;
        }

        [Given(@"el estado de la factura ""(.*)"" con su identificador (.*)")]
        public void GivenElEstadoDeLaFacturaConSuIdentificador(string p0, int p1)
        {
            IdAnteriorEstado = p1;
        }

        [Given(@"el nuevo estado de la factura ""(.*)"" con su identificador (.*)")]
        public void GivenElNuevoEstadoDeLaFacturaConSuIdentificador(string p0, int p1)
        {
            IdNuevoEstado = p1;
        }

        [When(@"al momento de presionar el boton de Editar Pedido")]
        public void WhenAlMomentoDePresionarElBotonDeEditarPedido()
        {
            resultado = ClassEditarPedido.editarPedido(IdFactura.ToString(), IdNuevoEstado.ToString());
        }

        [Then(@"se debe realizar la modificacion del pedido y validar con un valor distinto de (.*)")]
        public void ThenSeDebeRealizarLaModificacionDelPedidoYValidarConUnValorDistintoDe(int p0)
        {
            Assert.AreNotEqual(p0, resultado);
        }
    }
}
