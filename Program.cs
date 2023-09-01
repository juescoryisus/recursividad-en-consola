using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace recursividad_en_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\jesus\OneDrive\Escritorio\MUSICA"; // Cambia esto a la ruta de tu directorio raíz
            ListFilesRecursively(path);
        }

        static void ListFilesRecursively(string directory)
        {
            foreach (string file in Directory.GetFiles(directory))
            {
                Console.WriteLine($"Archivo: {Path.GetFileName(file)}, Extensión: {Path.GetExtension(file)}");
                Console.WriteLine("==================================================================================================================");
            }

            foreach (string subdirectory in Directory.GetDirectories(directory))
            {
                ListFilesRecursively(subdirectory);
            }
            Console.ReadKey();
        }
    }
}
