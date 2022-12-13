using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            List<Producto> productos = ProductoController.GetAllProductos();
            LlenarCatalogo(productos);
        }

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //vaciar el catalogo
            pnlProductos.Controls.Clear();

            string busqueda = tbBuscar.Text;

            //Obtiene una lista de todos los productos
            List<Producto> productos = ProductoController.GetProductsByName(busqueda);
            LlenarCatalogo(productos);
        }

        private void LlenarCatalogo(List<Producto> productos)
        {
            //Asegurarse de que haya productos en la lista
            if (productos.Count > 0)
            {
                //Crear un nuevo Panel con un ImageButton y 2 labels para cada producto
                foreach (Producto producto in productos)
                {
                    //Crear los elementos del cartel
                    Panel productoPanel = new Panel();
                    ImageButton imageButton = new ImageButton();
                    Label lblNombre = new Label();
                    Label lblPrecio = new Label();
                    Label lblDescripcion = new Label();
                    Button btnVer = new Button();

                    //Agregar las clases del css
                    productoPanel.CssClass = "card";
                    imageButton.CssClass = "imagen";
                    lblNombre.CssClass = "nombre";
                    lblPrecio.CssClass = "price";
                    lblDescripcion.CssClass = "descripcion";
                    btnVer.CssClass = "boton";

                    //Funcion al darle click al boton o imagen
                    imageButton.PostBackUrl = "~/forms/DetalleProducto.aspx?id=" + producto.Id_Producto;
                    btnVer.PostBackUrl = "~/forms/DetalleProducto.aspx?id=" + producto.Id_Producto;

                    //Obtener la primera imagen del producto
                    string img = ProductoController.GetProductMedia(producto.Id_Producto);

                    //Cambiar las propiedades de los controles
                    if (img != "")
                    {
                        imageButton.ImageUrl = "~/imgs/producto/" + img;
                    }
                    else
                    {
                        imageButton.ImageUrl = "~/imgs/producto/" + "placeholder.jpg";
                    }
                    Log(img);

                    lblNombre.Text = producto.Nombre;
                    lblPrecio.Text = "$" + producto.Precio;
                    lblDescripcion.Text = producto.Descripcion;
                    btnVer.Text = "Ver producto";

                    //Agregar el control al Panel
                    productoPanel.Controls.Add(imageButton);
                    productoPanel.Controls.Add(lblNombre);
                    productoPanel.Controls.Add(lblPrecio);
                    productoPanel.Controls.Add(lblDescripcion);
                    productoPanel.Controls.Add(btnVer);

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

        protected void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            //vaciar el catalogo
            pnlProductos.Controls.Clear();

            string busqueda = tbBuscar.Text;

            //Obtiene una lista de todos los productos
            List<Producto> productos = ProductoController.GetProductsByName(busqueda);
            LlenarCatalogo(productos);
        }
    }
}