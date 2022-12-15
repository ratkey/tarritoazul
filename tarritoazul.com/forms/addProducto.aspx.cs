using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Page = System.Web.UI.Page;

namespace tarritoazul.com.forms
{
    public partial class addProducto : System.Web.UI.Page
    {
        private static Producto producto = new Producto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Revisar si la url contiene el parametro id
                if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
                {
                    int id = Convert.ToInt32(Request.QueryString["id"]);
                    producto = ProductoController.SelectById(id);
                    SetValuesFromModel();
                    setProductImages();
                }
            }
        }

        protected void setProductImages()
        {
            if (producto.Id_Producto == -1) return;

            List<Media> mediaList = MediaController.GetAllMediaFromProducto(producto.Id_Producto);

            foreach (Media media in mediaList)
            {
                Image img = new Image();
                img.ImageUrl = "~/imgs/producto/" + media.Src_Url;
                img.Width = 100;
                pnlImages.Controls.Add(img);
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            GetValuesFromForm();

            if (producto.Id_Producto == -1)
            {
                //Insertar producto nuevo en la base de datos
                ProductoController.Insertar(producto);
                //Subir los archivos del FileUpload control
                subirArchivos();
                regresar();
            }
            else //Si ya existe el producto
            {
                //Actualizar el producto
                ProductoController.Actualizar(producto);
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
                ProductoController.Eliminar(producto);
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
                        int id_producto = producto.Id_Producto;
                        MediaController.Insertar(new Media(src_Url: fn, tipo: "imagen", id_Producto: id_producto));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }
    }
}