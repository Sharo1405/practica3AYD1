using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarroVirtual;

namespace Pruebas
{
    [TestClass]
    public class TestLogin
    {
        /*
       Nombre: Login correcto
       Detalles: Se ingresa el usuario y contrasenia correctos, ingresa al sistema
       */
        [TestMethod]
        public void Login_Correcto()
        {
            //Arrange
            int resultado = 1;

            //Act
            int realizado = Gestion_Login.Ingreso("administrador","1234");

            //Assert
            Assert.AreEqual(resultado, realizado);
           
        }



        /*
       Nombre: Login incorrecto ambos campos
       Detalles: Se ingresa el usuario incorrecto y la contrasenia correcto, no ingresa al sistema
       */
        [TestMethod]
        public void Login_InCorrecto()
        {
            //Arrange
            int resultado = 0;

            //Act
            int realizado = Gestion_Login.Ingreso("Administrador", "1234");

            //Assert
            Assert.AreEqual(resultado, realizado);
            
        }




        /*
       Nombre: Login incorrecto campo usuario en blanco
       Detalles: El campo usuario esta en blanco y la contrasenia ingresada correcto, no ingresa al sistema
       */
        [TestMethod]
        public void Login_InCorrecto_nombre()
        {
            //Arrange
            int resultado = 0;

            //Act
            int realizado = Gestion_Login.Ingreso("", "1234");

            //Assert
            Assert.AreEqual(resultado, realizado);
        }




        /*
       Nombre: Login incorrecto campo contrasenia incorrecto
       Detalles: Se ingresa el usuario correcto y la contrasenia incorrecta, no ingresa al sistema
       */
        [TestMethod]
        public void Login_InCorrecto_contrasenia()
        {
            //Arrange
            int resultado = 0;

            //Act
            int realizado = Gestion_Login.Ingreso("administrador", "123abs");

            //Assert
            Assert.AreEqual(resultado, realizado);
            
        }
    }
}
