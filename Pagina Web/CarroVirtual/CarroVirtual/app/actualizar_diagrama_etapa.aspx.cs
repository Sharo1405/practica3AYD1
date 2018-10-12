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
    public partial class actualizar_diagrama_etapa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (varSesion.codigo_loggeado == 0)
            {
                Response.Redirect("/index.aspx");
            }
            //variables session pruebas (quitar)
            // Session["id_proceso_actual"] = 1;


            if (Session["corregir_1_act"] == null || (int)Session["corregir_1_act"] == 0) {
                //llenar droplist
                llenar_lista_proceso();
                llenar_lista_usuarios();

            }
            Session["corregir_1_act"] = 1;
           
        }

        private void llenar_lista_usuarios()
        {
            class_con en = new class_con();

           // try
           // {



                MySqlConnection cs = new MySqlConnection(en.cadena_con);
                MySqlCommand cd = new MySqlCommand("select a.cod_usuario,a.nombre,b.permiso_cod_permiso from usuario as a,detalle_up as b "+
                                                "    where a.cod_usuario = b.usuario_cod_usuario and b.permiso_cod_permiso = 3 and modulo_cod_modulo = "+varSesion.codigo_moduloLoggeado+"", cs);
                cs.Open();
                 MySqlDataReader ddl = cd.ExecuteReader();

                DropDownList2.DataSource = ddl;
                DropDownList2.DataValueField = "cod_usuario";
                DropDownList2.DataTextField = "nombre";
                DropDownList2.DataBind();
                cs.Close();
                cs.Dispose();



           // }
           // catch (Exception)
           // {

           // }
        }

        private void llenar_lista_proceso()
        {
            class_con en = new class_con();

            try
            {

          

                MySqlConnection cs = new MySqlConnection(en.cadena_con);
                MySqlCommand cd = new MySqlCommand("SELECT * FROM etapa where tipo_etapa_cod_tipo = 2 "+
                    "  and proceso_cod_proceso= '"+ Session["id_proceso_actual"] + "' group by cod_grafico;", cs);
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

        protected void cargar_etapa_Click(object sender, EventArgs e)
        {
           // Response.Write("--"+DropDownList1.SelectedItem.Text);
              nombre_etapa.Text = DropDownList1.SelectedItem.Text;


        }

        protected void actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                metodos1 op = new metodos1();
                op.actualizar_datos_etapa(DropDownList1.SelectedItem.Value, nombre_etapa.Text, DropDownList2.SelectedItem.Value, (int)Session["id_proceso_actual"]);
                Session["corregir_1_act"] = 0;
                Response.Redirect("actualizar_diagrama_etapa.aspx");
            }
            catch {
                Response.Write("Carge una etapa antes de actualizar");
            }
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Session["corregir_diagrama_timer"] = 0;
            Response.Redirect("actualizar_diagrama_timer.aspx");
        }

        protected void volver_Click(object sender, EventArgs e)
        {


            Session["corregir_proceso_1"] = 0;
            Response.Redirect("actualizar_diagrama_proceso.aspx");
        }
    }
}