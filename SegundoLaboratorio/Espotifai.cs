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
        private List<string> criterioCancion = new List<string>();
        private List<string> criterioAlbum = new List<string>();
        private List<string> criterioArtista = new List<string>();
        private List<string> criterioGenero = new List<string>();
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
            if (criterio == "nombre")
            {
                if (songs.Contains(valor) == true)
                {
                    Cancion busqueda = new Cancion(valor, album[0], artist[0], gender[0]);

                    return busqueda;
                }
                else
                {
                    Console.WriteLine($"No se ha encontrado en el Criterio seleccionado el valor escogido.");
                }
            }
            else if (criterio == "álbum")
            {
                if (album.Contains(valor) == true)
                {
                    Console.WriteLine($"Cancion:{songs[0]}, Album: {album[0]}, Artista: {artist[0]}, Genero:{gender[0]}");
                }
                else
                {
                    Console.WriteLine("No se ha encontrado en el Criterio seleccionado para el valor escogido");
                }

            }
            else if (criterio == "artista")
            {
                if (artist.Contains(valor) == true)
                {
                    Console.WriteLine($"Cancion:{songs[0]}, Album: {album[0]}, Artista: {artist[0]}, Genero:{gender[0]}");
                }
                else
                {
                    Console.WriteLine("No se ha encontrado en el Criterio seleccionado el valor escogido");
                }

            }
            else if (criterio == "genero")
            {
                if (gender.Contains(valor) == true)
                {
                    Console.WriteLine($"Cancion:{songs[0]}, Album: {album[0]}, Artista: {artist[0]}, Genero:{gender[0]}");
                }
                else
                {
                    Console.WriteLine("No se ha encontrado en el Criterio seleccionado el valor escogido");
                }

            }
            else
            {
                Console.WriteLine("El criterio seleccionado no es valido");
            }

        }
    }

}