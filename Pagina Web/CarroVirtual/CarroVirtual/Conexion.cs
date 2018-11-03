using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;

namespace CarroVirtual
{
    public class Conexion

    {
        public static String cadenaConexion = "Server=tcp:ayd.database.windows.net,1433;Initial Catalog = p2; Persist Security Info=False;User ID =ayd; Password=bddGrupo7; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";                
        public static int pagina;
        public static Boolean inicioSesion = false;
        internal static string juegoBuscar;
        internal static string categoria;

        //<======================= CONEXION A LA BASE DE DATOS ===========================================
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection con = new SqlConnection(cadenaConexion);
            con.Open();
            return con;
        }

        //<======================= MENSAJES EMERGENTES ===================================================
        public static void MsgBox(String ex, Page pg, Object obj)
        {
            string s = "<SCRIPT language='javascript'>alert('" + ex.Replace("\r\n", "\\n").Replace("'", "") + "'); </SCRIPT>";
            Type cstype = obj.GetType();
            ClientScriptManager cs = pg.ClientScript;
            cs.RegisterClientScriptBlock(cstype, s, s.ToString());
        }
    }
}