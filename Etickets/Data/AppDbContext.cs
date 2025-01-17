using Eticket.Models;
using Etickets.Models;

namespace Eticket.Data;

public class AppDbContext:DbContext   
{
   public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
   {
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      modelBuilder.Entity<Actor_Movie>().HasKey(am => new
      {
         am.MovieId, am.ActorId
      });
      //for movies
      modelBuilder.Entity<Actor_Movie>()
         .HasOne(m => m.Movie )
         .WithMany(am => am.Actors_Movies)
         .HasForeignKey(m => m.MovieId);
      //for actor
      modelBuilder.Entity<Actor_Movie>()
         .HasOne(m => m.Actor )
         .WithMany(am => am.Actors_Movies)
         .HasForeignKey(m => m.ActorId);

      
      base.OnModelCreating(modelBuilder);
   }

   public DbSet<Actor> Actors { get; set; }
   public DbSet<Movie> Movies { get; set; }
   public DbSet<Cinema> Cinemas { get; set; }
   public DbSet<Producer> Producers { get; set; }
}

