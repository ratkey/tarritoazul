using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tarritoazul.com.Models
{
    public class Etiqueta
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        public Etiqueta()
        {
            Id_Etiqueta = -1;
        }

        public int Id_Etiqueta { get; set; }
        public string Nombre { get; set; }

        public void SelectFromDB(int id_etiqueta)
        {
            SqlCommand command = new SqlCommand("Select * from [ETIQUETAS] where Id_Etiqueta=@idp", con);
            command.Parameters.AddWithValue("@idp", id_etiqueta);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id_Etiqueta = (int)reader["id_etiqueta"];
                        Nombre = (string)reader["nombre"];
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
            //Definir la consulta
            string SQLInsert = String.Format("insert into ETIQUETAS(nombre) output INSERTED.id_etiqueta " +
            "values('{0}');", Nombre);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la insercion y obtener el ID generado
                Id_Etiqueta = (int)cmd.ExecuteScalar();
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
            string SQLUpdate = String.Format("update ETIQUETAS " +
                "set nombre='{0}' " +
                "where id_etiqueta={1};", Nombre, Id_Etiqueta);

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
            string SQLDelete = String.Format("delete from ETIQUETAS where id_etiqueta = {0};", Id_Etiqueta);

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

        public override string ToString()
        {
            return "id_etiqueta: " + Id_Etiqueta + " nombre: " + Nombre;
        }
    }
}