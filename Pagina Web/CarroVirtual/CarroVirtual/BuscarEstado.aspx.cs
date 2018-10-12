using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual.Tienda
{
    public partial class BuscarEstado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Mostrar compras
        protected void buscarPedido(object sender, EventArgs e)
        {
            String buscar = txtbusqueda.Text;
            DataTable dt = BuscarEstadoClass.obtenerPedido(buscar);
           
        }

        //mostrar detalle compras
        protected void Gridview1IndexChanged(object sender, EventArgs e)
        {
            int codPedido = ClassEditarPedido.obtenerCodigoPedido(GridView1.SelectedRow.Cells[1].Text);
            GridView2.DataSource = BuscarEstadoClass.obtenerdetalle(codPedido);
            GridView2.DataBind();
        }
    }
}