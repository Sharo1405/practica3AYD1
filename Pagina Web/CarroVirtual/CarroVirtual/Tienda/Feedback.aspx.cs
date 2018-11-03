using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual.Tienda
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            //CREO EL OBJETO
            Comentario com = new Comentario();
            com.nombre = txtnombre.Text;
            com.comentario = txtContenido.Text;

            ContrComentario.CrearComentario(com);
            Conexion.MsgBox("¡Comentario posteado con éxito!", this.Page, this);
        }
    }
}