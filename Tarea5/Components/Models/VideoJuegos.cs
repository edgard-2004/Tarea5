public class VideoJuegos
{
    public int Id {get;set;} 
    public string Nombre {get;set;} = string.Empty;
    public string Desarrollador {get;set;} = string.Empty;
    public string Plataforma { get; set; } = string.Empty;
    public string Genero {get;set;} = string.Empty;
    public DateTime FechaLanzamiento {get;set;} = DateTime.Now;
    public string ImagenPortada {get;set;} = string.Empty;
    public string Descripcion {get;set;} = string.Empty;
    public List<Personajes> Personajes {get;set;} = new List<Personajes>();
}