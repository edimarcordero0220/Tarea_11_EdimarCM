using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Peliculas
    {
        [Key]
        public int IdPelicula { get; set; }

        public DateTime Estreno { get; set; }

        public  string Descripcion { get; set; }

        public int CategoriId { get; set; }
    }
}
