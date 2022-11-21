using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

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

        public void SelectFromDB(int id_producto)
        {
            SqlCommand command = new SqlCommand("Select * from [PRODUCTOS] where id_producto=@idp", con);
            command.Parameters.AddWithValue("@idp", id_producto);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id_Producto = (int)reader["id_producto"];
                        Codigo_producto = (string)reader["codigo_producto"];
                        Nombre = (string)reader["nombre"];
                        Descripcion = (string)reader["descripcion"];
                        Precio = float.Parse(reader["precio"].ToString());
                        Cantidad = (int)reader["cantidad"];
                        Disponibilidad = (string)reader["disponibilidad"];
                        Id_Categoria = (int)reader["id_categoria"];
                    }
                }

                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Insertar() //insertar Producto a la BD y obtener el ID
        {
            //Genera un codigo de producto a partir del nombre
            Codigo_producto = GenerateProductCode(Nombre);
            //Definir la consulta
            string SQLInsert = String.Format("insert into PRODUCTOS(codigo_producto, nombre, precio, cantidad, descripcion, disponibilidad, id_categoria) output INSERTED.id_producto " +
            "values('{0}','{1}',{2},{3},'{4}','{5}',{6});", Codigo_producto, Nombre, Precio, Cantidad, Descripcion, Disponibilidad, Id_Categoria);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la insercion y obtener el ID generado
                Id_Producto = (int)cmd.ExecuteScalar();
                //Cerrar la coneccion con la BD si se encuentra abierta
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Actualizar()
        {
            //Definir la consulta
            string SQLUpdate = String.Format("update PRODUCTOS " +
                "set nombre='{0}', descripcion='{1}', precio={2}, cantidad={3}, disponibilidad='{4}', id_categoria={5} " +
                "where id_producto={6};", Nombre, Descripcion, Precio, Cantidad, Disponibilidad, Id_Categoria, Id_Producto);

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

        public void Eliminar()
        {
            //Definir la consulta
            string SQLDelete = String.Format("delete from PRODUCTOS where id_producto = {0};", Id_Producto);

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

        public override string ToString()
        {
            return "id_producto: " + Id_Producto + ", nombre: " + Nombre + ", descripcion: " + Descripcion +
                ", precio: " + Precio + ", cantidad: " + Cantidad + ", disponibilidad: " + Disponibilidad + ", id_categoria: " + Id_Categoria;
        }
    }
}