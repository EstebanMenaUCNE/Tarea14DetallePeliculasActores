using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoPeliculas.Entidades
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }
        //public List<Pelicula> Peliculas { get; set; }

        public Categoria()
        {
            //Peliculas = new List<Pelicula>();
        }

        public Categoria(int categoriaId, string descripcion)
        {
            CategoriaId = categoriaId;
            Descripcion = descripcion;
            //Peliculas = new List<Pelicula>();
        }
    }
}
