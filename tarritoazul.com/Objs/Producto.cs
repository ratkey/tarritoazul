using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace tarritoazul.com.Objs
{
    public class Producto {
        private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);
        private string codigo_producto;
        private string nombre;
        private string descripcion;
        private string disponibilidad;
        private float precio;
        private int cantidad;

        public string Codigo_producto
        {
            get { return codigo_producto; }
            set { codigo_producto = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string Disponibilidad
        {
            get { return disponibilidad; }
            set { disponibilidad = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public Producto()
        {

        }
        public void insertar()
        {
            con.Open();

            Codigo_producto = generateProductCode(Nombre);

            string SQLInsert = String.Format("insert into PRODUCTOS(codigo_producto, nombre, precio, cantidad, descripcion, disponibilidad)" +
            "values('{0}','{1}',{2},{3},'{4}','{5}');", Codigo_producto, Nombre, Precio, Cantidad, Descripcion, Disponibilidad);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);
            cmd.ExecuteNonQuery();
            con.Close();
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
    }
}