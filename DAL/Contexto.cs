using Microsoft.EntityFrameworkCore;

public class Contexto: DbContext
{
    public DbSet<Orden>? Orden { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            
        }
}