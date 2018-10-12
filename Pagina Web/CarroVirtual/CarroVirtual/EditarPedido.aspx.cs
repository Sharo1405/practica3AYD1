using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class EditarPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ClassEditarPedido.EstadosInicales();
        }

        protected void editarPedido(object sender, EventArgs e)
        {
            if (ClassEditarPedido.editarPedido(txtIdFactura.Text, DropDownList1.SelectedValue) != 0)
            {
                Response.Write("Modificado");
                Response.Redirect("EditarPedido.aspx");

            }
            else { Response.Write("Seleccione un Pedido"); }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarPedido();
            int codPedido = ClassEditarPedido.obtenerCodigoPedido(GridView1.SelectedRow.Cells[1].Text);

            txtIdFactura.Text = GridView1.SelectedRow.Cells[1].Text;
            string index = DropDownList1.Items.FindByText(GridView1.SelectedRow.Cells[5].Text).Value;
            DropDownList1.SelectedValue = index;

        }

        private void llenarPedido()
        {
            DataTable dtCategoria = ClassEditarPedido.obtenerEstado();
            DropDownList1.DataSource = dtCategoria;
            DropDownList1.DataTextField = "nombre";
            DropDownList1.DataValueField = "cod_estado";
            DropDownList1.DataBind();
        }
    }
}