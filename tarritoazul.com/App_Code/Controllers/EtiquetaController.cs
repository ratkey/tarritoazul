using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

internal class EtiquetaController
{
    private readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

    //obtiene todos los Prodctos de la base de datos
    public List<Etiqueta> GetAllEtiqueta()
    {
        List<Etiqueta> Etiqueta = new List<Etiqueta>();
        SqlCommand command = new SqlCommand("Select * from [ETIQUETAS]", con);
        try
        {
            con.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Etiqueta p = new Etiqueta();
                    p.Id_Etiqueta = (int)reader["id_etiqueta"];
                    p.Nombre = (string)reader["nombre"];

                    Etiqueta.Add(p);
                }
            }

            if (con.State == System.Data.ConnectionState.Open)
                con.Close();

            return Etiqueta;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
            return null;
        }
    }

    //Cambiar este metodo al modelo MediaModel
    public string GetPEtiquetaMedia(int id_etiqueta)
    {
        string url = "";
        SqlCommand command = new SqlCommand("Select top 1 src_url from [MEDIA] join [ETIQUETAS] on ETIQUETAS.id_etiqueta = MEDIA.id_etiqueta and ETIQUETAS.id_ = " + id_etiqueta, con);
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
            throw new Exception(ex.Message);
        }
        return url;
    }

    //Regresa un prodcuto de la BD basado en su id_producto
    public Etiqueta SelectById(int id)
    {
        SqlCommand command = new SqlCommand("Select * from [ETIQUETAS] where id_etiqueta=@idp", con);
        command.Parameters.AddWithValue("@idp", id);
        try
        {
            con.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Etiqueta p = new Etiqueta();
                    p.Id_Etiqueta = (int)reader["id_etiqueta"];
                    p.Nombre = (string)reader["nombre"];

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
            throw new Exception(ex.Message);
            return null;
        }
    }

    public Etiqueta Insertar(Etiqueta p) //insertar Etiqueta a la BD y obtener el ID
    {
        //Definir la consulta
        string SQLInsert = String.Format("insert into ETIQUETAS(id_Etiqueta, nombre) output INSERTED.id_etiqueta" +
        "values({0},{1}", p.Nombre, p.Id_Etiqueta);

        SqlCommand cmd = new SqlCommand(SQLInsert, con);

        try
        {
            //Abrir la coneccion con la BD
            con.Open();
            //Ejecutar la insercion y obtener el ID generado
            p.Id_Etiqueta = (int)cmd.ExecuteScalar();
            //Cerrar la coneccion con la BD si se encuentra abierta
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            return p;
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message);
            return null;
        }
    }

    public void Actualizar(Etiqueta p)
    {
        //Definir la consulta
        string SQLUpdate = String.Format("update ETIQUETA " + "set nombre='{0}', " + "where id_etiqueta={6};", p.Nombre, p.Id_Etiqueta);

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
            throw new Exception(ex.Message);
        }
    }

    public void Eliminar(Etiqueta p)
    {
        //Definir la consulta
        string SQLDelete = String.Format("delete from ETIQUETAS where id_etiqueta = {0};", p.Id_Etiqueta);

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
            throw new Exception(ex.Message);
        }
    }
}