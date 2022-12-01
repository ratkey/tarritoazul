using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tarritoazul.com.Models;

namespace tarritoazul.com
{
    public partial class PerfilUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usuario"] = UsuarioControler.SelectById(5);
            if (Session["usuario"] == null)
            {
                return;
            }

            Usuario usuario = (Usuario)Session["usuario"];

            lbNombre.Text = usuario.Nombre;
            lbApPaterno.Text = usuario.Ap_Paterno;
            lbApMaterno.Text = usuario.Ap_Materno;
            lbNacimiento.Text = usuario.Fecha_Nacimiento;
            lbTelefono.Text = usuario.Telefono;

            //Cargar la imagen del usuario
            if(usuario.Avatar_Img != "")
            {
                //string filepath = Server.MapPath("..//imgs//avatar//");
                string imagenpath = "~/imgs/avatar/" + usuario.Avatar_Img;
                imgPerfil.ImageUrl = imagenpath;
                Log(imagenpath);
            }
        }
        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}