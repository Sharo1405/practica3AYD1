using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarroVirtual;
using System.Collections.Generic;
using System.Data;


namespace Pruebas
{
    [TestClass]
    public class TestCarro
    {
        //Búsqueda por código
        [TestMethod]
        public void CarroPorCodigo()
        {
            //Arrenge
            List<ProductoCarrito> listaProductos;
            int cod = 0;
            int codigo = 3;

            //Act
            listaProductos = CarroVirtual.Tienda.ContrMostrarProductos.BuscarProductCar();

            for(int i = 0; i<listaProductos.Count; i++)
            {
                cod = listaProductos[i].codigo;
                if (cod == codigo)
                {
                    //Assert
                    Assert.AreEqual(cod,codigo);
                }                
            }            
        }

        //Búsqueda por categoría
        [TestMethod]
        public void CarroPorCategoria()
        {
            //Arrenge
            List<ProductoCarrito> listaProductos;
            string cat = "";
            string categoria = "PS4";

            //Act
            listaProductos = CarroVirtual.Tienda.ContrMostrarProductos.BuscarProductCar();

            for (int i = 0; i < listaProductos.Count; i++)
            {
                cat = listaProductos[i].categoria;
                if (cat == categoria)
                {
                    //Assert
                    Assert.AreEqual(cat, categoria);
                }
            }
        }

        //Búsqueda por precio
        [TestMethod]
        public void CarroPorPrecio()
        {
            //Arrenge
            List<ProductoCarrito> listaProductos;
            int price = 0;
            int precio = 420;            

            //Act
            listaProductos = CarroVirtual.Tienda.ContrMostrarProductos.BuscarProductCar();

            for (int i = 0; i < listaProductos.Count; i++)
            {
                price = listaProductos[i].precio;
                //MessageBox.Show(price, "Precio", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (price == precio)
                {
                    //Assert
                    Assert.AreEqual(price, precio);
                }
            }
        }

        //Búsqueda por cantidad
        [TestMethod]
        public void CarroPorCantidad()
        {
            //Arrenge
            List<ProductoCarrito> listaProductos;
            int cant = 0;
            int cantidad = 3;

            //Act
            listaProductos = CarroVirtual.Tienda.ContrMostrarProductos.BuscarProductCar();

            for (int i = 0; i < listaProductos.Count; i++)
            {
                cant = listaProductos[i].cantidadDisponible;
                if (cant == cantidad)
                {
                    //Assert
                    Assert.AreEqual(cant, cantidad);
                }
            }
        }

        //Búsqueda por nombre
        [TestMethod]
        public void CarroPorNombre()
        {
            //Arrenge
            List<ProductoCarrito> listaProductos;
            string name = "";
            string nombre = "TheLifeOfKlose";

            //Act
            listaProductos = CarroVirtual.Tienda.ContrMostrarProductos.BuscarProductCar();

            for (int i = 0; i < listaProductos.Count; i++)
            {
                name = listaProductos[i].nombre;
                if (name == nombre)
                {
                    //Assert
                    Assert.AreEqual(name, nombre);
                }
            }            
        }

        //Búsqueda por codigo
        [TestMethod]
        public void CarroPorNCodigo()
        {
            //Arrenge
            List<ProductoCarrito> listaProductos;
            int cod = 0;
            int codigo = 5;

            //Act
            listaProductos = CarroVirtual.Tienda.ContrMostrarProductos.BuscarProductCar();

            for (int i = 0; i < listaProductos.Count; i++)
            {
                cod = listaProductos[i].codigo;
                if (cod == codigo)
                {
                    //Assert
                    Assert.AreEqual(cod, codigo);
                }
            }
            Assert.Fail();
        }

        //Búsqueda por categoría
        [TestMethod]
        public void CarroPorNCategoria()
        {
            //Arrenge
            List<ProductoCarrito> listaProductos;
            string cat = "";
            string categoria = "PS1";

            //Act
            listaProductos = CarroVirtual.Tienda.ContrMostrarProductos.BuscarProductCar();

            for (int i = 0; i < listaProductos.Count; i++)
            {
                cat = listaProductos[i].categoria;                
                if (cat == categoria)
                {
                    //Assert
                    Assert.AreEqual(cat, categoria);
                }
            }
            Assert.Fail();
        }
    }
}
