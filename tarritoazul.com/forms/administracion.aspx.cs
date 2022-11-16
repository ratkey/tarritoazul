using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tarritoazul.com.forms
{
    public partial class administracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //Obtener fila seleccionada
            GridViewRow row = productosGridView.Rows[e.NewEditIndex];
            //Obtener el id del producto seleccionado
            int rowId = Convert.ToInt32(row.Cells[1].Text);
            //Redireccionar al usuario a addProductos.asp con el id seleccionado
            Response.Redirect("~/forms/addProducto.aspx?id=" + rowId);
        }
    }
}