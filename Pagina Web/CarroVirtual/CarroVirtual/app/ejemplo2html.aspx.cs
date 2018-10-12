using Biblioteca1;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using _BD1_Proyecto2;

namespace diagrama.app
{
    public partial class ejemplo2html : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (varSesion.codigo_loggeado == 0)
            {
                Response.Redirect("/index.aspx");
            }
            llenar_lista_proceso();
   
        }

        private void llenar_lista_proceso()
        {
            class_con en = new class_con();

            try
            {

                DropDownList1.Items.Clear();
                DropDownList1.SelectedIndex = 0;

            MySqlConnection cs = new MySqlConnection(en.cadena_con);
            MySqlCommand cd = new MySqlCommand("SELECT cod_proceso,nombre FROM proceso", cs);
            cs.Open();
            MySqlDataReader ddl = cd.ExecuteReader();

            DropDownList1.DataSource = ddl;
            DropDownList1.DataValueField = "cod_proceso";
            DropDownList1.DataTextField = "nombre";
            DropDownList1.DataBind();
            cs.Close();
            cs.Dispose();



             }
                catch (Exception)
             {

              }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}