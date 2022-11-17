using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace tarritoazul.com.Models
{
    public class Domicilio
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        public Domicilio()
        {
            Id_domicilio = -1;
        }

        public int Id_domicilio { get; set; }
        public int Id_envio { get; set; }
        public int Id_usuario { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public int Numero_interior { get; set; }
        public int Numero_exterior { get; set; }
        public int Codigo_postal { get; set; }
        public string Descripcion_domicilio { get; set; }

        public void SelectFromDB(int id_domicilio)
        {
            SqlCommand command = new SqlCommand("Select * from [DOMICILIOS] where id_domicilio=@idp", con);
            command.Parameters.AddWithValue("@idp", id_domicilio);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id_domicilio = (int)reader["id_domicilio"];
                        Id_envio = (int)reader["id_envio"];
                        Id_usuario = (int)reader["id_usuario"];
                        Colonia = (string)reader["colonia"];
                        Calle = (string)reader["calle"];
                        Numero_exterior = (int)reader["numero_exterior"];
                        Numero_interior = (int)reader["numero_interior"];
                        Codigo_postal = (int)reader["codigo_postal"];
                        Descripcion_domicilio = (string)reader["descripcion_domicilio"];
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
            string SQLInsert = String.Format("insert into DOMICILIOS(id_envio, id_usuario, colonia, calle, numero_exterior, numero_interior, codigo_postal, descripcion_domicilio) output INSERTED.id_domicilio " +
            "values({0},{1},'{2}','{3}',{4},{5},{6},'{7}');", Id_envio, Id_usuario, Colonia, Calle, Numero_exterior, Numero_interior, Codigo_postal, Descripcion_domicilio);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la insercion y obtener el ID generado
                Id_domicilio = (int)cmd.ExecuteScalar();
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
            string SQLUpdate = String.Format("update DOMICILIOS " +
                "set id_envio={0}, id_usuario={1}, colonia='{2}', calle='{3}', numero_exterior={4}, numero_interior={5}, codigo_postal={6}, descripcion_domicilio={7} " +
                "where id_domicilio={8};", Id_envio, Id_usuario, Colonia, Calle, Numero_exterior, Numero_interior, Codigo_postal, Descripcion_domicilio, Id_domicilio);

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
            string SQLDelete = String.Format("delete from DOMICILIOS where id_domicilio = {0};", Id_domicilio);

            SqlCommand cmd = new SqlCommand(SQLDelete, con);

            try
            {
                //Abrir la conexion con la BD
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

     

        public string ToString()
        {
            return "id_domicilio: " + Id_domicilio + ", id_envio : " + Id_envio + ", id_usuario: " + Id_usuario +
                ", colonia: " + Colonia + ", calle: " + Calle + ", numero_exterior: " + Numero_exterior + ", numero_interior: " + Numero_interior;
        }
    }
}