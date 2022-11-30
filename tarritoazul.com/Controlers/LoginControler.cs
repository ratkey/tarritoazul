using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace tarritoazul.com.Models
{
    public class LoginControler
    {
        public static readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["TAConnectionString"].ConnectionString);

        /// <summary>
        /// validar login y retorna el id del login, si no existe: retorna -1
        /// </summary>
        /// <param name="user"></param>
        /// <param name="contr"></param>
        /// <returns></returns>
        public static int ValidarLogin(string user, string contr)
        {
            string SQLSelect = String.Format("select * from REGISTROS where (usuario='{0}' or correo='{1}') and contrasena='{2}'", user, user, contr);
            SqlCommand comm = new SqlCommand(SQLSelect, con);
            try
            {
                con.Open();
                int id_registro = Convert.ToInt32(comm.ExecuteScalar());
                con.Close();
                if (id_registro != 0)
                {
                    //HttpContext.Current.Session["registro"] = id_registro;
                    return id_registro;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
            return -1;
        }
    }
}