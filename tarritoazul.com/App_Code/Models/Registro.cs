internal class Registro
{
    public Registro()
    {
        Id_Registro = -1;
    }

    public int Id_Registro { get; set; }
    public string Usuario { get; set; }
    public string Correo { get; set; }
    public string Contrasena { get; set; }

    public override string ToString()
    {
        return "id_registro: " + Id_Registro + ", usuario: " + Usuario +
            ", correo: " + Correo + ", contrasena: " + Contrasena;
    }
}