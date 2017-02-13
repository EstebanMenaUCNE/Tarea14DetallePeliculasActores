using ProyectoPeliculas.DAL;
using ProyectoPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoPeliculas.BLL
{
    public class PeliculaBLL
    {
        public static bool Guardar(Pelicula pelicula)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    db.Peliculas.Add(pelicula);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }

            }

        }

        public static bool Eliminar(int id)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    db.Entry(Buscar(id)).State = EntityState.Deleted;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        public static Pelicula Buscar(int id)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    return db.Peliculas.Find(id);
                }
                catch (Exception)
                {
                    return null;
                    throw;
                }
            }
        }

        public static List<Pelicula> GetList()
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    return db.Peliculas.ToList();
                }
                catch (Exception)
                {
                    return new List<Pelicula>();
                    throw;
                }
            }
        }

        public static List<Pelicula> GetListDate(DateTime Desde, DateTime Hasta)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    return db.Peliculas.Where(P => P.Estreno >= Desde.Date && P.Estreno <= Hasta.Date).ToList();
                }
                catch (Exception)
                {
                    return new List<Pelicula>();
                    throw;
                }
            }
        }

        public static List<Pelicula> GetListDescripcion(string descripcion)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    return db.Peliculas.Where(P => P.Descripcion == descripcion).ToList();
                }
                catch (Exception)
                {
                    return new List<Pelicula>();
                    throw;
                }
            }
        }

        public static List<Pelicula> GetListId(int id)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    return db.Peliculas.Where(P => P.PeliculaId == id).ToList();
                }
                catch (Exception)
                {
                    return new List<Pelicula>();
                    throw;
                }
            }
        }
    }
}
