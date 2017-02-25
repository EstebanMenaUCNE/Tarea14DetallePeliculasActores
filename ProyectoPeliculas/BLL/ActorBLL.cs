using ProyectoPeliculas.DAL;
using ProyectoPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoPeliculas.BLL
{
    public class ActorBLL
    {
        public static bool Guardar(Actor actor)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    if (Buscar(actor.ActorId) == null)
                    {
                        db.Actores.Add(actor);
                    }
                    else
                    {
                        db.Entry(actor).State = EntityState.Modified;
                    }
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

        public static Actor Buscar(int id)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    return db.Actores.Find(id);
                }
                catch (Exception)
                {
                    return null;
                    throw;
                }
            }
        }

        public static List<Actor> GetList()
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    return db.Actores.ToList();
                }
                catch (Exception)
                {
                    return new List<Actor>();
                    throw;
                }
            }
        }
    }
}
