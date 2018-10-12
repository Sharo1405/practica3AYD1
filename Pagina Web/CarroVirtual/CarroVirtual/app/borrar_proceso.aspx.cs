using Biblioteca1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _BD1_Proyecto2;

namespace diagrama
{
    public partial class borrar_proceso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (varSesion.codigo_loggeado == 0)
            {
                Response.Redirect("/index.aspx");
            }
            //quitar
            //Session["tipo_proceso"] = 2;
            //fin quitar

            if (!IsPostBack) {

                listar_procesos_por_modulo();
            }
                Session["corregir_borrar_proceso"] = 1;
        }

        private void listar_procesos_por_modulo()
        {
            class_con en = new class_con();

            try
            {



                MySqlConnection cs = new MySqlConnection(en.cadena_con);
                MySqlCommand cd = new MySqlCommand("select * from proceso where modulo_cod_modulo= '" + Session["tipo_proceso"] + "' ; ", cs);
                cs.Open();
                MySqlDataReader ddl = cd.ExecuteReader();

                DropDownList1.DataSource = ddl;
                DropDownList1.DataValueField = "cod_proceso";
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataBind();
                cs.Close();
                //cs.Dispose();



            }
            catch (Exception a)
            {
                Console.Write(a);
            }
        }

        protected void borrar_Click(object sender, EventArgs e)
        {
            try
            {
                metodos1 op = new metodos1();
                op.borrar_proceso(DropDownList1.SelectedItem.Value );

                Session["corregir_borrar_proceso"] = 0;
                Response.Redirect("borrar_proceso.aspx");
            }
            catch (Exception)
            {

                Response.Write("Seleccione un proceso antes de borrar");
            }
        }

        protected void regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/indexUsuario.aspx");
        }
    }
}