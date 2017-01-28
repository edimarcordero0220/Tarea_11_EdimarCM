using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
    public class Registros_tarea11:DbContext
    {
        public Registros_tarea11():base("name = ConStr")
        {
                
        }
        public virtual DbSet<Usuarios> Usuario { get; set; }
    }
}
