using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tarritoazul.com.Models;

namespace tarritoazul.com
{
    public partial class index1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        private void FillPage()
        {
            //Obtiene una lista de todos los productos
            ProductoModel productoModel = new ProductoModel();
            List<Producto> productos = productoModel.GetAllProductos();

            //Asegurarse de que los productos existen en la BD
            if (productos != null)
            {
                //Crear un nuevo Panel con un ImageButton y 2 labels para cada producto
                foreach(Producto producto in productos)
                {
                    Panel productoPanel = new Panel();
                    ImageButton imageButton = new ImageButton();
                    Label lblNombre = new Label();
                    Label lblPrecio = new Label();

                    //Cambiar las propiedades de los controles
                    imageButton.ImageUrl = "~/imgs/producto/" + "arete01.jpg";
                    //imageButton.CssClass = "";
                    //imageButton.PostBackUrl = "";

                    lblNombre.Text = producto.Nombre;
                    lblPrecio.Text = "$" + producto.Precio;

                    //Agregar el control al Panel
                    productoPanel.Controls.Add(imageButton);
                    productoPanel.Controls.Add(new Literal {Text = "<br />"});
                    productoPanel.Controls.Add(lblNombre);
                    productoPanel.Controls.Add(new Literal {Text = "<br />"});
                    productoPanel.Controls.Add(lblPrecio);

                    //Agregar paneles ddinamicos al panel estatico padre
                    pnlProductos.Controls.Add(productoPanel);

                    Log(producto.ToString());
                }
            }
            else
            {
                pnlProductos.Controls.Add(new Literal { Text = "No se encontraron productos!" });
            }
        }

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}