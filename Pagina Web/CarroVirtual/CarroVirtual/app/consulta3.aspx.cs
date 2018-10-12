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
    public partial class consulta3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        private void llenar_tabla()
        {
            class_con en = new class_con();

            // try
            // {

            DateTime fecha1 = DateTime.Parse(fecha_inicial.Text);
            DateTime fecha2 = DateTime.Parse(fecha_fin.Text);

            MySqlConnection cs = new MySqlConnection(en.cadena_con);
            MySqlCommand cd = new MySqlCommand("call consulta3('"+ fecha1.ToString("yyyy-MM-dd") + "','"+ fecha2.ToString("yyyy-MM-dd") + "');", cs);
            cs.Open();
            MySqlDataReader ddl = cd.ExecuteReader();

            GridView1.DataSource = ddl;
            // GridView1.Data

            GridView1.DataBind();
            cs.Close();
        }

        protected void volver_Click(object sender, EventArgs e)
        {

        }

        protected void cargar_Datos_Click(object sender, EventArgs e)
        {

        }

        protected void consulta_Click(object sender, EventArgs e)
        {
            llenar_tabla();
        }
    }
}