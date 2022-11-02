using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tarritoazul.com.forms
{
    public partial class addProducto : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string cotNombre, cotDesc, cotDisp, cotCodProd;
            float cotPrecio;
            int cotCant;

            cotNombre = tbNombre.Text;
            cotCodProd = generateProductCode(cotNombre);
            cotDesc = tbDescripcion.Text;
            cotDisp = ddlDisponibilidad.Text;
            cotPrecio = float.Parse(tbPrecio.Text);
            cotCant = int.Parse(tbCantidad.Text);

            con.Open();
            
            string SQLInsert = String.Format("insert into PRODUCTOS(codigo_producto, nombre, precio, stock, descripcion, disponibilidad)"+
            "values('{0}','{1}',{2},{3},'{4}','{5}');",cotCodProd, cotNombre, cotPrecio, cotCant, cotDesc, cotDisp);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);
            cmd.ExecuteNonQuery();
            con.Close();

            string script = "alert('Producto registrado correctamente 👍');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
        }

        protected string generateProductCode(string nombre){
            Random rnd = new Random();
            nombre = nombre.ToUpper();
            if (nombre.Length > 5){
                nombre = nombre.Substring(0,5);
            }
            for (int i = 0; i < 5; i++)
            {
                int let = rnd.Next(65, 90);
                nombre += (char)let;
            }
            return nombre;
        }
    }
}