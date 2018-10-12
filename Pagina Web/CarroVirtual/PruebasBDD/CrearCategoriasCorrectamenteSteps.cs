using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarroVirtual;
using TechTalk.SpecFlow;

namespace PruebasBDD
{
    [Binding]
    public class CrearCategoriasCorrectamenteSteps
    {
        private string result = "";
        private Gestion_categoria_crud categoria = new Gestion_categoria_crud();

        [Given(@"el nombre de la categoria ""(.*)""")]
        public void GivenElNombreDeLaCategoria(string p0)
        {
            categoria.nombreBDD = p0;
        }
        
        [Given(@"la descripcion ""(.*)""")]
        public void GivenLaDescripcion(string p0)
        {
            categoria.descripcionBDD = p0;
        }
        
        [When(@"cuando presiones el boton de crea la nueva categoria")]
        public void WhenCuandoPresionesElBotonDeCreaLaNuevaCategoria()
        {
            result = categoria.CrearCategoriaBDD();
        }
        
        [Then(@"se debe crear la categoria con su nombre y descripcion esto validado con un ""(.*)""")]
        public void ThenSeDebeCrearLaCategoriaConSuNombreYDescripcionEstoValidadoConUn(string p0)
        {
            Assert.AreEqual(p0, result);
        }
    }
}
