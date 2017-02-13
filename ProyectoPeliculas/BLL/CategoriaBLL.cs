using ProyectoPeliculas.DAL;
using ProyectoPeliculas.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoPeliculas.BLL
{
    public class CategoriaBLL
    {
        public static bool Guardar(Categoria categoria)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    if (Buscar(categoria.CategoriaId) == null)
                    {
                        db.Categorias.Add(categoria);
                        db.SaveChanges();
                        return true;
                    }
                    else
                    {
                        db.Entry(categoria).State = EntityState.Modified;
                        db.SaveChanges();
                        return true;
                    }
                    
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
                
            }
        }

        /*public static bool Modificar(Categoria categoria)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    db.Entry(categoria).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
        }*/

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

        public static Categoria Buscar(int id)
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    return db.Categorias.Find(id);
                }
                catch (Exception)
                {
                    return null;
                    throw;
                }
            }
        }

        public static List<Categoria> GetList()
        {
            using (var db = new PeliculasDb())
            {
                try
                {
                    return db.Categorias.ToList();
                }
                catch (Exception)
                {
                    return new List<Categoria>();
                    throw;
                }
            }
        }
    }
}
