using System;
using System.Collections.Generic;
using System.Drawing;
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
            pnl_comentarios.Controls.Clear();

            List<Comentario> comentarios = ContrComentario.ObtenerComentarios();

            foreach (Comentario  comentario in comentarios)
            {
                Label lblNombre = new Label();
                Label lblComentario = new Label();
                lblNombre.Text = "Nombre:";
                lblComentario.Text = "Comentario";

                Literal salto = new Literal();
                salto.Text = "</br>";
                TextBox txtNombree = new TextBox();
                txtNombree.Text = comentario.nombre;
                txtNombree.BackColor = Color.Blue;
                txtNombree.ReadOnly = true;
                TextBox txtComentario = new TextBox();
                txtComentario.BackColor = Color.Yellow;
                txtComentario.Text = comentario.comentario;
                txtComentario.ReadOnly = true;

                pnl_comentarios.Controls.Add(lblNombre);
                pnl_comentarios.Controls.Add(txtNombree);
                pnl_comentarios.Controls.Add(salto);
                pnl_comentarios.Controls.Add(txtComentario);
                pnl_comentarios.Controls.Add(salto);
                pnl_comentarios.Controls.Add(salto);
            }
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