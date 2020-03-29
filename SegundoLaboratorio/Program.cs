using System;

namespace SegundoLaboratorio
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cancion primera = new Cancion("lights","Hola","ellie","pop");
            Console.WriteLine(primera.Informacion());
        }
    }
}
