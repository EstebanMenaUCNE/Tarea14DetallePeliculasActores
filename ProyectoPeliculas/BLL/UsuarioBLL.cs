using ProyectoPeliculas.DAL;
using ProyectoPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoPeliculas.BLL
{
    public class UsuarioBLL
    {
        public static bool Guardar(Usuario usuario)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    if (Buscar(usuario.UsuarioId) == null)
                    {
                        db.Usuarios.Add(usuario);
                    }
                    else
                    {
                        db.Entry(usuario).State = EntityState.Modified;
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

        public static Usuario Buscar(int id)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    return db.Usuarios.Find(id);
                }
                catch (Exception)
                {
                    return null;
                    throw;
                }
            }
        }

        public static List<Usuario> GetList()
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    return db.Usuarios.ToList();
                }
                catch (Exception)
                {
                    return new List<Usuario>(); 
                    throw;
                }
            }
        }

    }
}
