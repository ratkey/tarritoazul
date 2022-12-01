using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using tarritoazul.com.Models;

namespace tarritoazul.com
{
    public partial class PerfilUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usuario"] = UsuarioControler.SelectById(5);
            if (Session["usuario"] == null)
            {
                return;
            }

            Usuario usuario = (Usuario)Session["usuario"];

            lbNombre.Text = usuario.Nombre;
            lbApPaterno.Text = usuario.Ap_Paterno;
            lbApMaterno.Text = usuario.Ap_Materno;
            lbNacimiento.Text = usuario.Fecha_Nacimiento;
            lbTelefono.Text = usuario.Telefono;

            //Cargar la imagen del usuario
            if(usuario.Avatar_Img != "")
            {
                //string filepath = Server.MapPath("..//imgs//avatar//");
                string imagenpath = "~/imgs/avatar/" + usuario.Avatar_Img;
                imgPerfil.ImageUrl = imagenpath;
                Log(imagenpath);
            }
        }

        protected void SubirArchivos()
        {
            //ruta para cuardar los archivos
            string filepath = Server.MapPath("../imgs/avatar/");

            //revisar si se ha seleccionado un archivo
            if ((fileUp.PostedFile != null) && (fileUp.PostedFile.ContentLength > 0))
            {
                //iterar por cada archivo subido
                foreach (HttpPostedFile archivo in fileUp.PostedFiles)
                {
                    //obtener el nombre del archivo
                    string fn = System.IO.Path.GetFileName(archivo.FileName);

                    string ruta_guardado = filepath + fn;
                    try
                    {
                        //guardar actual archivo en el directorio
                        archivo.SaveAs(ruta_guardado);

                        Usuario usuario = (Usuario)Session["usuario"];
                        usuario.Avatar_Img = fn;
                        //guardar info del archivo en la BD
                        UsuarioControler.Actualizar(usuario);

                        string imagenpath = "~/imgs/avatar/" + usuario.Avatar_Img;
                        imgPerfil.ImageUrl = imagenpath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void Log(string msg)
        {
            Page.Response.Write("<script>console.log('" + msg + "');</script>");
        }

        protected void btnSubirimg_Click(object sender, EventArgs e)
        {
            SubirArchivos();
        }
    }
}