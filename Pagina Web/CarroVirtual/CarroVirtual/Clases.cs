using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarroVirtual
{
    public class Clases
    {

    }

    public class Producto
    {
        public int cod_producto { get; set; }
        public String nombre { get; set; }
        public String detalles { get; set; }
        public int precio_venta { get; set; }
        public int cantidad { get; set; }
        public byte[] imagen { get; set; }
        public int categoria_cod_categoria { get; set; }


        public Producto() {
            this.nombre = "";
            this.detalles = "";
            this.precio_venta = 0;
            this.cantidad = 0;
            this.imagen = new byte[1];
            this.categoria_cod_categoria = 0;
        }
    }
    public class Factura
    {
        private string nombre, apellido, zona, dpi,fecha;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Zona { get => zona; set => zona = value; }
        public string Dpi { get => dpi; set => dpi = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
    public class Categoria
    {
        public String nombre { get; set; }
        public int cod_categoria { get; set; }
        public String descripcion { get; set; }

        public Categoria(){
            this.nombre = "";
            this.cod_categoria = 0;
            this.descripcion = "";
        }
    }

    public class ProductoCarrito
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string detalles { get; set; }
        public int precio { get; set; }
        public string imagenURL { get; set; }
        public string categoria { get; set; }

        public int cantidadDisponible { get; set; }
        public int cantidadPedida { get; set; }

        public int subtotal { get; set; }

        public ProductoCarrito()
        {
            this.nombre = "";
            this.detalles = "";
            this.precio = 0;
            this.cantidadDisponible = 0;
            this.cantidadPedida = 0;
            this.subtotal = 0;
            this.imagenURL = "";
            this.categoria = "";
        }
    }


}