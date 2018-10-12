using System;
using System.Data;

namespace CarroVirtual
{
    public partial class Editar_categoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable Resultado = Gestion_categoria_crud.ExisteProductoLista();
            for (int i = 0; i < Resultado.Rows.Count; i++)
            {
                DropDownList1.Items.Add((String)Resultado.Rows[i][0]);
            }
        }

        protected void editar_categoria(object sender, EventArgs e)
        {
            String nombreSeleccionado = DropDownList1.SelectedItem.Text;
            Categoria categoria = new Categoria();
            categoria.nombre = txt_nombre.Text;
            categoria.descripcion = txt_descripcion.Text;
            bool realizado = Gestion_categoria_crud.EditarCategoria(categoria, nombreSeleccionado);
            if (realizado)
            {
                Conexion.MsgBox("Categoria Actualizada con éxito!", this.Page, this);
            }
            else
            {
                Conexion.MsgBox("Categoria No Actualizada, Intente de nuevo !!!", this.Page, this);
            }
            txt_descripcion.Text = "";
            txt_nombre.Text = "";
            for (int i = 0; i < DropDownList1.Items.Count; i++)
            {
                DropDownList1.Items.RemoveAt(i);
            }
            
        }
    }
}