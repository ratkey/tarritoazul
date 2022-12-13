using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Tarritoazul.Models;

namespace Tarritoazul.Controllers
{
    public class DomicilioController
    {
        private static readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        //Retorna un domicilio de la BD segun su id_domicilio
        public static Domicilio SelectById(int id_domicilio)
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
                        Domicilio d = new Domicilio();
                        d.Id_domicilio = (int)reader["id_domicilio"];
                        d.Codigo_postal = (string)reader["codigo_postal"];
                        d.Estado = (string)reader["estado"];
                        d.Municipio = (string)reader["municipio"];
                        d.Colonia = (string)reader["colonia"];
                        d.Calle = (string)reader["calle"];
                        d.Numero_exterior = (string)reader["numero_exterior"];
                        d.Numero_interior = (string)reader["numero_interior"];
                        d.Entre_calle_1 = (string)reader["entre_calle_1"];
                        d.Entre_calle_2 = (string)reader["entre_calle_2"];
                        d.Descripcion_domicilio = (string)reader["descripcion_domicilio"];
                        d.Id_usuario = (int)reader["id_usuario"];

                        con.Close();
                        return d;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            con.Close();
            return null;
        }

        //obtiene todos los Domicilios perteneceientes a un usuario
        public static List<Domicilio> GetDomiciliosByIdUsuario(string id_usuario)
        {
            List<Domicilio> domicilios = new List<Domicilio>();
            string SQLSelect = string.Format("Select * from [DOMICILIOS] where id_usuario='{0}'", id_usuario);
            SqlCommand command = new SqlCommand(SQLSelect, con);
            try
            {
                con.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Domicilio d = new Domicilio();
                        d.Id_domicilio = (int)reader["id_domicilio"];
                        d.Codigo_postal = (string)reader["codigo_postal"];
                        d.Estado = (string)reader["estado"];
                        d.Municipio = (string)reader["municipio"];
                        d.Colonia = (string)reader["colonia"];
                        d.Calle = (string)reader["calle"];
                        d.Numero_exterior = (string)reader["numero_exterior"];
                        d.Numero_interior = (string)reader["numero_interior"];
                        d.Entre_calle_1 = (string)reader["entre_calle_1"];
                        d.Entre_calle_2 = (string)reader["entre_calle_2"];
                        d.Descripcion_domicilio = (string)reader["descripcion_domicilio"];
                        d.Id_usuario = (int)reader["id_usuario"];

                        domicilios.Add(d);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

            con.Close();
            return domicilios;
        }

        public static Domicilio Insertar(Domicilio d) //insertar Domicilio a la BD y obtener el ID
        {
            //Definir la consulta
            string SQLInsert = String.Format("insert into DOMICILIOS(codigo_postal, estado, municipio, colonia, calle, numero_exterior, numero_interior, entre_calle_1, entre_calle_2, descripcion_domicilio, id_usuario) output INSERTED.id_domicilio " +
            "values({0},'{1}','{2}','{3}','{4}',{5},{6},'{7}','{8}','{9}',{10});", d.Codigo_postal, d.Estado, d.Municipio, d.Colonia, d.Calle, d.Numero_exterior, d.Numero_interior, d.Entre_calle_1, d.Entre_calle_2, d.Descripcion_domicilio, d.Id_usuario);

            SqlCommand cmd = new SqlCommand(SQLInsert, con);

            try
            {
                //Abrir la coneccion con la BD
                con.Open();
                //Ejecutar la insercion y obtener el ID generado
                d.Id_domicilio = (int)cmd.ExecuteScalar();

                //Cerrar la coneccion con la BD si se encuentra abierta
                con.Close();
                return d;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            con.Close();
            return null;
        }

        public static void Actualizar(Domicilio d)
        {
            //Definir la consulta
            string SQLUpdate = String.Format("update DOMICILIOS " +
                "set codigo_postal={0}, estado='{1}', municipio='{2}', colonia='{3}', calle='{4}', numero_exterior={5}, numero_interior={6}, entre_calle_1='{7}', entre_calle_2='{8}', descripcion_domicilio='{9}', id_usuario={10} " +
                "where id_domicilio={11};", d.Codigo_postal, d.Estado, d.Municipio, d.Colonia, d.Calle, d.Numero_exterior, d.Numero_interior, d.Entre_calle_1, d.Entre_calle_2, d.Descripcion_domicilio, d.Id_usuario, d.Id_domicilio);
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
                throw new Exception(ex.Message);
            }
        }

        public static void Eliminar(Domicilio d)
        {
            //Definir la consulta
            string SQLDelete = String.Format("delete from DOMICILIOS where id_domicilio = {0};", d.Id_domicilio);

            SqlCommand cmd = new SqlCommand(SQLDelete, con);

            try
            {
                //Abrir la conexion con la BD
                con.Open();
                //Ejecutar la instruccion
                cmd.ExecuteNonQuery();
                //Cerrar la coneccion con la BD si se encuentra abierta
                con.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}