using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CarroVirtual.Tienda
{
    public class ContrComentario
    {
        public static List<Comentario> ObtenerComentarios()
        {
            List<Comentario> comentarios = new List<Comentario>();

            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("select * from comentario", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Comentario comentario = new Comentario();
                comentario.cod_comentario = Convert.ToInt32(reader["IdComentario"].ToString());
                comentario.comentario = reader["contenido"].ToString();
                comentario.nombre = reader["nombre"].ToString();
                comentarios.Add(comentario);
            }

            return comentarios;
        }

        public static bool CrearComentario(Comentario comen)
        {
            SqlConnection con = Conexion.ObtenerConexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO comentario(nombre, contenido) VALUES('" + comen.nombre + "','" + comen.comentario + "')", con);
            int s = cmd.ExecuteNonQuery();
            con.Close();
            if (s != 0)
            {
                return true;
            }
            return false;
        }
    }
}