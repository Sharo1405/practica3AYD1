using Biblioteca1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _BD1_Proyecto2;

namespace diagrama.app
{
    public partial class actualizar_diagrama_timer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (varSesion.codigo_loggeado == 0)
            {
                Response.Redirect("/index.aspx");
            }

            if ((int)Session["corregir_diagrama_timer"] == 0) {
                cargar_timers();
            }
            Session["corregir_diagrama_timer"] = 1;
        }

        private void cargar_timers()
        {
            class_con en = new class_con();

            try
            {



                MySqlConnection cs = new MySqlConnection(en.cadena_con);
                MySqlCommand cd = new MySqlCommand("SELECT * FROM etapa where tipo_etapa_cod_tipo = 4 " +
                    "  and proceso_cod_proceso= '" + Session["id_proceso_actual"] + "' group by cod_grafico;", cs);
                cs.Open();
                MySqlDataReader ddl = cd.ExecuteReader();

                DropDownList1.DataSource = ddl;
                DropDownList1.DataValueField = "cod_grafico";
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataBind();
                cs.Close();
                //cs.Dispose();



            }
            catch (Exception)
            {

            }
        }

        protected void actualizar_Click(object sender, EventArgs e)
        {
            //DateTime fecha_var= DateTime.Parse(fecha.Text);

            // Response.Write(fecha_var.ToString("yyyy-MM-dd") );
            if (fecha.Text == hora.Text)
            {
                Response.Write("Ingrese uno fecha o una hora");

            }
            else {
                if (fecha.Text != "" && hora.Text != "")
                {
                    Response.Write("ingrese una fecha o una hora, no ambas!!");

                }
                else {
                    if (fecha.Text != "")
                    {
                        try
                        {
                            metodos1 op = new metodos1();
                            DateTime fecha_var = DateTime.Parse(fecha.Text);

                            op.actualizar_datos_timer(DropDownList1.SelectedItem.Value, fecha_var.ToString("yyyy-MM-dd"), 0,(int)Session["id_proceso_actual"]);
                            Session["corregir_diagrama_timer"] = 0;
                           Response.Redirect("actualizar_diagrama_timer.aspx");
                        }
                       catch
                        {
                            Response.Write("Carge una dato antes actualizar");
                        }
                       // Response.Write("--" + fecha.Text);
                    }
                    else {
                        // agregar hora
                        try
                        {
                            metodos1 op = new metodos1();


                            op.actualizar_datos_timer(DropDownList1.SelectedItem.Value, hora.Text, 1, (int)Session["id_proceso_actual"]);
                            Session["corregir_1_act"] = 0;
                            // Response.Redirect("actualizar_diagrama_etapa.aspx");
                        }
                        catch
                        {
                            Response.Write("Carge una dato antes actualizar");
                        }
                    }
                    
                  
                }
            

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["corregir_condicion1"]= 0;
            Response.Redirect("actualizar_diagrama_condicion.aspx");
        }
    }
}