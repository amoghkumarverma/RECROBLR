using Microsoft.EntityFrameworkCore;
using RECROBLR.Models;

namespace RECROBLR.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions DbContextOptions) : base(DbContextOptions)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Generes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ActorMovie> ActorMovies { get; set; }


    }
}
