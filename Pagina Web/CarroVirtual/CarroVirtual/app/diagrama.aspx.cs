using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _BD1_Proyecto2;
using Biblioteca1;
using _BD1_Proyecto2;
using MySql.Data.MySqlClient;
namespace diagrama.diagrama
{
    public partial class diagrama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (varSesion.codigo_loggeado == 0)
            {
                Response.Redirect("/index.aspx");
            }
            //variables de session
        }

        protected void aceptar_Click1(object sender, EventArgs e)
        {
            crear_diagrama();
        }

        private void crear_diagrama()
        {
            metodos1 a = new metodos1();
            string cadena = (string)HiddenField1.Value;
            System.IO.File.WriteAllText((Server.MapPath("~/app/diagrama/")+"diagram11.txt"), cadena);
            // a.guardar_archivo_xml(cadena);


            Session["consola"] = "";
            string dir = (Server.MapPath("~/app/diagrama/") + "diagram11.txt"); 
            string g = a.guardar_flujo(dir);

            //  Response.Write(Session["consola"]);

            //actualizar datos del proceso

            //proceso actual Session["id_proceso_actual"]


            Session["corregir_proceso_1"] = 0;
            Response.Redirect("actualizar_diagrama_proceso.aspx");




        }




    }
}