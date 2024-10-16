public class Personajes
{
    public int Id {get;set;}
    public string Nombre {get;set;} = string.Empty;
    public string Alias {get;set;} = string.Empty;
    public string Rol {get;set;} = string.Empty;
    public string Habilidad {get;set;} = string.Empty;
    public string Arma {get;set;} = string.Empty;
    public int NivelPoder {get;set;} = 0;
    public string ImagenPortada {get;set;} = string.Empty;
    public int VideoJuegoId {get;set;}
    public VideoJuegos VideoJuegos {get;set;} = new VideoJuegos();
}