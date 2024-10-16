using Microsoft.EntityFrameworkCore;
using Tarea5.Components.Pages;

public class BaseDbContext : DbContext
{
    public DbSet<VideoJuegos> VideoJuegoContext {get;set;}
    public DbSet<Plataformas> PlataformaContext {get;set;}
    public DbSet <Personajes> PersonajeContext {get;set;}

    public BaseDbContext(DbContextOptions<BaseDbContext> options): base (options)
    {
        
    }
}