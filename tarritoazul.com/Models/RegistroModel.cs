using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tarritoazul.com.Models
{
    public class RegistroModel
    {
        private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        //validar registro
        public Registro validar_registro(string usuario, string contr)
        {
            string SQLSelect = "select * from REGISTROS where usuario='{0}' or correo='{1}' and contrasena='{2}'", usuario, usuario, contr;
            SqlCommand command = new SqlCommand(SQLSelect, con);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Registro r = new Registro();
                        r.Id_Registro = (int)reader["id_registro"];
                        r.Usuario = (string)reader["usuario"];
                        r.Correo = (string)reader["correo"];
                        r.Contrasena = (string)reader["contrasena"];
                        con.Close();
                        return r;
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

        public Registro Insertar(Registro r) //insertar Registro a la BD y obtener el ID
        {
            //Definir la consulta
            string SQLInsert = String.Format("insert into REGISTROS( usuario, correo, contrasena) output INSERTED.id_registro " +
            "values('{0}','{1}','{2}');", r.Usuario, r.Correo, r.Contrasena);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la insercion y obtener el ID generado
                r.Id_Registro = (int)cmd.ExecuteScalar();
                //Cerrar la coneccion con la BD si se encuentra abierta
                con.Close();
                return r;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void Actualizar(Registro r)
        {
            //Definir la consulta
            string SQLUpdate = String.Format("update REGISTROS " +
                "set usuario='{0}', correo='{1}', contrasena='{2}'" +
                "where id_registro={3};", r.Usuario, r.Correo, r.Contrasena, r.Id_Registro);

            SqlCommand cmd = new SqlCommand(SQLUpdate, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la instruccion
                cmd.ExecuteNonQuery();
                //Cerrar la coneccion con la BD si se encuentra abierta
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Eliminar(Registro r)
        {
            //Definir la consulta
            string SQLDelete = String.Format("delete from REGISTROS where id_registro = {0};", r.Id_Registro);

            SqlCommand cmd = new SqlCommand(SQLDelete, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la instruccion
                cmd.ExecuteNonQuery();
                //Cerrar la coneccion con la BD si se encuentra abierta
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}