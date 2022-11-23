using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tarritoazul.com.Models;

namespace tarritoazul.com
{
    public partial class prueba : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            UsuarioModel m = new UsuarioModel();

            u.Nombre = "irvin";
                   u.Ap_Paterno = "martinez";
                u.Ap_Materno = "lamas";
            u.Telefono = "3113537228";
            u.Fecha_Nacimiento = "09/22/2003";
            u.Avatar_Img = "foto.png";
            u.Id_Registro = 1;

            m.Insertar(u);


        }
    }
}