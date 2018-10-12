using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual.Tienda
{
    public partial class ListadoCarrito : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
            buscarProductos();
        }

        protected void buscarProductos()
        {
            //BUSCO EL PRODUCTO
            List<ProductoCarrito> listaProductos = ContrMostrarProductos.BuscarProductCar();

            this.ListViewCardProducts.DataSource = listaProductos;
            this.ListViewCardProducts.DataBind();

        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            List<ProductoCarrito> listaProductos = ContrMostrarProductos.BuscarProductCar();
            CompletarCompra.productos = listaProductos;
            ContrMostrarProductos.VaciarCarro();
            Response.Redirect("../CompletarCompra.aspx");
        }        
    }
}