using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tarritoazul.com.Models;

namespace tarritoazul.com.forms
{
    public partial class DetalleProducto : System.Web.UI.Page
    {
        private static Producto producto;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Revisar si la url contiene el parametro id
                if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    producto = ProductoModel.SelectById(id);
                    SetValues(producto);
                }
            }
        }

        private void SetValues(Producto p)
        {
            lbNombre.Text = p.Nombre;
            lbPrecio.Text = p.Precio.ToString();
            lbDescripcion.Text = p.Descripcion;

            string img = ProductoModel.GetProductMedia(p.Id_Producto);
            imgProducto.ImageUrl = "~/imgs/producto/" + img;
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            CarritoControler.AddProducto(producto);

            //List<Producto> listaProd = (List<Producto>)Session["carrito"];
            //Log("Carrito: " + listaProd.Count);
        }

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}