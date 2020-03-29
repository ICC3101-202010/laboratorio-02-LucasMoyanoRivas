using System;
namespace SegundoLaboratorio
{
    public class Cancion
    {
        private string nombre;
        private string album;
        private string artista;
        private string genero;
        public Cancion(string nombre, string album, string artista, string genero)
        {
            this.nombre = nombre;
            this.album = album;
            this.artista = artista;
            this.genero = genero;

        }
        public string Informacion()
        {
            string info;
            info = $"genero: {genero}, artista: {artista}, album: {album}, nombre: {nombre}";
            return info;
        }
    }
}
