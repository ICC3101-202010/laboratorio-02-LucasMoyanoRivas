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
            Console.WriteLine("Bienvenido a tu Spotify");
            Console.WriteLine("Presiona 1 para ver todas las canciones, presione 2 para agregar una cancion, presione 3 para buscar canciones por criterio o presione 4 para salir");
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

            }
            if (numero == "4")
            {
                Console.WriteLine("Saliendo de Spotify");
            }
        }
    }
}
