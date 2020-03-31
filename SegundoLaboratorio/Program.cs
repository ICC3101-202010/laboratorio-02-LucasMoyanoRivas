using System;

namespace SegundoLaboratorio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cancion primera = new Cancion("Hablamos mañana","YHLQMDLG","Bad Bunny","Trap");
            Cancion segunda = new Cancion("Goteo", "Super Sangre Joven", "Duki", "Trap");
            Cancion tercera = new Cancion("Crawling", "Hybrid Theory", "Linkin Park", "Alternative Rock");
            Espotifai cancion1 = new Espotifai(primera);
            Espotifai cancion2 = new Espotifai(segunda);
            Espotifai cancion3 = new Espotifai(tercera);
            Cancion playlist = new Cancion("", "", "", "");
            Espotifai almacenamiento = new Espotifai(playlist);
            Cancion verPlaylist = new Cancion("", "", "", "");
            Espotifai verPlaylist2 = new Espotifai(verPlaylist);
            Console.WriteLine("Bienvenido a tu Spotify");
            Console.WriteLine("Presiona 1 para ver todas las canciones, presione 2 para agregar una cancion, presione 3 para buscar canciones por criterio, presione 4 para Agregar Playlist, preione 5 para ver mis playlist o presione 6 para salir");
            string numero = Console.ReadLine();
            if (numero == "1")
            {
                cancion1.VerCanciones();
                cancion2.VerCanciones();
                cancion3.VerCanciones();
            }
            if (numero == "2")
            {
                Console.WriteLine("Ingrese el nombre");
                string nombreAgregado = Console.ReadLine();
                Console.WriteLine("Ingrese el album");
                string albumAgregado = Console.ReadLine();
                Console.WriteLine("Ingrese el artista");
                string artistaAgregado = Console.ReadLine();
                Console.WriteLine("Ingrese el Genero");
                string generoAgregado = Console.ReadLine();
                Cancion cuarta = new Cancion(nombreAgregado, albumAgregado, artistaAgregado, generoAgregado);
                Espotifai cancion4 = new Espotifai(cuarta);
                if (cancion1.AgregarCancion(cuarta) == false & cancion2.AgregarCancion(cuarta) == false & cancion3.AgregarCancion(cuarta) == false)
                {
                    Console.WriteLine("Cancion Agregada con exito");
                    cancion1.VerCanciones();
                    cancion2.VerCanciones();
                    cancion3.VerCanciones();
                    cancion4.VerCanciones();
                }
                else
                {
                    Console.WriteLine("La cancion ingresada ya existe");
                }
            }
            if (numero == "3")
            {
                Console.WriteLine("Ingrese un Criterio valido:");
                string criterioAgregado = Console.ReadLine();
                Console.WriteLine("Ingrese un valor valido:");
                string valorAgregado = Console.ReadLine();
                if (valorAgregado == primera.GetName() || valorAgregado == primera.GetAlbum() || valorAgregado == primera.GetArtist() || valorAgregado == primera.GetGender())
                {
                    cancion1.CancionesPorCriterio(criterioAgregado, valorAgregado);
                    Console.WriteLine($"{primera.GetName()} de {primera.GetArtist()} ");
                    if (valorAgregado == segunda.GetGender())
                    {
                        Console.WriteLine($"{segunda.GetName()} de {segunda.GetArtist()}");
                    }
                    else if (valorAgregado == tercera.GetGender())
                    {
                        Console.WriteLine($"{tercera.GetName()} de {tercera.GetArtist()}");
                    }
                }
                else if (valorAgregado == segunda.GetName() || valorAgregado == segunda.GetAlbum() || valorAgregado == segunda.GetArtist() || valorAgregado == segunda.GetGender())
                {
                    cancion2.CancionesPorCriterio(criterioAgregado, valorAgregado);
                    Console.WriteLine($"{segunda.GetName()} de {segunda.GetArtist()}");
                    if (valorAgregado == primera.GetGender())
                    {
                        Console.WriteLine($"{primera.GetName()} de {primera.GetArtist()} ");
                    }
                    if (valorAgregado == tercera.GetGender())
                    {
                        Console.WriteLine($"{tercera.GetName()} de {tercera.GetArtist()}");
                    }
                }
                else if (valorAgregado == tercera.GetName() || valorAgregado == tercera.GetAlbum() || valorAgregado == tercera.GetArtist() || valorAgregado == tercera.GetGender())
                {
                    cancion3.CancionesPorCriterio(criterioAgregado, valorAgregado);
                    Console.WriteLine($"{tercera.GetName()} de {tercera.GetArtist()}");
                    if (valorAgregado == primera.GetGender())
                    {
                        Console.WriteLine($"{primera.GetName()} de {primera.GetArtist()} ");
                    }
                    if (valorAgregado == segunda.GetGender())
                    {
                        Console.WriteLine($"{segunda.GetName()} de {segunda.GetArtist()}");
                    }
                }
                else
                {
                    cancion1.CancionesPorCriterio(criterioAgregado, valorAgregado);
                }
            }
            if (numero == "4")
            {
                Console.WriteLine("Ingrese un criterio valido");
                string playlistCriterio = Console.ReadLine();
                Console.WriteLine("Ingrese un valor valido");
                string playlistValor = Console.ReadLine();
                Console.WriteLine("Que nombre le desea poner a la playlist?");
                string nombrePlaylist = Console.ReadLine();
                if (playlistValor == primera.GetName() || playlistValor == primera.GetAlbum() || playlistValor == primera.GetArtist() || playlistValor == primera.GetGender())
                {
                    Console.WriteLine($"Playlist con el criterio: {playlistCriterio}");
                    Console.WriteLine($"Nombre de la Playlist: {nombrePlaylist}");
                    cancion1.GenerarPlaylist(playlistCriterio, playlistValor, nombrePlaylist);
                    if (playlistValor == segunda.GetGender())
                    {
                        cancion2.GenerarPlaylist(playlistCriterio, playlistValor, nombrePlaylist);
                    }
                    else if (playlistValor == tercera.GetGender())
                    {
                        cancion3.GenerarPlaylist(playlistCriterio, playlistValor, nombrePlaylist);
                    }
                }
                    
                else if (playlistValor == segunda.GetName() || playlistValor == segunda.GetAlbum() || playlistValor == segunda.GetArtist() || playlistValor == segunda.GetGender())
                {
                    Console.WriteLine($"Playlist con el criterio: {playlistCriterio}");
                    Console.WriteLine($"Nombre de la Playlist: {nombrePlaylist}");
                    cancion2.GenerarPlaylist(playlistCriterio, playlistValor, nombrePlaylist);
                    if (playlistValor == primera.GetGender())
                    {
                        cancion1.GenerarPlaylist(playlistCriterio, playlistValor, nombrePlaylist);
                    }
                    else if (playlistValor == tercera.GetGender())
                    {
                        cancion3.GenerarPlaylist(playlistCriterio, playlistValor, nombrePlaylist);
                    }
                }
                    
                else if (playlistValor == tercera.GetName() || playlistValor == tercera.GetAlbum() || playlistValor == tercera.GetArtist() || playlistValor == tercera.GetGender())
                {
                    Console.WriteLine($"Playlist con el criterio: {playlistCriterio}");
                    Console.WriteLine($"Nombre de la Playlist: {nombrePlaylist}");
                    cancion3.GenerarPlaylist(playlistCriterio, playlistValor, nombrePlaylist);
                    if (playlistValor == segunda.GetGender())
                    {
                        cancion2.GenerarPlaylist(playlistCriterio, playlistValor, nombrePlaylist);
                    }
                    else if (playlistValor == primera.GetGender())
                    {
                        cancion1.GenerarPlaylist(playlistCriterio, playlistValor, nombrePlaylist);
                    }
                }
                else
                {
                    cancion1.GenerarPlaylist(playlistCriterio, playlistValor, nombrePlaylist);
                }
            }
            if (numero == "5")
            {
                cancion1.VerMisPlaylists();
            }
            if (numero == "6")
            {
                Console.WriteLine("Saliendo de Spotify");
            }
        }
    }
}
