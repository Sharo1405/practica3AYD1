using System;
using System.Data;
using System.Data.SqlClient;

namespace CarroVirtual
{
    public class ClassEditarPedido
    {
        //obtener los datos de la tabla Estado 
        public static DataTable obtenerEstado()
        {
            String cmd = "SELECT cod_estado, nombre FROM EstadoPedido";

            //RETORNO LOS DATOS
            SqlDataAdapter da = new SqlDataAdapter(cmd, Conexion.cadenaConexion);
            DataTable dt;
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static int EstadosInicales()
        {
            SqlConnection con = Conexion.ObtenerConexion();
            //Comando
            SqlCommand cmd = new SqlCommand("update factura set estado = 1" +
                                            "where estado is null; ", con);

            int affectedRows = cmd.ExecuteNonQuery();
            con.Close();

            return affectedRows;

        }

        public static string obtenerFacturaPrueba()
        {
            string id = "0";

            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand(" select Top 1 cod_factura from factura order by cod_factura asc;", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                id = reader.GetInt32(0).ToString();


            }
            con.Close();

            return id;
        }

        //modificar el estado de un pedido
        public static int editarPedido(string codigo, string estado)
        {

            SqlConnection con = Conexion.ObtenerConexion();
            //Comando
            SqlCommand cmd = new SqlCommand("update factura set Estado = @ESTADO " +
                                            "where cod_factura = @CODFACTURA; ", con);
            cmd.Parameters.AddWithValue("@CODFACTURA", codigo);
            cmd.Parameters.AddWithValue("@ESTADO", estado);

            int affectedRows = cmd.ExecuteNonQuery();
            con.Close();

            return affectedRows;

        }

        public static int obtenerCodigoPedido(string text)
        {
            int codPedido = 0;
            try
            {
                codPedido = Convert.ToInt32(text);
            }
            catch
            {

            }
            return codPedido;
        }
    }
}