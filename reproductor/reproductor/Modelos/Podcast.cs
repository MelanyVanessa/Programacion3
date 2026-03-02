using reproductor.Interfaces;
using System;

namespace reproductor.Modelos
{
    public class Podcast : IReproductor
    {
        public string Titulo { get; set; }
        public string Creador { get; set; }
        public string Episodio { get; set; }


        public void Play()
        {
            Console.WriteLine($"Reproduciendo el podcast: {Titulo} de {Creador}");
        }

        public void Stop()
        {
            Console.WriteLine($"Deteniendo el podcast: {Titulo} de {Creador}");
        }

    }
}
