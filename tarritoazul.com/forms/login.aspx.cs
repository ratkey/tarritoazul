using System;
using Tarritoazul.Controllers;
using Tarritoazul.Models;

namespace tarritoazul.com.forms
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cotUser = TbUsuario.Text;
            string cotContr = TbContrasenia.Text;

            int id_registro = LoginController.ValidarLogin(cotUser, cotContr);
            if (id_registro != -1)
            {
                //Obtener el registro y guardarlo en la Session
                Registro registro = RegistroController.SelectById(id_registro);
                Session["registro"] = registro;

                //Obtener el Usuario y guardarlo en la Session
                Usuario usuario = UsuarioController.SelectByRegistroId(id_registro);
                if (usuario != null)
                {
                    Session["usuario"] = usuario;
                    Response.Redirect("~/default.aspx");
                }
                else
                {
                    Response.Redirect("~/forms/addUsuario.aspx");
                }
            }
            else
            {
                Log("No existe el usuario");
            }
        }

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}