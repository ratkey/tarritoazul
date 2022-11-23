using System.Configuration;
using System.Data.SqlClient;

namespace tarritoazul.com.Models
{
    public class Producto
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        public Producto()
        {
            Id_Producto = -1;
        }

        public int Id_Producto { get; set; }
        public string Codigo_producto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }
        public int Cantidad { get; set; }
        public string Disponibilidad { get; set; }
        public int Id_Categoria { get; set; }

        public override string ToString()
        {
            return "id_producto: " + Id_Producto + ", nombre: " + Nombre + ", descripcion: " + Descripcion +
                ", precio: " + Precio + ", cantidad: " + Cantidad + ", disponibilidad: " + Disponibilidad + ", id_categoria: " + Id_Categoria;
        }
    }
}