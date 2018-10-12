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
    public partial class consulta2 : System.Web.UI.Page
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
                MySqlCommand cd = new MySqlCommand("select * from modulo; ", cs);
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

        protected void por_fecha_Click(object sender, EventArgs e)
        {
            por_fecha1();
        }

        private void por_fecha1()
        {
            class_con en = new class_con();

            // try
            // {

            DateTime fecha1 = DateTime.Parse(fecha_inicial.Text);
            DateTime fecha2 = DateTime.Parse(fecha_fin.Text);

            MySqlConnection cs = new MySqlConnection(en.cadena_con);
            MySqlCommand cd = new MySqlCommand("call consulta2_2('" + fecha1.ToString("yyyy-MM-dd") + "','" + fecha2.ToString("yyyy-MM-dd") + "');", cs);
            cs.Open();
            MySqlDataReader ddl = cd.ExecuteReader();

            GridView1.DataSource = ddl;
            // GridView1.Data

            GridView1.DataBind();
            cs.Close();
        }

        protected void por_no_Click(object sender, EventArgs e)
        {

        }

        protected void volver_Click(object sender, EventArgs e)
        {

        }

        protected void modulo_Click(object sender, EventArgs e)
        {
            solo_modulo();
        }

        private void solo_modulo()
        {
            class_con en = new class_con();

            // try
            // {


            MySqlConnection cs = new MySqlConnection(en.cadena_con);
            MySqlCommand cd = new MySqlCommand("call consulta2_1('"+DropDownList1.SelectedItem.Value+"');", cs);
            cs.Open();
            MySqlDataReader ddl = cd.ExecuteReader();

            GridView1.DataSource = ddl;
            // GridView1.Data

            GridView1.DataBind();
            cs.Close();
        }

        protected void top10_Click(object sender, EventArgs e)
        {
            class_con en = new class_con();

            // try
            // {


            MySqlConnection cs = new MySqlConnection(en.cadena_con);
            MySqlCommand cd = new MySqlCommand("call consulta2_3();", cs);
            cs.Open();
            MySqlDataReader ddl = cd.ExecuteReader();

            GridView1.DataSource = ddl;
            // GridView1.Data

            GridView1.DataBind();
            cs.Close();
        }

        protected void B1y2_Click(object sender, EventArgs e)
        {
            class_con en = new class_con();

            // try
            // {
            DateTime fecha1 = DateTime.Parse(fecha_inicial.Text);
            DateTime fecha2 = DateTime.Parse(fecha_fin.Text);

            MySqlConnection cs = new MySqlConnection(en.cadena_con);
            MySqlCommand cd = new MySqlCommand("call consulta2_4('"+DropDownList1.SelectedItem.Value+"'  ,'" + fecha1.ToString("yyyy-MM-dd") + "','" + fecha2.ToString("yyyy-MM-dd") + "');", cs);
            cs.Open();
            MySqlDataReader ddl = cd.ExecuteReader();

            GridView1.DataSource = ddl;
            // GridView1.Data

            GridView1.DataBind();
            cs.Close();
        }

        protected void B2y3_Click(object sender, EventArgs e)
        {
            cargar_rango_top();
        }

        private void cargar_rango_top()
        {
            class_con en = new class_con();

            // try
            // {
            DateTime fecha1 = DateTime.Parse(fecha_inicial.Text);
            DateTime fecha2 = DateTime.Parse(fecha_fin.Text);

            MySqlConnection cs = new MySqlConnection(en.cadena_con);
            MySqlCommand cd = new MySqlCommand("call consulta2_5('" + fecha1.ToString("yyyy-MM-dd") + "','" + fecha2.ToString("yyyy-MM-dd") + "');", cs);
            cs.Open();
            MySqlDataReader ddl = cd.ExecuteReader();

            GridView1.DataSource = ddl;
            // GridView1.Data

            GridView1.DataBind();
            cs.Close();
        }

        protected void B1y3_Click(object sender, EventArgs e)
        {
            class_con en = new class_con();

            // try
            // {
      

            MySqlConnection cs = new MySqlConnection(en.cadena_con);
            MySqlCommand cd = new MySqlCommand("call consulta2_6('" +DropDownList1.SelectedItem.Value+ "');", cs);
            cs.Open();
            MySqlDataReader ddl = cd.ExecuteReader();

            GridView1.DataSource = ddl;
            // GridView1.Data

            GridView1.DataBind();
            cs.Close();
        }

        protected void B1y2y3_Click(object sender, EventArgs e)
        {
            todos_los_parametos();
        }

        private void todos_los_parametos()
        {
            class_con en = new class_con();

            // try
            // {
            DateTime fecha1 = DateTime.Parse(fecha_inicial.Text);
            DateTime fecha2 = DateTime.Parse(fecha_fin.Text);

            MySqlConnection cs = new MySqlConnection(en.cadena_con);
            MySqlCommand cd = new MySqlCommand("call consulta2_7('"+DropDownList1.SelectedItem.Value+"','" + fecha1.ToString("yyyy-MM-dd") + "','" + fecha2.ToString("yyyy-MM-dd") + "');", cs);
            cs.Open();
            MySqlDataReader ddl = cd.ExecuteReader();

            GridView1.DataSource = ddl;
            // GridView1.Data

            GridView1.DataBind();
            cs.Close();
        }
    }
}