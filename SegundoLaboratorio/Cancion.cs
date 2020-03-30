using System;
namespace SegundoLaboratorio
{
    public class Cancion
    {
        private string name;
        private string album;
        private string artist;
        private string gender;
        public Cancion(string name, string album, string artist, string gender)
        {
            this.name = name;
            this.album = album;
            this.artist = artist;
            this.gender = gender;

        }
        public string Informacion()
        {
            string info;
            info = $"genero: {gender}, artista: {artist}, album: {album}, nombre: {name}";
            return info;
        }
        public string GetName()
        {
            return name;
        }
        public string GetAlbum()
        {
            return album;
        }
        public string GetArtist()
        {
            return artist;
        }
        public string GetGender()
        {
            return gender;
        }
    }
}