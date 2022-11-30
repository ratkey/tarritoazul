using System;
using tarritoazul.com.Models;

namespace tarritoazul.com
{
    public partial class DatosUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btGuardar_Click(object sender, EventArgs e)
        {
            if(Session["registro"] != null)
            {
                Registro r = (Registro)Session["registro"];
                Usuario u = new Usuario();

                u.Nombre = tbNombres.Text;
                u.Ap_Paterno = tbPaterno.Text;
                u.Ap_Materno = tbMaterno.Text;
                u.Sexo = ddlSexo.SelectedValue;
                u.Fecha_Nacimiento = tbFechadenac.Text;
                u.Telefono = tbTelefono.Text;
                u.Id_Registro = r.Id_Registro;
                
                UsuarioControler.Insertar(u);
                Session["usuario"] = u;
            }
            Response.Redirect("~/default.aspx");
        }
        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}