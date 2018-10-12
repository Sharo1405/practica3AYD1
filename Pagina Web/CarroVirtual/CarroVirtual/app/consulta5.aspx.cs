using Biblioteca1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace diagrama.app.diagrama
{
    public partial class consult5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargar_modulos();
            }
        }

        private void cargar_modulos()
        {
            class_con en = new class_con();

            try
            {



                MySqlConnection cs = new MySqlConnection(en.cadena_con);
                MySqlCommand cd = new MySqlCommand("select * from modulo;", cs);
                cs.Open();
                MySqlDataReader ddl = cd.ExecuteReader();

                DropDownList1.DataSource = ddl;
                DropDownList1.DataValueField = "cod_modulo";
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataBind();
                cs.Close();
                //cs.Dispose();



            }
            catch (Exception)
            {

            }
        }

        protected void cargar_Datos_Click(object sender, EventArgs e)
        {
            llenar_grid_view();
        }

        private void llenar_grid_view()
        {
            class_con en = new class_con();

            // try
            // {



            MySqlConnection cs = new MySqlConnection(en.cadena_con);
            MySqlCommand cd = new MySqlCommand("call consulta5('"+DropDownList2.SelectedItem.Value+"');", cs);
            cs.Open();
            MySqlDataReader ddl = cd.ExecuteReader();

            GridView1.DataSource = ddl;
            // GridView1.Data

            GridView1.DataBind();
            
        }

        private void cargar_proceso()
        {
            class_con en = new class_con();

            //try
            //{



                MySqlConnection cs = new MySqlConnection(en.cadena_con);
                MySqlCommand cd = new MySqlCommand("select * from proceso where modulo_cod_modulo= '" + DropDownList1.SelectedItem.Value + "';", cs);
                cs.Open();
                MySqlDataReader ddl = cd.ExecuteReader();

                DropDownList2.DataSource = ddl;
                DropDownList2.DataValueField = "cod_proceso";
                DropDownList2.DataTextField = "nombre";
                DropDownList2.DataBind();
                cs.Close();
            //cs.Dispose();

            Console.Write(DropDownList1.SelectedItem.Value);

            //}
            //catch (Exception)
            //{

            //}
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           // Response.Redirect("consulta5.aspx");
        }

        protected void volver_Click(object sender, EventArgs e)
        {

        }

        protected void cargar_m_Click(object sender, EventArgs e)
        {
            cargar_proceso();
        }
    }
}