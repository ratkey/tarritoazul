using System;
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
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            //cerrar sesion
            Session["registro"] = null;
            Session["usuario"] = null;
            //redireccionar a la pagina principal
            Response.Redirect("~/default.aspx");
        }
    }
}