using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Windows.Forms;
using tarritoazul.com.taTableAdapters;

namespace tarritoazul.com.Models
{
    public class Producto {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);
        
        private int id_producto;
        private string codigo_producto;
        private string nombre;
        private string descripcion;
        private float precio;
        private int cantidad;
        private string disponibilidad;
        private int id_categoria;

        public int Id_Producto { get; set; }
        public string Codigo_producto {get; set;}
        public string Nombre {get; set;}
        public string Descripcion {get; set;}
        public float Precio { get; set;}
        public int Cantidad { get; set;}
        public string Disponibilidad { get; set; }
        public int Id_Categoria { get; set;}


        public void insertar() //insertar Producto a la BD y obtener el ID
        {
            con.Open();

            Codigo_producto = generateProductCode(Nombre);

            string SQLInsert = String.Format("insert into PRODUCTOS(codigo_producto, nombre, precio, cantidad, descripcion, disponibilidad, id_categoria) output INSERTED.id_producto " +
            "values('{0}','{1}',{2},{3},'{4}','{5}',{6});", Codigo_producto, Nombre, Precio, Cantidad, Descripcion, Disponibilidad, Id_Categoria);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);
            Id_Producto = (int)cmd.ExecuteScalar();
            
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public void actualizar()
        {
            con.Open();

            Codigo_producto = generateProductCode(Nombre);

            string SQLInsert = String.Format("update PRODUCTOS "+
                "set nombre = '{0}', descripcion = '{1}', precio = {2}, cantidad = {3}, disponibilidad = '{4}', id_categoria = {5} " +
                "where id_producto = {6};", Nombre, Descripcion, Precio, Cantidad, Disponibilidad, Id_Categoria, Id_Producto);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void eliminar()
        {
            con.Open();

            string SQLInsert = String.Format("delete from PRODUCTOS where id_producto = {0};", Id_Producto);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public string generateProductCode(string nombre)
        {
            Random rnd = new Random();
            nombre = nombre.ToUpper();
            nombre = nombre.Replace(" ", "");
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