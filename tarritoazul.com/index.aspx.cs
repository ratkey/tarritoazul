using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tarritoazul.com
{
    public partial class index : System.Web.UI.Page
    {
        public static string imagespath = "imgs/producto/";
        protected void Page_Load(object sender, EventArgs e)
        {
            string imagen = imagespath + "arete02.jpg";
            string nombre = "Place holder";
            double precio = 32;
            string descripcion = "Unos aretes, que mas quieres?";

            string card = string.Format(@"
                <div class=""card"">
                    <img src=""{0}"" style=""width:100%"">
                    <h1>{1}</h1>
                    <p class=""price"">${2}</p>
                    <p class=""descripcion"">{3}</p>
                    <p><button>Añadir al carrito</button></p>
                </div>", imagen, nombre, precio, descripcion);
            label1.Text = card;
        }
    }
}