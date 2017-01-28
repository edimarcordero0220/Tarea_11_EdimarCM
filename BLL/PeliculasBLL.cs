using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class PeliculasBLL
    {
        public static void Insertar(Peliculas p)
        {
            try
            {
                Registros_tarea11 db = new Registros_tarea11();
                db.Pelicula.Add(p);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Eliminar(Peliculas p)
        {
            Registros_tarea11 db = new Registros_tarea11();
            Peliculas peli = db.Pelicula.Find(p);

            db.Pelicula.Remove(peli);
            db.SaveChanges();
        }
        public static Peliculas Buscar(int Id)
        {
            Registros_tarea11 db = new Registros_tarea11();
            return db.Pelicula.Find(Id);
        }
        public static void Eliminar(int v)
        {
            Registros_tarea11 db = new Registros_tarea11();
            Peliculas peli = db.Pelicula.Find(v);
            try
            {
                db.Pelicula.Remove(peli);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Peliculas> GetListaPeliculas(string tmp)
        {
            List<Peliculas> lista = new List<Peliculas>();
            Registros_tarea11 db = new Registros_tarea11();
            lista = db.Pelicula.Where(p => p.Descripcion == tmp).ToList();
            return lista;
        }
        
        public static List<Peliculas> GetLista()
        {
            List<Peliculas> lista = new List<Peliculas>();
            Registros_tarea11 db = new Registros_tarea11();
            lista = db.Pelicula.ToList();
            return lista;
        }
        public static List<Peliculas> GetLista(int peliculaid)
        {
            List<Peliculas> lista = new List<Peliculas>();
            Registros_tarea11 db = new Registros_tarea11();
            lista = db.Pelicula.Where(p => p.IdPelicula == peliculaid).ToList();
            return lista;

        }
    }
}
