namespace dich.Models
{
    using dich.DataBase;
    using System;
    using System.Data.Entity;
    using System.Linq;
    public class UserContext : DbContext
    {

        public UserContext()
            : base("name=UserContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmInCinema> FilmsInCinemas { get; set; }

        //protected void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder) => modelBuilder.Entity<User>()
        //    .HasIndex(p => p.UserLogin).IsUnique();

        //public void Lol(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder) { modelBuilder.Entity<User>().HasAlternateKey(c => c.UserLogin); }

    }

}