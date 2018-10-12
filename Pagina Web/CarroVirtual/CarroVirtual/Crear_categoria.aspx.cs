using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class Crear_categoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void crear_categoria(object sender, EventArgs e)
        {
            //CREO EL OBJETO DE CATEGORIA
            Categoria categoria = new Categoria();
            categoria.nombre = txt_nombre.Text;
            categoria.descripcion = txt_descripcion.Text;

            //SI EL PROUDCTO NO HA SIDO INGRESADO YA
            if (!Gestion_categoria_crud.ExisteCategoria(categoria))
            {
                //INGRESO A LA BASE DE DATOS
                Gestion_categoria_crud.CrearCategoria(categoria);

                //MUESTRO MENSAJE DE EXITO
                Conexion.MsgBox("Categoria Registrada con éxito!", this.Page, this);
            }
            else
            {
                //MUESTRO MENSAJE DE ERROR
                Conexion.MsgBox("Error, La categoria ya se encuentra registrada!", this.Page, this);
            }
            txt_nombre.Text = "";
            txt_descripcion.Text = "";
        }
    }
}