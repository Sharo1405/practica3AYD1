using Biblioteca1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _BD1_Proyecto2;

namespace diagrama.app
{
    public partial class diagrama_mod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (varSesion.codigo_loggeado == 0)
            {
                Response.Redirect("/index.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("modificar_proceso.aspx");
        }

        protected void aceptar_Click(object sender, EventArgs e)
        {
            mod_diagrama();
        }

        private void mod_diagrama()
        {
            metodos1 a = new metodos1();
            string cadena = (string)HiddenField1.Value;
            System.IO.File.WriteAllText((Server.MapPath("~/app/diagrama/") + "diagram11.txt"), cadena);
            // a.guardar_archivo_xml(cadena);
            Session["mostrar2"] = "-- --";

            Session["consola"] = "";
            string dir = (Server.MapPath("~/app/diagrama/") + "diagram11.txt");
            string g = a.guardar_flujo_mod(dir);




            // Response.Write(Session["mostrar2"]);
            Session["corregir_proceso_1"] = 0;
            Response.Redirect("actualizar_diagrama_proceso.aspx");
        }
    }
}