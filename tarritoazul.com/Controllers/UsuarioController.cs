using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tarritoazul.Models;

namespace Tarritoazul.Controllers
{
    public class UsuarioController
    {
        public static readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        //obtiene todos los usuaio de la base de datos
        public static List<Usuario> GetAllUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlCommand command = new SqlCommand("Select * from [USUARIOS]", con);
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
                        p.Fecha_Nacimiento = reader["fecha_nacimiento"].ToString();
                        p.Avatar_Img = (string)reader["avatar_img"];
                        p.Id_Registro = (int)reader["id_registro"];
                        p.Sexo = (string)reader["sexo"];
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

        //Regresa un usuario de la BD basado en su id_usuario
        public static Usuario SelectById(int id)
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
                        p.Fecha_Nacimiento = reader["fecha_nacimiento"].ToString();
                        p.Avatar_Img = (string)reader["avatar_img"];
                        p.Id_Registro = (int)reader["id_registro"];
                        p.Sexo = (string)reader["sexo"];
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

        //Regresa un usuario de la BD basado en su id_registro
        public static Usuario SelectByRegistroId(int id)
        {
            SqlCommand command = new SqlCommand("Select * from [USUARIOS] where id_registro=@idp", con);
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
                        p.Fecha_Nacimiento = reader["fecha_nacimiento"].ToString();
                        p.Avatar_Img = (string)reader["avatar_img"];
                        p.Id_Registro = (int)reader["id_registro"];
                        p.Sexo = (string)reader["sexo"];
                        con.Close();
                        return p;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return null;
        }

        public static Usuario Insertar(Usuario p) //insertar usuario a la BD y obtener el ID
        {
            //Definir la consulta
            string SQLInsert = String.Format("insert into USUARIOS( nombre, ap_paterno, ap_materno, telefono, fecha_nacimiento, avatar_img, id_registro, sexo) output INSERTED.id_usuario " +
            "values('{0}','{1}','{2}',{3},'{4}','{5}',{6},'{7}');", p.Nombre, p.Ap_Paterno, p.Ap_Materno, p.Telefono, p.Fecha_Nacimiento, p.Avatar_Img, p.Id_Registro, p.Sexo);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la insercion y obtener el ID generado
                p.Id_Usuario = (int)cmd.ExecuteScalar();
                //Cerrar la coneccion con la BD si se encuentra abierta
                con.Close();
                return p;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
            return null;
        }

        public static void Actualizar(Usuario p)
        {
            //Definir la consulta
            string SQLUpdate = String.Format("update USUARIOS " +
                "set nombre='{0}', ap_paterno='{1}', ap_materno='{2}', telefono='{3}', fecha_nacimiento='{4}', avatar_img='{5}', id_registro={6}, sexo='{7}' " +
                " where id_usuario={8};", p.Nombre, p.Ap_Paterno, p.Ap_Materno, p.Telefono, p.Fecha_Nacimiento, p.Avatar_Img, p.Id_Registro, p.Sexo, p.Id_Usuario);
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

        public static void ActualizarImagen(Usuario p)
        {
            //Definir la consulta
            string SQLUpdate = String.Format("update USUARIOS " +
                "set avatar_img='{0}'" +
                " where id_usuario={1};", p.Avatar_Img, p.Id_Usuario);
            MessageBox.Show(SQLUpdate);
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

        public static void Eliminar(Usuario p)
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