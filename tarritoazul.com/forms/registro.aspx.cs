using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using tarritoazul.com.Models;

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

            RegistroControler.Insertar(registro);
            Session["registro"] = registro;
            Response.Redirect("~/forms/addUsuario.aspx");
        }

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}