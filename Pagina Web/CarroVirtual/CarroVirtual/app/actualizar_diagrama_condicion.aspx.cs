using Biblioteca1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _BD1_Proyecto2;

namespace diagrama.app.diagrama
{
    public partial class actualizar_diagrama_condicion : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (varSesion.codigo_loggeado == 0)
            {
                Response.Redirect("/index.aspx");
            }
            //   Session["id_proceso_actual"] = 28;

            if ((int)Session["corregir_condicion1"] == 0)
            {
                //llenar droplist
             llenar_lista_condicion();


            }
            Session["corregir_condicion1"] = 1;
        }

        private void llenar_lista_condicion()
        {
            class_con en = new class_con();

            try
            {



                MySqlConnection cs = new MySqlConnection(en.cadena_con);
                MySqlCommand cd = new MySqlCommand("select o.cod_opcion, o.descripcion,o.valor,o.nombre,c.cod_grafico " +
                    " from condicion as c ,etapa as e,opcion as o  where e.cod_etapa = c.etapa_cod_viene  and "+
                    " o.cod_opcion = c.opcion_cod_opcion  and   o.cod_opcion <> 1 and    "+
                    " e.proceso_cod_proceso = '"+ Session["id_proceso_actual"] + "'   group by c.cod_grafico  ; ", cs);
                cs.Open();
                MySqlDataReader ddl = cd.ExecuteReader();

                DropDownList1.DataSource = ddl;
                DropDownList1.DataValueField = "cod_grafico";
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

        protected void cargar_condicion_Click(object sender, EventArgs e)
        {
            class_con en = new class_con();

            try
            {



                MySqlConnection cs = new MySqlConnection(en.cadena_con);
                MySqlCommand cd = new MySqlCommand("select o.cod_opcion, o.descripcion,o.valor,o.nombre,o.valor,c.cod_grafico " +
                    " from condicion as c ,etapa as e,opcion as o  where e.cod_etapa = c.etapa_cod_viene  and " +
                    " o.cod_opcion = c.opcion_cod_opcion  and   o.cod_opcion <> 1 and    " +
                    " e.proceso_cod_proceso = '" + Session["id_proceso_actual"] + "'   and c.cod_grafico='"+ DropDownList1.SelectedItem.Value + "' ; ", cs);

                cs.Open();
                MySqlDataReader dr = cd.ExecuteReader();

                Console.Write(DropDownList1.SelectedItem.Value);

                descripcion.Text = "";
                valor.Text = "";
                while (dr.Read()) {
                    nombre_etapa.Text = (string)dr["nombre"];
                    descripcion.Text = (string)dr["descripcion"];
                    valor.Text = (string)dr["valor"];

                }
               
                cs.Close();
                



            }
            catch (Exception a)
            {
                Console.Write(a);
            }
        }

        protected void actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                metodos1 op = new metodos1();
                op.actualizar_datos_condicion(DropDownList1.SelectedItem.Value, ""+Session["id_proceso_actual"], nombre_etapa.Text, descripcion.Text,valor.Text);

                Session["corregir_condicion1"] = 0;
                 Response.Redirect("actualizar_diagrama_condicion.aspx");
            }
            catch (Exception)
            {
                
                Response.Write("Carge una condicion antes de actualizar");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/indexUsuario.aspx");
        }
    }
}