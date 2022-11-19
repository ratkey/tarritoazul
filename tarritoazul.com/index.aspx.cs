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
            pnlProductos.CssClass = "catalogo";
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
                    Label lblDescripcion = new Label();
                    Button btnCarrito = new Button();

                    productoPanel.CssClass = "card";
                    imageButton.CssClass = "imagen";
                    lblNombre.CssClass = "nombre";
                    lblPrecio.CssClass = "price";
                    lblDescripcion.CssClass = "descripcion";
                    btnCarrito.CssClass = "boton";

                    //Cambiar las propiedades de los controles
                    imageButton.ImageUrl = "~/imgs/producto/" + "arete02.jpg";
                    //imageButton.CssClass = "";
                    //imageButton.PostBackUrl = "";

                    lblNombre.Text = producto.Nombre;
                    lblPrecio.Text = "$" + producto.Precio;
                    lblDescripcion.Text = producto.Descripcion;
                    btnCarrito.Text = "Añadir al carrito";

                    //Agregar el control al Panel
                    productoPanel.Controls.Add(imageButton);
                    //productoPanel.Controls.Add(new Literal {Text = "<br />"});
                    productoPanel.Controls.Add(lblNombre);
                    //productoPanel.Controls.Add(new Literal {Text = "<br />"});
                    productoPanel.Controls.Add(lblPrecio);
                    //productoPanel.Controls.Add(new Literal { Text = "<br />" });
                    productoPanel.Controls.Add(lblDescripcion);
                    productoPanel.Controls.Add(btnCarrito);

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