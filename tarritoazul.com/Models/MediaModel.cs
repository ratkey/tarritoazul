using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Windows.Forms;
using tarritoazul.com.taTableAdapters;

namespace tarritoazul.com.Models
{
    public class Media
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        public Media()
        {
            Id_Media = -1;
        }

        public int Id_Media { get; set; }
        public string src_url { get; set; }
        public string Tipo { get; set; }
        public int Id_Producto { get; set; }

        public void SelectFromDB(int id_media)
        {
            SqlCommand command = new SqlCommand("Select * from [MEDIA] where id_media=@idm", con);
            command.Parameters.AddWithValue("@idm", id_media);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Id_media = (int)reader["id_media"];
                        src_url = (string)reader["src_url"];
                        tipo = (string)reader["tipo"];
                        id_producto = (int)reader["id_producto"];
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

        public void Insertar()
        {

            //Definir la consulta
            string SQLInsert = String.Format("insert into MEDIA(src_url, tipo, id_producto) output INSERTED.id_media " +
            "values('{0}','{1}','{2}','{3}');", src_url, tipo, id_producto);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la insercion y obtener el ID generado
                Id_media = (int)cmd.ExecuteScalar();
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
            string SQLUpdate = String.Format("update MEDIA " +
                "set src_url='{0}', tipo='{1}', id_producto={2}, " +
                "where id_media={3};", src_url, tipo, id_producto);

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
            string SQLDelete = String.Format("delete from MEDIA where id_media = {0};", Id_media);

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

        public string ToString()
        {
            return "id_media: " + Id_media + ", src_url: " + src_url + ", tipo: " + tipo + ", id_producto: " + id_producto;
        }
    }
}