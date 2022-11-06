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

            string SQLInsert = String.Format("insert into PRODUCTOS(codigo_producto, nombre, precio, stock, descripcion, disponibilidad)" +
            "values('{0}','{1}',{2},{3},'{4}','{5}');", cotCodProd, cotNombre, cotPrecio, cotCant, cotDesc, cotDisp);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);
            cmd.ExecuteNonQuery();
            con.Close();

            string script = "alert('Producto registrado correctamente 👍');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
        }

        protected string generateProductCode(string nombre)
        {
            Random rnd = new Random();
            nombre = nombre.ToUpper();
            if (nombre.Length > 5)
            {
                nombre = nombre.Substring(0, 5);
            }
            for (int i = 0; i < 5; i++)
            {
                int let = rnd.Next(65, 90);
                nombre += (char)let;
            }
            return nombre;
        }

        protected void FileUpload_SaveBtn_Click(object sender, EventArgs e)
        {
            string filepath = "D:\\Projects\\web\\tarritoazul\\tarritoazul.com\\imgs\\producto\\";

            //check if user has selected a file
            if (FileUpload_Control.HasFile)
            {
                if ((FileUpload_Control.PostedFile != null) && (FileUpload_Control.PostedFile.ContentLength > 0))
                {
                    var count = 0;
                    foreach (HttpPostedFile uploadedFile in FileUpload_Control.PostedFiles)
                    {
                        string fn = System.IO.Path.GetFileName(uploadedFile.FileName);
                        //string SaveLocation = Server.MapPath("upload") + "\\" + fn;
                        string SaveLocation = filepath + fn;
                        try
                        {
                            uploadedFile.SaveAs(SaveLocation);
                            count++;
                        }
                        catch (Exception ex)
                        {
                            FileUploadStatus.Text = "Error: " + ex.Message;
                        }
                    }
                    if (count > 0)
                    {
                        FileUploadStatus.Text = count + " files has been uploaded.";
                    }
                }
                else
                {
                    FileUploadStatus.Text = "Please select a file to upload.";
                }


            }
            else
            {
                FileUpload_Msg.Text = "Error - No file chosen.";
            }
        }
    }
}