using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using tarritoazul.com.Models;

namespace tarritoazul.com.Models
{
    public class UsuarioModel
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        //obtiene todos los usuaio de la base de datos
        public List<Usuario> GetAllUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlCommand command = new SqlCommand("Select * from [USUARIO]", con);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Usuario p = new Usuario();
                        p.Id_Usuario = (int)reader["id_usuario"];
                        p.Nombre = (string)reader["nombre"];
                        p.Ap_Paterno = (string)reader["ap_paterno"];
                        p.Ap_Materno = (string)reader["ap_materno"];
                        p.Telefono = (string)reader["telefono"];
                        p.Fecha_Nacimiento = (string)reader["fecha_nacimiento"];
                        p.Avatar_Img = (string)reader["avatar_img"];
                        p.Id_Registro= (int)reader["id_registro"];
                        usuarios.Add(p);
                    }
                }

                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();

                return usuarios;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //Cambiar este metodo al modelo MediaModel
        public string GetusuarioMedia(int id_usuario)
        {
            string url = "";
            SqlCommand command = new SqlCommand("Select top 1 src_url from [MEDIA] join [USUARIOS] on USUARUIOS.id_usuario = MEDIA.id_usuario and USUARIOS.id_usuario = " + id_usuario, con);
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

        //Regresa un prodcuto de la BD basado en su id_usuario
        public Usuario SelectById(int id)
        {
            SqlCommand command = new SqlCommand("Select * from [USUARIOS] where id_usuario=@idp", con);
            command.Parameters.AddWithValue("@idp", id);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Usuario p = new Usuario();
                        p.Id_Usuario = (int)reader["id_usuario"];
                        p.Nombre = (string)reader["nombre"];
                        p.Ap_Paterno = (string)reader["ap_paterno"];
                        p.Ap_Materno = (string)reader["ap_materno"];
                        p.Telefono = (string)reader["telefono"];
                        p.Fecha_Nacimiento = (string)reader["fecha_nacimiento"];
                        p.Avatar_Img = (string)reader["avatar_img"];
                        p.Id_Registro = (int)reader["id_registro"];
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

        public Usuario Insertar(Usuario p) //insertar usuario a la BD y obtener el ID
        {
            //Definir la consulta
            string SQLInsert = String.Format("insert into USUARIOS( nombre, ap_paterno, ap_materno, telefono, fecha_nacimiento, avatar_img, id_registro) output INSERTED.id_usuario " +
            "values('{0}','{1}','{2}',{3},'{4}','{5}',{6});", p.Nombre, p.Ap_Paterno, p.Ap_Materno, p.Telefono, p.Fecha_Nacimiento, p.Avatar_Img, p.Id_Registro);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la insercion y obtener el ID generado
                p.Id_Usuario = (int)cmd.ExecuteScalar();
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

        public void Actualizar(Usuario p)
        {
            //Definir la consulta
            string SQLUpdate = String.Format("update USUARIOS " +
                "set nombre='{0}', ap_paterno='{1}', ap_materno='{2}', telefono='{3}', fecha_nacimiento='{4}', avatar_img='{5}', id_registro={6};", p.Nombre, p.Ap_Paterno, p.Ap_Materno, p.Telefono, p.Fecha_Nacimiento, p.Avatar_Img, p.Id_Registro);

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

        public void Eliminar(Usuario p)
        {
            //Definir la consulta
            string SQLDelete = String.Format("delete from Usuarios where id_usuario = {0};", p.Id_Usuario);

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