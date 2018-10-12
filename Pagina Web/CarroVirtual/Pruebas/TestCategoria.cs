using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarroVirtual;

namespace Pruebas
{
    [TestClass]
    public class TestCategoria
    {
        /*
        Nombre: Crear categoria con nombre y descripcion
        Detalles: Crea la cateoria con todos sus campos llenos
         */
        [TestMethod]
        public void Crear_categoria_nombre_descripcion_NOEXISTENTE()
        {
            //Arrange
            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.nombre = "nombre";
            categoria.descripcion = "Soy la descripcion de la categoria";

            
            //Act
            bool realizado = Gestion_categoria_crud.CrearCategoria(categoria);

            //Assert
            Assert.AreEqual(resultado, realizado);
        }


        /*
        Nombre: Crear categoria con nombre y descripcion que ya existe
        Detalles: Se intenta crear una categoria que ya existe y el sistema no debe permitirlo
         */
        [TestMethod]
        public void Crear_categoria_nombre_descripcion_EXISTENTE()
        {
            //Arrange
            bool resultado = false;
            Categoria categoria = new Categoria();
            categoria.nombre = "nombre";
            categoria.descripcion = "Soy la descripcion de la categoria";
            
            
            //Act
            bool realizado = Gestion_categoria_crud.CrearCategoria(categoria);

            //Assert
            Assert.AreEqual(resultado, realizado);
            
            Gestion_categoria_crud.Eliminar_categoria(categoria.nombre);
        }



        /*
        Nombre: Crear categoria unicamente con nombre.
        Detalles: Se crea una cateforia que carece de descripcion, es permitido.
         */
        [TestMethod]
        public void Crear_categoria_nombre_NOEXISTENTE()
        {
            //Arrange
            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.nombre = "OtroNombre";

            //Act
            bool realizado = Gestion_categoria_crud.CrearCategoria(categoria);
                
            //Assert
            Assert.AreEqual(resultado, realizado);
        }




        /*
        Nombre: Crear categoria unicamente con descripcion sin nombre.
        Detalles: Se quiere crear una categoria sin nombre, el sistema no lo permite.
         */
        [TestMethod]
        public void Crear_categoria_descripcion()
        {
            //Arrange
            bool resultado = false;
            Categoria categoria = new Categoria();
            categoria.descripcion = "soy descripcion, sin nombre categoria";

            //Act
            bool realizado = Gestion_categoria_crud.CrearCategoria(categoria);
            
            //Assert
            Assert.AreEqual(resultado, realizado);
            
        }



        /*
       Nombre: Eliminar categoria
       Detalles: se elimina una categoria de la base de datos
        */
        [TestMethod]
        public void Eliminar_categoria_Existente()
        {
            //Arrange
            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.nombre = "OtroNombre";

            //Act
            bool realizado = Gestion_categoria_crud.Eliminar_categoria(categoria.nombre);
            
            //Assert
            Assert.AreEqual(resultado, realizado);
        }



        /*
       Nombre: Editar categoria
       Detalles: Se edita el nombre u la descripcion de la categoria
        */
        [TestMethod]
        public void Editar_categoria_Existente()
        {
            //Arrange
            Categoria prueba = new Categoria();
            prueba.nombre = "Prueba";
            prueba.descripcion = "Soy una prueba";
            Gestion_categoria_crud.CrearCategoria(prueba);

            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.nombre = "nuevoNombre";
            categoria.descripcion = "nueva descripcion prueba";

            //Act
            bool realizado = Gestion_categoria_crud.EditarCategoria(categoria, prueba.nombre);
            

            //Assert
            Assert.AreEqual(resultado, realizado);
           
            Gestion_categoria_crud.Eliminar_categoria(categoria.nombre);
        }




        /*
      Nombre: Editar categoria nombre
      Detalles: Se edita unicamente el nombre de la categoria
       */
        [TestMethod]
        public void Editar_categoria_nombre_Existente()
        {
            //Arrange
            Categoria prueba = new Categoria();
            prueba.nombre = "Prueba";
            prueba.descripcion = "Soy una prueba";
            Gestion_categoria_crud.CrearCategoria(prueba);

            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.nombre = "nuevoNombre2";

            //Act
            bool realizado = Gestion_categoria_crud.EditarCategoria(categoria, prueba.nombre);
            

            //Assert
            Assert.AreEqual(resultado, realizado);
            
            Gestion_categoria_crud.Eliminar_categoria(categoria.nombre);
        }




        /*
        Nombre: Editar categoria desripcion
        Detalles: Se edita unicamente la descripcion de la categoria
        */
        [TestMethod]
        public void Editar_categoria_descripcion_Existente()
        {
            //Arrange
            Categoria prueba = new Categoria();
            prueba.nombre = "Prueba";
            prueba.descripcion = "Soy una prueba";
            Gestion_categoria_crud.CrearCategoria(prueba);

            bool resultado = true;
            Categoria categoria = new Categoria();
            categoria.descripcion = "nueva descripcion 2";

            //Act
            bool realizado = Gestion_categoria_crud.EditarCategoria(categoria, prueba.nombre);
        

            //Assert
            Assert.AreEqual(resultado, realizado);
            
            Gestion_categoria_crud.Eliminar_categoria(prueba.nombre);
        }
    }
}
