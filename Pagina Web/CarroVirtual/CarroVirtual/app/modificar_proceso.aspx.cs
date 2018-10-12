using _BD1_Proyecto2;
using Biblioteca1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diagrama.app
{
    public partial class modificar_proceso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (varSesion.codigo_loggeado == 0)
            {
                Response.Redirect("/index.aspx");
            }
            //quitar 
            // Session["tipo_proceso"] = 2;
            //fin quitar

            if (!IsPostBack)
            {
                listar_procesos_por_modulo();
            }
            
            Session["corregir_modificar_proceso"] = 1;
            
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

        protected void actualizar_Click(object sender, EventArgs e)
        {
            //escribir el xml del grafico


            class_con en = new class_con();

            try
            {


               
                MySqlConnection cs = new MySqlConnection(en.cadena_con);
                MySqlCommand cd = new MySqlCommand("select * from proceso where cod_proceso= '" + DropDownList1.SelectedItem.Value + "' ; ", cs);
                cs.Open();
                MySqlDataReader dr = cd.ExecuteReader();

                while (dr.Read()) {
                    byte[] arr = (byte[])dr["stringXML"];
                    Session["id_proceso_actual"] = (int)dr["cod_proceso"];

                    System.IO.File.WriteAllBytes((Server.MapPath("~/app/diagrama/") + "diagrama_mod.txt"), arr);


                }

                cs.Close();
                //cs.Dispose();
                // Response.Write("<script>window.alert('Password: " + DropDownList1.SelectedItem.Value + "')</script>");
                Session["corregir_modificar_proceso"] = 0;
                Response.Redirect("diagrama_mod.aspx");

            }
            catch (Exception a)
            {
                Console.Write(a);
            }

        }

        protected void btn_regresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("/indexUsuario.aspx");
        }
    }
}