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

        public override string ToString()
        {
            return "id_media: " +Id_Media+ "src_url: " +Src_Url+ "tipo: " +Tipo+ "id_producto: " + Id_Producto;
        }
    }
}