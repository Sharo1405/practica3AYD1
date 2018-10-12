using System;
using System.Data;
using System.Data.SqlClient;

namespace CarroVirtual.Tienda
{
    public class BuscarEstadoClass
    {
        //obtener pedido por su codigo
        public static DataTable obtenerPedido(string buscar)
        {
            
            String cmd = "SELECT [cod_factura],[DPI],[zona_entrega],[fecha],[Estado]" +
                "FROM Factura where cod_factura like '%"+buscar+"%';";

            //RETORNO LOS DATOS
            SqlDataAdapter da = new SqlDataAdapter(cmd, Conexion.cadenaConexion);
            DataTable dt;
            dt = new DataTable();
            da.Fill(dt);
            return dt;



        }

        public static DataTable obtenerdetalle(int codPedido)
        {
            String cmd = "select p.nombre,p.detalles,p.precio_venta as Precio from  detalle_factura as d, producto as p " +
                         "where d.detalle_cod_factura = '"+codPedido+"' and d.producto_cod_producto = p.cod_producto; ";

            //RETORNO LOS DATOS
            SqlDataAdapter da = new SqlDataAdapter(cmd, Conexion.cadenaConexion);
            DataTable dt;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void facturaPureba()
        {
            try
            {
                SqlConnection con = Conexion.ObtenerConexion();
                //Comando
                SqlCommand cmd = new SqlCommand("SET IDENTITY_INSERT Factura on; " +
                    " INSERT INTO Factura(cod_factura,Nombre,Apellido,DPI,zona_entrega,fecha,Estado) " +
                    "  VALUES('5', 'Juan', 'Lima', '2987', 'Zona 12', '2018-09-23', '1') " +
                    " SET Factura off; ", con);


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch {

            }
        }
    }
}