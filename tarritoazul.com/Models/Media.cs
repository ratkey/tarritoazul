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

        public Media()
        {
            Id_Media = -1;
        }

        public int Id_Media { get; set; }
        public string Src_Url { get; set; }
        public string Tipo { get; set; }
        public int Id_Producto { get; set; }
    }
}
