using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarroVirtual
{
    public partial class Eliminar_categoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable Resultado = Gestion_categoria_crud.ExisteProductoLista();
            for (int i = 0; i < Resultado.Rows.Count; i++)
            {
                DropDownList1.Items.Add((String)Resultado.Rows[i][0]);
            }
        }

        protected void eliminar_categoria(object sender, EventArgs e)
        {
            String nombre = DropDownList1.SelectedItem.Text;

            for (int i = 0; i < DropDownList1.Items.Count; i++)
            {
                DropDownList1.Items.RemoveAt(i);
            }

            bool existe = Gestion_categoria_crud.Eliminar_categoria(nombre);
            if (existe == true)
            {
                Conexion.MsgBox("Categoria Eliminada con éxito!", this.Page, this);
            }
            else
            {
                Conexion.MsgBox("Categoria No existe!!!", this.Page, this);
            }
        }
    }
}