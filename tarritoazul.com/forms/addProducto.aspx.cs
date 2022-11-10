using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tarritoazul.com.Objs;

namespace tarritoazul.com.forms
{
    public partial class addProducto : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);
        public string codigo_producto;
        public int id_producto;
        protected void Page_Load(object sender, EventArgs e)
        {
            FileUpload_SaveBtn.Visible = false;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string cotNombre, cotDesc, cotDisp, cotCodProd;
            float cotPrecio;
            int cotCant;

            cotNombre = tbNombre.Text;
            cotCodProd = generateProductCode(cotNombre);
            this.codigo_producto = cotCodProd;
            cotDesc = tbDescripcion.Text;
            cotDisp = ddlDisponibilidad.Text;
            cotPrecio = float.Parse(tbPrecio.Text);
            cotCant = int.Parse(tbCantidad.Text);

            Producto prod = new Producto();
            prod.Nombre = cotNombre;
            prod.Descripcion = cotDesc;
            prod.Precio = cotPrecio;
            prod.Disponibilidad = cotDisp;
            prod.Cantidad = cotCant;

            prod.insertar();
            //insertProducto();
            //this.id_producto = getIdProducto(this.codigo_producto);
            //subirArchivos();
        }

        protected void FileUpload_SaveBtn_Click(object sender, EventArgs e)
        { 
            subirArchivos();
        }

        protected int getIdProducto(string codigo_producto)
        {
            taTableAdapters.PRODUCTOSTableAdapter taProducto = new taTableAdapters.PRODUCTOSTableAdapter();
            ta.PRODUCTOSDataTable dtProducto = taProducto.GetData(codigo_producto);

            int total_registros = dtProducto.Count;
            if (total_registros > 0)
            {
                ta.PRODUCTOSRow rowRegistro = dtProducto[0]; //Toda la informacion del registro
                int id_producto = rowRegistro.id_producto;
                return id_producto;
            }

            return -1;
        }

        protected void subirArchivos()
        {
            //ruta para cuardar los archivos
            string filepath = "D:\\Projects\\web\\tarritoazul\\tarritoazul.com\\imgs\\producto\\";

            //revisar si se ha seleccionado un archivo
            if ((FileUpload_Control.PostedFile != null) && (FileUpload_Control.PostedFile.ContentLength > 0))
            {
                //cantidad de archivos subidos
                var cantidad_archivos = 0;
                //iterar por cada archivo subido
                foreach (HttpPostedFile archivo in FileUpload_Control.PostedFiles)
                {
                    //obtener el nombre del archivo
                    string fn = System.IO.Path.GetFileName(archivo.FileName);
                    //string ruta_guardado = Server.MapPath("upload") + "\\" + fn;

                    string ruta_guardado = filepath + fn;
                    try
                    {
                        //guardar actual archivo en el directorio
                        archivo.SaveAs(ruta_guardado);
                        cantidad_archivos++;

                        //guardar info del archivo en la BD
                        insertMedia(fn, "imagen", id_producto);
                    }
                    catch (Exception ex)
                    {
                        FileUploadStatus.Text = "Error: " + ex.Message;
                    }
                }
                if (cantidad_archivos > 0)
                {
                    FileUploadStatus.Text = cantidad_archivos + " files has been uploaded.";
                }
            }
            else
            {
                FileUploadStatus.Text = "Please select a file to upload.";
            }
        }

        protected void insertMedia(string src_url, string tipo, int id_producto)
        {
            con.Open();

            string SQLInsert = String.Format("insert into MEDIA(src_url, tipo, id_producto)" +
            "values('{0}','{1}',{2});", src_url, tipo, id_producto);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);
            cmd.ExecuteNonQuery();
            con.Close();

            string script = "alert('Media registrada correctamente 👍');";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
        }

        protected void insertProducto()
        {
            string cotNombre, cotDesc, cotDisp, cotCodProd;
            float cotPrecio;
            int cotCant;

            cotNombre = tbNombre.Text;
            cotCodProd = generateProductCode(cotNombre);
            this.codigo_producto = cotCodProd;
            cotDesc = tbDescripcion.Text;
            cotDisp = ddlDisponibilidad.Text;
            cotPrecio = float.Parse(tbPrecio.Text);
            cotCant = int.Parse(tbCantidad.Text);

            con.Open();

            string SQLInsert = String.Format("insert into PRODUCTOS(codigo_producto, nombre, precio, cantidad, descripcion, disponibilidad)" +
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

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}