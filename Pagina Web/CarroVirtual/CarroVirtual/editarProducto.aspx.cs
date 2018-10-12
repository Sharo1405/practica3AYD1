using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class editarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_editar_Click(object sender, EventArgs e)
        {
            //CREO EL PRODUCTO CON LOS DATOS A CAMBIAR
            Producto producto = new Producto();
            producto.cod_producto = Convert.ToInt32(txt_codigo.Text);
            producto.cantidad = Convert.ToInt32(txt_cantidad.Text);
            producto.precio_venta = Convert.ToInt32(txt_precio_venta.Text);
            producto.detalles = txt_detalles.Text;
            producto.nombre = txt_nombre.Text;
            producto.categoria_cod_categoria = Convert.ToInt32(combo_categoria.SelectedValue);

            if (fuimagen.FileBytes != null)
            {
                producto.imagen = fuimagen.FileBytes;
            }
            else {
                producto.imagen = ContrProductos.ObtenerImagenProducto(producto.cod_producto);
            }

            //EDITO EL PRODUCTO
            ContrProductos.EditarProducto(producto);

            //MUESTRO MENSAJE EXITOSO
            Conexion.MsgBox("Producto editado con éxito!",this.Page,this);
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

        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            Response.Write("hola");

            //BUSCO EL PRODUCTO POR NOMBRE O POR CODIGO
            Producto producto = ContrProductos.BuscarProducto(txt_buscar.Text);

            //MUESTRO LOS VALORES OBTENIDOS
            txt_codigo.Text = producto.cod_producto.ToString();
            txt_nombre.Text = producto.nombre;
            txt_cantidad.Text = producto.cantidad.ToString();
            txt_detalles.Text = producto.detalles;
            txt_precio_venta.Text = producto.precio_venta.ToString();
            try { combo_categoria.SelectedValue = producto.categoria_cod_categoria.ToString(); } catch (Exception) { }
            CambiarImagen();
        }
    }
}