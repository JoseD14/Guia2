using Microsoft.EntityFrameworkCore;

namespace MVCPelicula_DH211056.Models
{
    public class PeliculasDBContext: DbContext
    {
        public PeliculasDBContext(DbContextOptions options): base(options) { }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Generos { get; set; }

    }
}
