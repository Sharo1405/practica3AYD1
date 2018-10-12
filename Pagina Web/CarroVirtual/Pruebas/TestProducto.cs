using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarroVirtual;

namespace Pruebas
{
    [TestClass]
    public class TestProducto
    {
        /*
        Nombre: Buscar Producto
        Detalles: buscar por Nombre
         */
        [TestMethod]
        public void BuscarProductoNombre()
        {
            //Arrange
            Producto productoEncontrado = new Producto();
            String nombreABuscar = "Mario";

            //Act
            productoEncontrado = ContrProductos.BuscarProducto(nombreABuscar);

            //Assert
            Assert.AreEqual("Mario bros",productoEncontrado.nombre);
            Assert.AreEqual(54,productoEncontrado.cantidad);
        }

        /*
        Nombre: Buscar Producto
        Detalles: buscar por Codigo
         */
        [TestMethod]
        public void BuscarProductoCodigo()
        {
            //Arrange
            Producto productoEncontrado = new Producto();
            int codigo = 1;

            //Act
            productoEncontrado = ContrProductos.BuscarProducto(codigo.ToString());

            //Assert
            Assert.AreEqual("Mario bros", productoEncontrado.nombre);
            Assert.AreEqual(54, productoEncontrado.cantidad);
        }

        /*
        Nombre: Insertar Producto
        Detalles: insertar un producto enviando como parámetro un objeto "producto"
         */
        [TestMethod]
        public void InsertarProducto()
        {
            //Arrange
            Categoria catProducto = new Categoria();
            catProducto.cod_categoria = 1;
            Producto nuevoProducto = new Producto();
            nuevoProducto.nombre = "Super smash bros 5";
            nuevoProducto.precio_venta = 300;
            nuevoProducto.cantidad = 50;
            nuevoProducto.categoria_cod_categoria = 1;
            nuevoProducto.detalles = "super smash wii u";
            Boolean resultado = false;

            //Act
            resultado=ContrProductos.CrearProducto(nuevoProducto,catProducto);

            //Assert
            Assert.AreEqual(true, resultado);
        }

        /*
        Nombre: Eliminar Producto
        Detalles: Eliminar un producto por su (Codigo)
         */
        [TestMethod]
        public void EliminarProducto()
        {
            //Arrange
            int codigoProducto = 1;
            bool resultado = false;

            //Act
            resultado = ContrProductos.EliminarProducto(codigoProducto);

            //Assert
            Assert.AreEqual(true, resultado);
        }

        /*
        Nombre: Editar Producto
        Detalles: Editar un producto como parametro (Producto)
         */
        [TestMethod]
        public void EditarProducto()
        {
            //Arrange
            Boolean resultado = false;
            Categoria catProducto = new Categoria();
            catProducto.cod_categoria = 1;
            Producto nuevoProducto = new Producto();
            nuevoProducto.cod_producto = 2;
            nuevoProducto.nombre = "Super smash bros MODIFICADO";
            nuevoProducto.precio_venta = 300;
            nuevoProducto.cantidad = 50;
            nuevoProducto.categoria_cod_categoria = 1;
            nuevoProducto.detalles = "super smash wii u";

            //Act
            resultado = ContrProductos.EditarProducto(nuevoProducto);

            //Assert
            Assert.AreEqual(true, resultado);
        }

        /*
        Nombre: Existe Producto
        Detalles: Verificar si un producto existe como parametro (Producto,Categoria)
         */
        [TestMethod]
        public void ExisteProducto()
        {
            //Arrange
            Boolean resultado = false;
            Categoria catProducto = new Categoria();
            catProducto.cod_categoria = 1;
            Producto nuevoProducto = new Producto();
            nuevoProducto.cod_producto = 2;
            nuevoProducto.nombre = "Super smash bros MODIFICADO";
            nuevoProducto.precio_venta = 300;
            nuevoProducto.cantidad = 50;
            nuevoProducto.categoria_cod_categoria = 1;
            nuevoProducto.detalles = "super smash wii u";

            //Act
            resultado = ContrProductos.ExisteProducto(nuevoProducto,catProducto);

            //Assert
            Assert.AreEqual(true, resultado);
        }
    }
}
