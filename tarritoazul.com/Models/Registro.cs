using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tarritoazul.com.Models
{
    public class Registro
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        public Registro()
        {
            Id_Registro = -1;
        }

        public int Id_Registro { get; set; }
        public string Usuario { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public void SelectFromDB(int id_registro)
        {
            SqlCommand command = new SqlCommand("Select * from [REGISTROS] where id_registro=@idp", con);
            command.Parameters.AddWithValue("@idp", id_registro);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id_Registro = (int)reader["id_registro"];
                        Usuario = (string)reader["Usuario"];
                        Correo = (string)reader["Correo"];
                        Contrasena = (string)reader["Contrasena"];
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
            string SQLInsert = String.Format("insert into REGISTROS( usuario, correo, contrasena) output INSERTED.id_registro " +
            "values('{0}','{1}','{2}');", Usuario, Correo, Contrasena);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la insercion y obtener el ID generado
                Id_Registro = (int)cmd.ExecuteScalar();
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
            string SQLUpdate = String.Format("update REGISTROS " +
                "set usuario='{0}', correo='{1}', contrasena='{2}'" +
                "where id_registro={3};", Usuario, Correo, Contrasena, Id_Registro);

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
            string SQLDelete = String.Format("delete from REGISTROS where id_registro = {0};", Id_Registro);

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
            return "id_registro: " + Id_Registro + ", usuario: " + Usuario +
                ", correo: " + Correo + ", contrasena: " + Contrasena;
        }
    }
}