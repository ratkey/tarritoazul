using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using tarritoazul.com.forms;

namespace tarritoazul.com.Models
{
    public class ProductoModel
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

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
    }

    
}