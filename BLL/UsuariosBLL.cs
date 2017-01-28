using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class UsuariosBLL
    {
        public static void Insertar(Usuarios u)
        {
            try
            {
                Registros_tarea11 db = new Registros_tarea11();
                db.Usuario.Add(u);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Eliminar(Usuarios u)
        {
            Registros_tarea11 db = new Registros_tarea11();
            Usuarios usu = db.Usuario.Find(u);

            db.Usuario.Remove(usu);
            db.SaveChanges();
        }
        public static Usuarios Buscar(int Id)
        {
            Registros_tarea11 db = new Registros_tarea11();
            return db.Usuario.Find(Id);
        }
        public static void Eliminar(int v)
        {
            Registros_tarea11 db = new Registros_tarea11();
            Usuarios usu = db.Usuario.Find(v);
            try
            {
                db.Usuario.Remove(usu);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Usuarios> GetListaNombre(string tmp)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Registros_tarea11 db = new Registros_tarea11();
            lista = db.Usuario.Where(p => p.Nombre == tmp).ToList();
            return lista;
        }
        public static List<Usuarios> GetClave(string tmp)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Registros_tarea11 db = new Registros_tarea11();
            lista = db.Usuario.Where(p => p.Clave == tmp).ToList();
            return lista;
        }
        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();
            Registros_tarea11 db = new Registros_tarea11();
            lista = db.Usuario.ToList();
            return lista;
        }
        public static List<Usuarios> GetLista(int usuarioId)
        {
            List<Usuarios> lista = new List<Usuarios>();
            Registros_tarea11 db = new Registros_tarea11();
            lista = db.Usuario.Where(p => p.UsuarioId == usuarioId).ToList();
            return lista;

        }
    }
    
}
