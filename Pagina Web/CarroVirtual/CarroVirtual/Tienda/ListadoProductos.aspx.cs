using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace CarroVirtual.Tienda
{
    public partial class Productos : System.Web.UI.Page
    {
        public string busquedaNombre = null;
        public string categoria = null;
        public int pagina = 0;

        public void CargarCategorias()
        {

            List<Categoria> categorias = Gestion_categoria_crud.ObtenerCategorias();

            for (int i = 0; i < categorias.Count; i++)
            {
                Categoria categoria = categorias[i];

                //CREO EL <li>
                HtmlGenericControl li_prueba = new HtmlGenericControl("li");
                li_prueba.Attributes["class"] = "nav-item";

                //CREO EL LINKBUTTON
                LinkButton btn_cat = new LinkButton() { Text = categoria.nombre, CommandArgument=Convert.ToString(categoria.cod_categoria),CssClass = "nav-link" };
                btn_cat.Click += delegate { Click_Btn_Cat(btn_cat, new EventArgs()); };

                //AGREGO AL HTML
                li_prueba.Controls.Add(btn_cat);
                lista_cat.Controls.Add(li_prueba);
            }
            
        }

        protected void Click_Btn_Cat(object sender, EventArgs e)
        {
            categoria = ((LinkButton)sender).Text;
            pagina = 0;

            buscarProductos(busquedaNombre, categoria, ContrMostrarProductos.PAGINACION.PAGINICIAL);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        protected void buscarProductos(string nombre, string categoria, ContrMostrarProductos.PAGINACION paginacion)
        {

            Conexion.categoria = categoria;
            Conexion.juegoBuscar = nombre;

            //BUSCO EL PRODUCTO POR NOMBRE O POR CODIGO
            List<ProductoCarrito> listaProductos = ContrMostrarProductos.BuscarProductos(categoria, nombre, paginacion);

            //SI NO HAY PRODUCTO ES QUE LLEGAMOS AL MAXIMO DE PAGINAS Y VOLVEMOS A COMENZAR
            if (paginacion == ContrMostrarProductos.PAGINACION.ADELANTE && (listaProductos == null || listaProductos.Count <= 0))
            {
                pagina = 0;
                listaProductos = ContrMostrarProductos.BuscarProductos(categoria, nombre, ContrMostrarProductos.PAGINACION.PAGINICIAL);
            }


            this.ListViewCardProducts.DataSource = listaProductos;
            this.ListViewCardProducts.DataBind();

        }

        protected void LinkButtonAll_Click(object sender, EventArgs e)
        {
            categoria = null;
            buscarProductos(busquedaNombre, categoria, 0);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            pagina = 0;
            busquedaNombre = searchText.Text;

            if (busquedaNombre != null && busquedaNombre.Trim().Length <= 0)
                busquedaNombre = null;


            buscarProductos(busquedaNombre, categoria, ContrMostrarProductos.PAGINACION.PAGINICIAL);
        }

        public void Button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(combo_carro.SelectedValue);
            //string b = a.ToString();
            //ShowMessage(b, "Prueba");
        }

        private void ShowMessage(string Message, string Title)
        {
            ScriptManager.RegisterStartupScript(Page, this.GetType(), "alert", string.Format("alert('{1}', '{0}');", Message, Title), true);
        }        

        protected void PREVIOUS_Command(object sender, CommandEventArgs e)
        {

            pagina -= 1;

            if (pagina < 0)
                pagina = 0;

            buscarProductos(Conexion.juegoBuscar, Conexion.categoria, ContrMostrarProductos.PAGINACION.ATRAS);
        }

        protected void NEXT_Command(object sender, CommandEventArgs e)
        {

            pagina += 1;

            buscarProductos(Conexion.juegoBuscar, Conexion.categoria, ContrMostrarProductos.PAGINACION.ADELANTE);
            //ShowMessage((String)e.CommandArgument, (String)e.CommandArgument);
        }        
    }
}