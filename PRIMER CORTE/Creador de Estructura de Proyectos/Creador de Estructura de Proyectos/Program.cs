using System;
using System.IO;

namespace Creador_de_Estructura_de_Proyectos
{
    internal class Program

    {
        static void Main(string[] args)
        {
                Console.WriteLine("Ingrese el nombre del proyecto: ");
                string nombreProyecto = Console.ReadLine();

                
                string rutaProyecto = Path.Combine(Environment.CurrentDirectory, nombreProyecto);
                Directory.CreateDirectory(rutaProyecto);

               
                string documentos = Path.Combine(rutaProyecto, "documentos");
                string imagenes = Path.Combine(rutaProyecto, "imagenes");
                string codigo = Path.Combine(rutaProyecto, "codigo");

                Directory.CreateDirectory(documentos);
                Directory.CreateDirectory(imagenes);
                Directory.CreateDirectory(codigo);

               
                Console.WriteLine("Ingrese una breve descripción del proyecto: ");
                string descripcion = Console.ReadLine();

                string rutaReadme = Path.Combine(documentos, "readme.txt");
                File.WriteAllText(rutaReadme, descripcion);

                
                Console.WriteLine("Proyecto creado en: " + Path.GetFullPath(rutaProyecto));
            }
        }
    }
    