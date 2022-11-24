using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tarritoazul.com.Models
{
    public class MediaModel
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        //obtiene toda la Media de la base de datos
        public List<Media> GetAllMedia()
        {
            List<Media> media = new List<Media>();
            SqlCommand command = new SqlCommand("Select * from [MEDIA]", con);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Media p = new Media();
                        p.Id_Media = (int)reader["id_media"];
                        p.Src_Url = (string)reader["src_url"];
                        p.Tipo = (string)reader["tipo"];
                        p.Id_Producto = (int)reader["id_producto"];
                        media.Add(p);
                    }
                }

                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();

                return media;
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

        //Regresa una Media de la BD basado en su id_media
        public Media SelectById(int id)
        {
            SqlCommand command = new SqlCommand("Select * from [MEDIA] where id_media=@idm", con);
            command.Parameters.AddWithValue("@idm", id);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Media p = new Media();
                        p.Id_Media = (int)reader["id_media"];
                        p.Src_Url = (string)reader["src_url"];
                        p.Tipo = (string)reader["tipo"];
                        p.Id_Producto = (int)reader["id_producto"];

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

        public Media Insertar(Media p) //insertar Media a la BD y obtener el ID
        {
            //Definir la consulta
            string SQLInsert = String.Format("insert into Media(src_url, tipo, id_producto) output INSERTED.id_media  " +
            "values('{0}','{1}','{2}','{3}');", p.Src_Url, p.Tipo, p.Id_Producto);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la insercion y obtener el ID generado
                p.Id_Media = (int)cmd.ExecuteScalar();
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

        public void Actualizar(Media p)
        {
            //Definir la consulta
            string SQLUpdate = String.Format("update MEDIA " +
                 "set src_url='{0}', tipo='{1}', id_producto={2}, " +
                 "where id_media={3};", p.Src_Url, p.Tipo, p.Id_Producto);

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

        public void Eliminar(Media p)
        {
            //Definir la consulta
            string SQLDelete = String.Format("delete from MEDIA where id_media = {0};", p.Id_Media);

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

    }
}