using System;
using System.Collections.Generic;

namespace SegundoLaboratorio
{
    public class Espotifai
    {
        private List<string> songs = new List<string>();
        private List<string> album = new List<string>();
        private List<string> artist = new List<string>();
        private List<string> gender = new List<string>();
        public Espotifai(Cancion song)
        {
            songs.Add(song.GetName());
            album.Add(song.GetAlbum());
            artist.Add(song.GetArtist());
            gender.Add(song.GetGender());
        }
        public bool AgregarCancion(Cancion song1)
        {
            if (songs.Contains(song1.GetName()) == true)
            {
                return true;
            }
            else if (album.Contains(song1.GetAlbum()) == true)
            {
                return true;
            }
            else if (artist.Contains(song1.GetArtist()) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void VerCanciones()
        {
            Console.WriteLine($"Cancion:{songs[0]}, Album: {album[0]}, Artista: {artist[0]}, Genero:{gender[0]}");
        }
        public Cancion[] CancionesPorCriterio(string criterio, string valor)
        {
            if (criterio == "nombre" || criterio == "álbum" || criterio == "artista" || criterio == "género")
            {
                if (songs.Contains(valor) == true)
                {
                    Console.WriteLine($"Canciones con el criterio: {criterio}");
                    Cancion buscada = new Cancion(valor, "", "", "");
                    Cancion[] canciones = {buscada};
                    return canciones;
                }
                else if (album.Contains(valor) == true)
                {
                    Console.WriteLine($"Canciones con el criterio: {criterio}");
                    Cancion buscada = new Cancion("", valor, "", "");
                    Cancion[] canciones = { buscada };
                    return canciones;
                }
                else if (artist.Contains(valor) == true)
                {
                    Console.WriteLine($"Canciones con el criterio: {criterio}");
                    Cancion buscada = new Cancion("", "", valor, "");
                    Cancion[] canciones = { buscada };
                    return canciones;
                }
                else if (gender.Contains(valor) == true)
                {
                    Console.WriteLine($"Canciones con el criterio: {criterio}");
                    Cancion buscada = new Cancion("", "", "", valor);
                    Cancion[] canciones = { buscada };
                    return canciones;
                }
                else
                {
                    Console.WriteLine("El valor elegido para el criterio seleccionado no es valido");
                    Cancion[] buscada = { };
                    return buscada;
                }

            }
            else
            {
                Console.WriteLine("El criterio seleccionado no es valido");
                Cancion[] buscada = { };
                return buscada;
            }

  

        }
    }

}