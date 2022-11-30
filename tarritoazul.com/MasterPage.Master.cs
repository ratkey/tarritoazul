using System;
using System.Collections.Generic;
using tarritoazul.com.Models;

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

                //Poner el nombre del usuario en el boton btnUser
                btnUser.Text = registro.Usuario;

                //Ocultar botones
                btnIniciarSecion.Visible = false;
                btnRegistrarse.Visible = false;
                //Mostrar botones
                btnUser.Visible = true;
                btnAdmin.Visible = true;
            }
            else
            {
                //Ocultar botones
                btnIniciarSecion.Visible = true;
                btnRegistrarse.Visible = true;
                //Mostrar botones
                btnUser.Visible = false;
                btnCerrarSesion.Visible = false;
                btnAdmin.Visible = false;
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

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //cerrar sesion
            Session["registro"] = null;
            Session["usuario"] = null;
            //redireccionar a la pagina principal
            Response.Redirect("~/default.aspx");
        }

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}