using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtema5._1_y_5._2
{
    internal class Program
    {
        static string nombreArchivo = "Listaproductos.txt";   //variable de clase
        static void Main(string[] args)
        {
            agregarNuevoProducto();
        }
        static void agregarNuevoProducto()
        {
            //crear y abrir el documento de texto
            StreamWriter nuevoDocumento = new StreamWriter(nombreArchivo,true);

            Console.Write("ingrese el nombre del producto a registrar: ");
            string producto = Console.ReadLine();
            nuevoDocumento.WriteLine(producto);

            nuevoDocumento.Close();

        }
    }
}
