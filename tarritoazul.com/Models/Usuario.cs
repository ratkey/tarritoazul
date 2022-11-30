using System.Configuration;
using System.Data.SqlClient;

namespace tarritoazul.com.Models
{
    public class Usuario
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        public Usuario()
        {
            Id_Usuario = -1;
        }

        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Ap_Paterno { get; set; }
        public string Ap_Materno { get; set; }
        public string Telefono { get; set; }
        public string Fecha_Nacimiento { get; set; }
        public string Avatar_Img { get; set; }
        public int Id_Registro { get; set; }
        public string Sexo { get; set; }

        public override string ToString()
        {
            return "id_usuario: " + Id_Usuario + ", Nombre: " + Nombre + ", ap_paterno: " + Ap_Paterno +
                ", ap_materno: " + Ap_Materno + ", telefono: " + Telefono + ", fecha_nacimiento: " + Fecha_Nacimiento + ", avatar_img " + Avatar_Img + ", id_registro: " + Id_Registro;
        }
    }
}