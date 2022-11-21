using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tarritoazul.com.Models
{
    public class ProductoModel
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);
        
        //obtiene todos los Prodctos de la base de datos
        public List<Producto> GetAllProductos()
        {
            List<Producto> productos = new List<Producto>();
            SqlCommand command = new SqlCommand("Select * from [PRODUCTOS]", con);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Producto p = new Producto();
                        p.Id_Producto = (int)reader["id_producto"];
                        p.Codigo_producto = (string)reader["codigo_producto"];
                        p.Nombre = (string)reader["nombre"];
                        p.Descripcion = (string)reader["descripcion"];
                        p.Precio = float.Parse(reader["precio"].ToString());
                        p.Cantidad = (int)reader["cantidad"];
                        p.Disponibilidad = (string)reader["disponibilidad"];
                        p.Id_Categoria = (int)reader["id_categoria"];
                        productos.Add(p);
                    }
                }

                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();

                return productos;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //Cambiar este metodo al modelo MediaModel
        public string GetProductMedia(int id_producto)
        {
            string url = "";
            SqlCommand command = new SqlCommand("Select top 1 src_url from [MEDIA] join [PRODUCTOS] on PRODUCTOS.id_producto = MEDIA.id_producto and PRODUCTOS.id_producto = " + id_producto, con);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        url = (string)reader["src_url"];
                    }
                }

                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return url;
        }

        //Regresa un prodcuto de la BD basado en su id_producto
        public Producto SelectById(int id)
        {
            SqlCommand command = new SqlCommand("Select * from [PRODUCTOS] where id_producto=@idp", con);
            command.Parameters.AddWithValue("@idp", id);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Producto p = new Producto();
                        p.Id_Producto = (int)reader["id_producto"];
                        p.Codigo_producto = (string)reader["codigo_producto"];
                        p.Nombre = (string)reader["nombre"];
                        p.Descripcion = (string)reader["descripcion"];
                        p.Precio = float.Parse(reader["precio"].ToString());
                        p.Cantidad = (int)reader["cantidad"];
                        p.Disponibilidad = (string)reader["disponibilidad"];
                        p.Id_Categoria = (int)reader["id_categoria"];

                        con.Close();
                        return p;
                    }
                    else
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public Producto Insertar(Producto p) //insertar Producto a la BD y obtener el ID
        {
            //Genera un codigo de producto a partir del nombre
            p.Codigo_producto = GenerateProductCode(p.Nombre);
            //Definir la consulta
            string SQLInsert = String.Format("insert into PRODUCTOS(codigo_producto, nombre, precio, cantidad, descripcion, disponibilidad, id_categoria) output INSERTED.id_producto " +
            "values('{0}','{1}',{2},{3},'{4}','{5}',{6});", p.Codigo_producto, p.Nombre, p.Precio, p.Cantidad, p.Descripcion, p.Disponibilidad, p.Id_Categoria);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la insercion y obtener el ID generado
                p.Id_Producto = (int)cmd.ExecuteScalar();
                //Cerrar la coneccion con la BD si se encuentra abierta
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
                return p;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Actualizar(Producto p)
        {
            //Definir la consulta
            string SQLUpdate = String.Format("update PRODUCTOS " +
                "set nombre='{0}', descripcion='{1}', precio={2}, cantidad={3}, disponibilidad='{4}', id_categoria={5} " +
                "where id_producto={6};", p.Nombre, p.Descripcion, p.Precio, p.Cantidad, p.Disponibilidad, p.Id_Categoria, p.Id_Producto);

            SqlCommand cmd = new SqlCommand(SQLUpdate, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la instruccion
                cmd.ExecuteNonQuery();
                //Cerrar la coneccion con la BD si se encuentra abierta
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Eliminar(Producto p)
        {
            //Definir la consulta
            string SQLDelete = String.Format("delete from PRODUCTOS where id_producto = {0};", p.Id_Producto);

            SqlCommand cmd = new SqlCommand(SQLDelete, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la instruccion
                cmd.ExecuteNonQuery();
                //Cerrar la coneccion con la BD si se encuentra abierta
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Genera un codigo de producto a partir del nombre del producto + 5 letras random
        public string GenerateProductCode(string nombre)
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