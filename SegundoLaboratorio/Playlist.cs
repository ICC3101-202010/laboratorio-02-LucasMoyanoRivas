using System;
using System.Collections.Generic;
namespace SegundoLaboratorio
{
    public class Playlist
    {
        private string nombre;
        private List <Cancion> canciones = new List<Cancion>();
        public Playlist(string nombre, List <Cancion> canciones)
        {
            this.nombre = nombre;
            this.canciones = canciones;
        }
        public string GetNombre()
        {
            return nombre;
        }
    }
}
