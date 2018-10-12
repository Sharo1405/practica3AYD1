using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class BaseAdmin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Conexion.inicioSesion)
            {
                Response.Redirect("Login_Admin.aspx");
            }
        }

        protected void lbl_registrarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrarProducto.aspx");
        }

        protected void lbl_eliminarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("eliminarProducto.aspx");
        }

        protected void lbl_editarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("editarProducto.aspx");
        }


        protected void crear_categoria(object sender, EventArgs e)
        {
            Response.Redirect("Crear_categoria.aspx");
        }

        protected void eliminar_categoria(object sender, EventArgs e)
        {
            Response.Redirect("Eliminar_categoria.aspx");
        }

        protected void editar_categoria(object sender, EventArgs e)
        {
            Response.Redirect("Editar_categoria.aspx");
        }

        protected void lbl_EditarPedido_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditarPedido.aspx");
        }
    }
}