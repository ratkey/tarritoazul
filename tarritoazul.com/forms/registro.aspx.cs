using System;
using System.Web.UI;
using Tarritoazul.Controllers;
using Tarritoazul.Models;

namespace tarritoazul.com.forms
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtContinuar_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();

            registro.Usuario = TbNombre.Text;
            registro.Correo = TbEmail.Text;
            registro.Contrasena = TbContrasena.Text;

            RegistroController.Insertar(registro);
            Session["registro"] = registro;
            Response.Redirect("~/forms/addUsuario.aspx");
        }

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}