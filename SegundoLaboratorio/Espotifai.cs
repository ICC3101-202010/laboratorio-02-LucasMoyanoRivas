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
        public void CancionesPorCriterio(string criterio, string valor)
        {
            if (criterio == "nombre de la cancion")
            {
                if (songs.Contains(valor) == true)
                {
                    criterioCancion.Add(valor);
                    for (int i = 0; i < criterioCancion.Count; ++i)
                        Console.Write(criterioCancion[i]);
                }
                else
                {
                    Console.WriteLine($"No se ha encontrado en el Criterio seleccionado el valor escogido. {criterioCancion}");
                }
            }
            else if (criterio == "álbum")
            {
                if (album.Contains(valor) == true)
                {
                    criterioAlbum.Add(valor);
                    for (int i = 0; i < criterioAlbum.Count; ++i)
                        Console.Write(criterioAlbum[i]);
                }
                else
                {
                    Console.WriteLine("No se ha encontrado en el Criterio seleccionado para el valor escogido");
                    Console.WriteLine(criterioAlbum);
                }

            }
            else if (criterio == "artista")
            {
                if (artist.Contains(valor) == true)
                {
                    criterioArtista.Add(valor);
                    for (int i = 0; i < criterioArtista.Count; ++i)
                        Console.Write(criterioArtista[i]);
                }
                else
                {
                    Console.WriteLine("No se ha encontrado en el Criterio seleccionado el valor escogido");
                    Console.WriteLine(criterioArtista);
                }

            }
            else if (criterio == "genero")
            {
                if (gender.Contains(valor) == true)
                {
                    criterioGenero.Add(valor);
                    for (int i = 0; i < criterioGenero.Count; ++i)
                        Console.Write(criterioGenero[i]);
                }
                else
                {
                    Console.WriteLine("No se ha encontrado en el Criterio seleccionado el valor escogido");
                    Console.WriteLine(criterioGenero);
                }

            }
            else
            {
                Console.WriteLine("El criterio seleccionado no es valido");
                Console.WriteLine(criterioCancion);
            }

        }
    }

}