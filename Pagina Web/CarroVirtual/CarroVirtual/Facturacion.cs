using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarroVirtual
{
    public class Facturacion
    {
        public static List<ProductoCarrito> productos;

        public static int RealizarCompra(Factura factura, List<ProductoCarrito> productos)
        {
            int s = 0;
            if (productos.Count > 0 && factura.Nombre!="" && factura.Apellido!="" && factura.Dpi!="" &&factura.Zona!="")
            {
                SqlConnection con = Conexion.ObtenerConexion();
                SqlCommand cmd = new SqlCommand("INSERT INTO Factura(Nombre,Apellido,DPI,zona_entrega,fecha,estado) VALUES('" + factura.Nombre + "', '" + factura.Apellido + "', '" + factura.Dpi + "', '" + factura.Zona + "','" + factura.Fecha + "',1)", con);
                s = cmd.ExecuteNonQuery();
                con.Close();

                con = Conexion.ObtenerConexion();
                cmd = new SqlCommand("SELECT cod_factura FROM factura where Nombre='" + factura.Nombre + "' and Apellido='" + factura.Apellido + "' and DPI='" + factura.Dpi + "' and zona_entrega='" + factura.Zona + "' and fecha ='" + factura.Fecha + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                int codigo = -1;
                s = reader.VisibleFieldCount;
                while (reader.Read())
                {
                    codigo = reader.GetInt32(0);
                    s = codigo;
                }
                con.Close();


                if (codigo > 0)
                {
                    for (int i = 0; i < productos.Count; i++)
                    {
                        ProductoCarrito producto = productos.ElementAt(i);
                        con = Conexion.ObtenerConexion();
                        cmd = new SqlCommand("INSERT INTO detalle_factura (detalle_cod_factura, producto_cod_producto) VALUES(" + codigo + "," + producto.codigo + ")", con);
                        s = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                    s = 0;

            }
            return s;
        }
    }
}