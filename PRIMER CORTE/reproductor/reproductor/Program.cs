using reproductor.Interfaces;
using reproductor.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reproductor
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO AL REPRODUCTOR DE MUSICA Y PODCAST!");
            Console.WriteLine("==============================================");
            Console.WriteLine(" ");

            List<IReproductor> Playlist = new List<IReproductor>();
            bool continuar = true;


            while (continuar)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar canción");
                Console.WriteLine("2. Agregar podcast");
                Console.WriteLine("3. Reproducir playlist");
                Console.WriteLine("4. Detener reproducción");
                Console.WriteLine("5. Salir");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":

                        Console.WriteLine("============= AGREGANDO NUEVA CANCION =============");
                        Console.WriteLine("Ingrese el título de la canción:");
                        string tituloCancion = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del artista:");
                        string artistaCancion = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del álbum:");
                        string albumCancion = Console.ReadLine();

                        Playlist.Add(new Cancion { Titulo = tituloCancion, Artista = artistaCancion, Album = albumCancion });

                        break;
                    case "2":

                        Console.WriteLine("============= AGREGANDO NUEVO PODCAST =============");
                        Console.WriteLine("Ingrese el título del podcast:");
                        string tituloPodcast = Console.ReadLine();

                        Console.WriteLine("Ingrese el nombre del creador:");
                        string creadorPodcast = Console.ReadLine();

                        Console.WriteLine("Ingrese el numero del episodio:");
                        string episodioPodcast = Console.ReadLine();
                        break;

                        Playlist.Add(new Podcast { Titulo = tituloPodcast, Creador = creadorPodcast, Episodio = episodioPodcast });

                    case "3":
                        Console.WriteLine("Reproduciendo playlist...");
                        foreach (var item in Playlist)
                        {
                            item.Play();
                        }
                        break;
                    case "4":
                        Console.WriteLine("Deteniendo reproducción...");
                        foreach (var item in Playlist)
                        {
                            item.Stop();
                        }
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente nuevamente.");
                        break;
                }
            }
        }
    }
}
