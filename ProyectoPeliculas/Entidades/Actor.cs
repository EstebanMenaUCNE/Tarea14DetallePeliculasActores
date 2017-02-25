using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoPeliculas.Entidades
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string Nombres { get; set; }
        public virtual List<Pelicula> Peliculas { get; set; }

        public Actor()
        {
            Peliculas = new List<Pelicula>();
        }

        public Actor(int actorId, string nombres)
        {
            ActorId = actorId;
            Nombres = nombres;
            Peliculas = new List<Pelicula>();
        }
    }
}
