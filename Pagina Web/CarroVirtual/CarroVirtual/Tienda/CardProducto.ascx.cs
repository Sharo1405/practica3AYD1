using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual.Tienda
{
    public partial class CardProducto : System.Web.UI.UserControl
    {        
        public ProductoCarrito ProductoCarrito { get; set; }
        public string nombreP { get; set; }
/**
        public CardProducto(ProductoCarrito productoCarrito2)
        {
            LabelNombre.Text = productoCarrito2.nombre;
            LabelPrecio.Text = productoCarrito2.precio + "";
            LabelCategoria.Text = productoCarrito2.categoria;
        }
**/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Solo se llama la primera vez que se carga la página
                Console.WriteLine(nombreP);
            }            
        }
        
        private void ShowMessage(string Message, string Title)
        {
            ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert", string.Format("alert('{1}', '{0}');", Message, Title), true);
        }
        
        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            ShowMessage("Ayuda", (String)e.CommandArgument);
        }
    }
}