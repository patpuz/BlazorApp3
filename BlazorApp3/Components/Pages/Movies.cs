using Microsoft.EntityFrameworkCore;
using System;

namespace BlazorApp3.Components.Pages
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MoviesDbContext(DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Ratings)
                .WithOne(r => r.Movie)
                .HasForeignKey(r => r.MovieId)
                .IsRequired();
        }
    }
}
