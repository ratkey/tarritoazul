using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using tarritoazul.com.Models;
using Page = System.Web.UI.Page;

namespace tarritoazul.com.forms
{
    public partial class addProducto : System.Web.UI.Page
    {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        public static Producto producto = new Producto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Revisar si la url contiene el parametro id
                if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {
                    Log("modificando");
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    producto = ProductoControler.SelectById(id);
                    SetValuesFromModel();
                    Log("Producto: " + producto.ToString());
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GetValuesFromForm();

            if (producto.Id_Producto == -1)
            {
                //Insertar producto nuevo en la base de datos
                ProductoControler.Insertar(producto);
                //Subir los archivos del FileUpload control
                subirArchivos();
                regresar();
            }
            else //Si ya existe el producto
            {
                //Actualizar el producto
                ProductoControler.Actualizar(producto);
                //Validar si hay archivos seleccionados
                if (FileUpload_Control.HasFiles)
                {
                    //Subir los archivos
                    subirArchivos();
                }
                regresar();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (producto.Id_Producto > 0)
            {
                ProductoControler.Eliminar(producto);
                //Mensaje de registro exitoso
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", "alert('Producto: " + producto.Nombre + " eliminado 💥');", true);
                regresar();
            }
        }

        protected void regresar()
        {
            producto = new Producto();
            Response.Redirect("~/forms/administracion.aspx");
        }

        //Pasa los valores del formulario al objeto producto
        protected void GetValuesFromForm()
        {
            producto.Nombre = tbNombre.Text;
            producto.Descripcion = tbDescripcion.Text;
            producto.Precio = float.Parse(tbPrecio.Text);
            producto.Cantidad = int.Parse(tbCantidad.Text);
            producto.Disponibilidad = ddlDisponibilidad.Text;
            producto.Id_Categoria = int.Parse(ddlCategoria.Text);
        }

        //Pasa los valores del objeto producto al formulario
        protected void SetValuesFromModel()
        {
            tbNombre.Text = producto.Nombre;
            tbDescripcion.Text = producto.Descripcion;
            tbPrecio.Text = producto.Precio.ToString();
            tbCantidad.Text = producto.Cantidad.ToString();
            ddlDisponibilidad.SelectedValue = producto.Disponibilidad.ToString();
            ddlCategoria.SelectedValue = producto.Id_Categoria.ToString();
        }

        //Limpia el formulario
        protected void CleanForm()
        {
            tbNombre.Text = "";
            tbDescripcion.Text = "";
            tbPrecio.Text = "99";
            tbCantidad.Text = "1";
            ddlDisponibilidad.SelectedIndex = 0;
            ddlCategoria.SelectedIndex = 0;
            FileUploadStatus.Text = "";
        }

        protected void subirArchivos()
        {
            //ruta para cuardar los archivos
            string filepath = Server.MapPath("../imgs/producto/");

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

                    string ruta_guardado = filepath + fn;
                    try
                    {
                        //guardar actual archivo en el directorio
                        archivo.SaveAs(ruta_guardado);
                        cantidad_archivos++;

                        //guardar info del archivo en la BD
                        insertMedia(fn, "imagen", producto.Id_Producto);
                    }
                    catch (Exception ex)
                    {
                        FileUploadStatus.Text = "Error: " + ex.Message;
                    }
                }
                if (cantidad_archivos > 0)
                {
                    FileUploadStatus.Text = cantidad_archivos + " archivos subiidos.";
                }
            }
            else
            {
                FileUploadStatus.Text = "Seleccione archivos para subir.";
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
        }

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}