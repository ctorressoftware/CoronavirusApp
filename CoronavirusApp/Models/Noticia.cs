using System;

namespace CoronavirusApp.Models
{
    public class Noticia
    {
        public string Titulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string Descripcion { get; set; }
        public string Autor { get; set; }
    }
}