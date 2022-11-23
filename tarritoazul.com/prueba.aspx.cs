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
            

            u.Nombre = "irving";
                   u.Ap_Paterno = "gonzalez";
                u.Ap_Materno = "jimenes";
            u.Telefono = "1111111111";
            u.Fecha_Nacimiento = "09/22/2003";
            u.Avatar_Img = "imagen.png";
            u.Id_Registro = 1;

            m.Actualizar(u);  


        }
    }
}