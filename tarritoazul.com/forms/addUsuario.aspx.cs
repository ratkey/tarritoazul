using System;
using System.Web.UI;

namespace tarritoazul.com.forms
{
    public partial class addUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Revisar si la url contiene el parametro id
                if (!String.IsNullOrWhiteSpace(Request.QueryString["update"]))
                {
                    Usuario usuario = (Usuario)Session["usuario"];
                    tbNombres.Text = usuario.Nombre;
                    tbPaterno.Text = usuario.Ap_Paterno;
                    tbMaterno.Text = usuario.Ap_Materno;
                    ddlSexo.SelectedValue = usuario.Sexo;
                    tbFechadenac.Text = usuario.Fecha_Nacimiento;
                    tbTelefono.Text = usuario.Telefono;
                }
            }
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            if (Session["registro"] != null)
            {
                Registro registro = (Registro)Session["registro"];
                Usuario usuario = new Usuario();

                usuario.Nombre = tbNombres.Text;
                usuario.Ap_Paterno = tbPaterno.Text;
                usuario.Ap_Materno = tbMaterno.Text;
                usuario.Sexo = ddlSexo.SelectedValue;
                usuario.Fecha_Nacimiento = tbFechadenac.Text;
                usuario.Telefono = tbTelefono.Text;
                usuario.Id_Registro = registro.Id_Registro;

                //Obtener una de las imagenes del banco de imagenes de usuario
                Random rand = new Random();
                int number = rand.Next(1, 20); //returns random number between 1-20
                string random_avatar = number + ".png";

                usuario.Avatar_Img = random_avatar;

                if (Session["usuario"] == null)
                {
                    UsuarioController.Insertar(usuario);
                }
                else
                {
                    Usuario us = (Usuario)Session["usuario"];
                    usuario.Id_Usuario = us.Id_Usuario;
                    UsuarioController.Actualizar(usuario);
                }
                Session["usuario"] = usuario;
            }
            Response.Redirect("~/default.aspx");
        }

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}