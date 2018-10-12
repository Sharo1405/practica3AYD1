using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual.Tienda
{
    public partial class CardCarrito : System.Web.UI.UserControl
    {
        public ProductoCarrito ProductCarrito { get; set; }
        public string nombreP { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Console.WriteLine(nombreP);
        }
    }
}