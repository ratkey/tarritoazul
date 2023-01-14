using System;
using System.Collections.Generic;

namespace tarritoazul.com
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Si hay una sesion iniciada
            if (Session["registro"] != null && Session["usuario"] != null)
            {
                //Obtener el objeto Registro de la Session
                Registro registro = (Registro)Session["registro"];
                Usuario usuario = (Usuario)Session["usuario"];

                //Poner el nombre del usuario en el boton btnUser
                lblUserName.Text = registro.Usuario;
                ImgBtnUserImage.ImageUrl = "~/Imgs/avatar/" + usuario.Avatar_Img;

                Log(ImgBtnUserImage.ImageUrl);
                Log(usuario.ToString());

                //Ocultar botones
                btnIniciarSecion.Visible = false;
                btnRegistrarse.Visible = false;
                

                //Mostrar botones
                btnAdmin.Visible = true;
                ImgBtnUserImage.Visible = true;
                lblUserName.Visible = true;
            }
            else
            {
                //Ocultar botones
                btnAdmin.Visible = false;
                ImgBtnUserImage.Visible = false;
                lblUserName.Visible = false;

                //Mostrar botones
                btnIniciarSecion.Visible = true;
                btnRegistrarse.Visible = true;
            }


            //Si hay elementos en el carrtio
            if (Session["carrito"] != null)
            {
                //Obtener la lista de productos del carrito
                List<Producto> listaCarrito = (List<Producto>)Session["carrito"];
                Log("Productos en el carrito: " + listaCarrito.Count);
                linkCarrito.Text = "🛒Carrito (" + listaCarrito.Count + ")";
            }

            //obtener la pagina actual
            string currentPage = this.Page.Request.FilePath;

            //mostrar u ocultar los botones
            if (currentPage == "/forms/login.aspx")
            {
                btnIniciarSecion.Visible = false;
            }
            else if (currentPage == "/forms/registro.aspx")
            {
                btnRegistrarse.Visible = false;
            }
        }

        

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}