using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace tarritoazul.com.forms
{
    public partial class registro : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);
        string SQLInsert;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtContinuar_Click(object sender, EventArgs e)
        {
            String cotNombre, cotEmail, cotContrasena;
            cotNombre = TbNombre.Text;
            cotEmail = TbEmail.Text;
            cotContrasena = TbContrasena.Text;

            con.Open();
            
            SQLInsert = String.Format("insert into REGISTROS(usuario, correo, contrasena)"+
            "values('{0}','{1}','{2}');", cotNombre, cotEmail, cotContrasena);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);
            cmd.ExecuteNonQuery();
            con.Close();

            string script = "alert('Usuario registrado correctamente 👍');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
        }
    }
}