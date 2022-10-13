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
        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        protected void BtContinuar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into registro values('" + TbNombre.Text + "','" + TbEmail.Text + "','" + TbContrasena.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Tu cuenta ha sido registrada correctamente 👌');", true);
        }
    }
}