internal class Domicilio
{
    public Domicilio()
    {
        Id_domicilio = -1;
    }

    public int Id_domicilio { get; set; }
    public string Codigo_postal { get; set; }
    public string Estado { get; set; }
    public string Municipio { get; set; }
    public string Colonia { get; set; }
    public string Calle { get; set; }
    public string Numero_interior { get; set; }
    public string Numero_exterior { get; set; }
    public string Entre_calle_1 { get; set; }
    public string Entre_calle_2 { get; set; }
    public string Descripcion_domicilio { get; set; }
    public int Id_usuario { get; set; }

    public override string ToString()
    {
        return "id_domicilio: " + Id_domicilio + ", codigo_postal : " + Codigo_postal + ", estado: " + Estado +
            ", municipio: " + Municipio + ", colonia: " + Colonia + ", calle: " + Calle + ", numero_exterior: " + Numero_exterior +
            ", numero_interior: " + Numero_interior + ", entre_calle_1: " + Entre_calle_1 + ", entre_calle_2: " + Entre_calle_2 + ", descripcion_domicilio: " + Descripcion_domicilio + ", id_usuario: " + Id_usuario;
    }
}