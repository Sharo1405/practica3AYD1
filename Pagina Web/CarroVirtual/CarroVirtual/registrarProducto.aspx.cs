using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class registrarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            //CREO EL OBJETO DE TIPO PRODUCTO
            Producto producto = new Producto();
            producto.nombre = txt_nombre.Text;
            producto.detalles = txt_descripcion.Text;
            producto.categoria_cod_categoria = Convert.ToInt32(combo_categorias.SelectedValue);
            try { producto.precio_venta = Convert.ToInt32(txt_precio.Text); producto.cantidad = Convert.ToInt32(txt_cantidad.Text); }
            catch (Exception) { }
            producto.imagen = fuimagen.FileBytes;

            //CREO LA CATEGORIA DE LA QUE PERTENECE
            Categoria categoria = new Categoria();
            categoria.nombre = combo_categorias.SelectedItem.Text;
            categoria.cod_categoria = Convert.ToInt32(combo_categorias.SelectedValue);

            //SI EL PROUDCTO NO HA SIDO INGRESADO YA
            if (!ContrProductos.ExisteProducto(producto,categoria))
            {
                //INGRESO A LA BASE DE DATOS
                ContrProductos.CrearProducto(producto, categoria);

                //MUESTRO MENSAJE DE EXITO
                Conexion.MsgBox("Producto Registrado con éxito!", this.Page, this);
                
                //MUESTRO LA IMAGEN
                String base64String = Convert.ToBase64String(fuimagen.FileBytes, 0, fuimagen.FileBytes.Length);
                imgProducto.ImageUrl = "data:image/jpeg;base64," + base64String;
            }
            else
            {
                //MUESTRO MENSAJE DE ERROR
                Conexion.MsgBox("Error, el producto ya se encuentra registrado!", this.Page, this);
            }
        }
    }
}