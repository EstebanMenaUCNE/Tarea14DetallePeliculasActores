using ProyectoPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoPeliculas.DAL
{
    public class PeliculasDb : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Actor> Actores { get; set; }

        public PeliculasDb() : base("ConStr")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entidades.Actor>()
                .HasMany(actor => actor.Peliculas)
                .WithMany(pelicula => pelicula.Actores)
                .Map(Peliculasactores =>
                {
                    Peliculasactores.MapLeftKey("PeliculaId");
                    Peliculasactores.MapRightKey("ActorId");
                    Peliculasactores.ToTable("PeliculasActores");
                }
                );
        }
    }
}
