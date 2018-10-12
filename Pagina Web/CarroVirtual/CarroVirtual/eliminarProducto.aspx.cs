using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class eliminarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            //BUSCO EL PRODUCTO POR NOMBRE O POR CODIGO
            Producto producto = ContrProductos.BuscarProducto(txt_buscar.Text);

            //MUESTRO LOS VALORES OBTENIDOS
            txt_codigo.Text = producto.cod_producto.ToString();
            txt_nombre.Text = producto.nombre;
            try { combo_categoria.SelectedValue = producto.categoria_cod_categoria.ToString(); } catch (Exception) { }
            CambiarImagen();
        }

        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            //OBTENGO EL PRODUCTO SELECCIONADO
            int cod_producto;
            try
            {
                cod_producto = Convert.ToInt32(txt_codigo.Text);
            }
            catch (Exception)
            {
                return;
            }
            ContrProductos.EliminarProducto(cod_producto);

            Conexion.MsgBox("Producto Eliminado con éxito!",this.Page,this);
        }

        void CambiarImagen()
        {
            //OBTENGO EL PRODUCTO SELECCIONADO
            int cod_producto;
            try
            {
                cod_producto = Convert.ToInt32(txt_codigo.Text);
            }
            catch (Exception)
            {
                return;
            }
            byte[] imagen = ContrProductos.ObtenerImagenProducto(cod_producto);

            //MUESTRO LA IMAGEN
            String base64String = Convert.ToBase64String(ContrProductos.ObtenerImagenProducto(cod_producto), 0, ContrProductos.ObtenerImagenProducto(cod_producto).Length);
            imgProducto.ImageUrl = "data:image/jpeg;base64," + base64String;
        }
    }
}