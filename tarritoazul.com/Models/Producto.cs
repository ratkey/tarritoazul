using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using tarritoazul.com.taTableAdapters;

namespace tarritoazul.com.Models
{
    public class Producto {
        private readonly SqlConnection con;
        private string codigo_producto;
        private string nombre;
        private string descripcion;
        private string disponibilidad;
        private float precio;
        private int cantidad;

        public string Codigo_producto {get; set;}
        public string Nombre {get; set;}
        public string Descripcion {get; set;}
        public string Disponibilidad { get; set; }
        public float Precio { get; set;}
        public int Cantidad { get; set;}

        public Producto()
        {
            this.con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);
        }

        public Producto(string codigo_producto, string nombre, string descripcion, string disponibilidad, float precio, int cantidad)
        {
            this.con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);
            this.codigo_producto = codigo_producto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.disponibilidad = disponibilidad;
            this.precio = precio;
            this.cantidad = cantidad;
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