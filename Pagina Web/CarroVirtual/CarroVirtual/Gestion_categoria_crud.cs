using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarroVirtual
{
    public class Gestion_categoria_crud
    {
        public static List<Categoria> ObtenerCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("SELECT * FROM categoria", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.cod_categoria = (Int32)reader["cod_categoria"];
                categoria.nombre = (String)reader["nombre"];
                categorias.Add(categoria);
            }
            con.Close();
            return categorias;
        }


        //variables para pruebas bdd
        public String nombreBDD { get; set; }
        public String descripcionBDD { get; set; }

        public String CrearCategoriaBDD()
        {
            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO categoria(nombre, descripcion) " +
                "VALUES('" + nombreBDD + "', '" + descripcionBDD + "'" + ")", con);
            int s = cmd.ExecuteNonQuery();
            con.Close();

            if (s != 0)
            {

                return "true";
            }
            return "false";
        }
        //Fin-variables para pruebas bdd


        public static bool CrearCategoria(Categoria categoria)
        {
            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO categoria(nombre, descripcion) " +
                "VALUES('" + categoria.nombre + "', '" + categoria.descripcion + "'" + ")", con);
            int s = cmd.ExecuteNonQuery();
            con.Close();

            if (s != 0)
            {
                return true;
            }
            return false;
        }

        public static bool ExisteCategoria(Categoria categoria)
        {
            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("SELECT cod_categoria FROM categoria WHERE nombre LIKE '" + 
                categoria.nombre + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        public static DataTable ExisteProductoLista()
        {
            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("SELECT nombre FROM categoria", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                con.Close();
                SqlDataAdapter da = new SqlDataAdapter("SELECT nombre FROM categoria", con);
                DataTable dt;
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            con.Close();
            return null;
        }


        public static bool Eliminar_categoria(String nombre)
        {
            int s = 0;
            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("DELETE categoria WHERE nombre = '" + nombre + "'", con);
            try
            {
                s = cmd.ExecuteNonQuery();
            }
            catch
            {}
            con.Close();
            if (s>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EditarCategoria(Categoria categoria, String nombreActual)
        {
            SqlConnection con = Conexion.ObtenerConexion();
            if (categoria.nombre != "" && categoria.descripcion != "" && nombreActual != "") {
                SqlCommand cmd = new SqlCommand("UPDATE categoria SET nombre = '" + categoria.nombre + "', descripcion = '" + categoria.descripcion + "' WHERE nombre = '" + nombreActual + "';", con);
                int s = cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else if (categoria.nombre != "" && categoria.descripcion == "" && nombreActual != "")
            {
                SqlCommand cmd = new SqlCommand("UPDATE categoria SET nombre = '" + categoria.nombre + "' where nombre = '" + nombreActual + "'", con);
                int s = cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else if (categoria.nombre == "" && categoria.descripcion != "" && nombreActual != "")
            {
                SqlCommand cmd = new SqlCommand("UPDATE categoria SET descripcion = '" + categoria.descripcion + "' where nombre = '" + nombreActual + "'", con);
                int s = cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            return false;
        }
    }
}