using _BD1_Proyecto2;
using Biblioteca1;
using MySql.Data.MySqlClient;
using System;

namespace diagrama.app
{
    public partial class actualizar_diagrama_proceso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (varSesion.codigo_loggeado == 0)
            {
                Response.Redirect("/index.aspx");
            }

            if ((int)Session["corregir_proceso_1"] == 0) {
                dar_Datos_proceso();
            }
            Session["corregir_proceso_1"] = 1;
        }

        private void dar_Datos_proceso()
        {
            nombre_etapa.Text = (string)Session["nombre_proceso_usar"];

            class_con en = new class_con();

            try
            {
                MySqlConnection cs = new MySqlConnection(en.cadena_con);
                MySqlCommand cd = new MySqlCommand("select * from tipo_proceso ", cs);
                cs.Open();
                MySqlDataReader ddl = cd.ExecuteReader();

                DropDownList1.DataSource = ddl;
                DropDownList1.DataValueField = "cod_tipo";
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataBind();
                cs.Close();
            }
            catch (Exception)
            {

            }
        }

        protected void actualizar_Click(object sender, EventArgs e)
        {
            metodos1 op = new metodos1();

            DateTime val2 = DateTime.Parse(fechan.Text);

            op.actualizar_datos_proceso((int)Session["id_proceso_actual"],nombre_etapa.Text,descripcion.Text,DropDownList1.SelectedItem.Value,val2);


            //ir a etapas a agregar info

            Session["corregir_1_act"] = 0;
            Response.Redirect("actualizar_diagrama_etapa.aspx");
        }
    }
}