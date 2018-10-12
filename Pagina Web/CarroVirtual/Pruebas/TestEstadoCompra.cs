using System;
using System.Data;
using CarroVirtual;
using CarroVirtual.Tienda;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pruebas
{
    [TestClass]
    public class TestEstadoCompra
    {
        /* 
         * EDITAR PEDIDO
        * Descripcion: CAMBIAR EL ESTADO DE UN PEDIDO
        */
        [TestMethod]
        public void EditarPedido()
        {
            //Arrenge
            string codCompra = ClassEditarPedido.obtenerFacturaPrueba();
            string codPedido = "1";

            //Act
            int affectedRows = ClassEditarPedido.editarPedido(codCompra, codPedido);

            //Asset
            Assert.AreNotEqual(0, affectedRows);


        }

        /* 
         * Validar el ID del pedido
        * Descripcion:Ver Validez del codigo de factura
        */
        [TestMethod]
        public void ValidarIDFactura()
        {
            //Arrenge
            string cadena = "2";

            //Act
            int affectedRows = ClassEditarPedido.obtenerCodigoPedido(cadena);

            //Asset
            Assert.AreNotEqual(0, affectedRows);
        }

        /* 
         * Obtener Estado
        * Descripcion:Obtener los atributos de la tabla estado
        */
        [TestMethod]
        public void ObtenerEstado()
        {
            //Arrenge
            DataTable TableEstado = new DataTable();
            int codigo = 1;
            string nombre = "Iniciado";

            int codigo1 = 2;
            string nombre1 = "Completado";
            //Act
            TableEstado = ClassEditarPedido.obtenerEstado();

            //Asset
            Assert.AreEqual(TableEstado.Rows[0][0], codigo);
            Assert.AreEqual(TableEstado.Rows[0][1], nombre);
            Assert.AreEqual(TableEstado.Rows[1][0], codigo1);
            Assert.AreEqual(TableEstado.Rows[1][1], nombre1);


        }

        /* 
         * Colocar estado inicial
        * Descripcion:dar estado inicial al pedido
        */
        [TestMethod]
        public void ValorEstadosIniciales()
        {
            //Arrenge
            int filas_esperadas = 0;

            //Act
            ClassEditarPedido.EstadosInicales();
            int affectedRows = ClassEditarPedido.EstadosInicales(); 

            //Asset
            Assert.AreNotEqual(filas_esperadas, affectedRows);


        }

        /* 
         * Buscar por Codigo factura
        * Descripcion:dar los datos por codigo factura
        */
        [TestMethod]
        public void BuscarPorCodigo()
        {
            //Arrenge
            string buscar = "5" ;
            BuscarEstadoClass.facturaPureba();
            //Act
            DataTable tabla = BuscarEstadoClass.obtenerPedido(buscar);

            //Asset
            Assert.AreEqual(tabla.Rows[0][0], 5);
            Assert.AreEqual(tabla.Rows[0][1], 2987);
            Assert.AreEqual(tabla.Rows[0][2], "Zona 12");
        }

        /* 
         * Obtener producto por Codigo factura
        * Descripcion:dar los datos por codigo factura
        */
        [TestMethod]
        public void DetalleProducto()
        {
            //Arrenge
            int codPedido = 5;
            BuscarEstadoClass.facturaPureba();
            //Act
            DataTable tabla = BuscarEstadoClass.obtenerdetalle(codPedido);

            //Asset
            Assert.AreEqual(tabla.Rows[0][0], "Producto1" );
            Assert.AreEqual(tabla.Rows[0][1], "Detalle1");
            Assert.AreEqual(tabla.Rows[0][2], "100");
        }


    }
}
