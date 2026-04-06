using reproductor.Interfaces;
using System;

namespace reproductor.Modelos
{
    public class Cancion : IReproductor
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }


        public void Play()
        {
            Console.WriteLine($"Reproduciendo la canción: {Titulo} de {Artista}");
        }
        public void Stop() 
        { 
            Console.WriteLine($"Deteniendo la canción: {Titulo} de {Artista}");
        }

    }
}
