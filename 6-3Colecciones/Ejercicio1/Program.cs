using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList libros = new ArrayList();
            for(int i = 0; i < 5; i++)
            {
                libros.Add("Libro numero: " + (i+1).ToString());
            }
            Console.WriteLine("El valor del registro 2 es: "+libros[2]);
            Console.WriteLine("\nImpresion de todos los libros: ");
            foreach(String l in libros){
                Console.WriteLine(l);
            }
            
            Console.WriteLine("\nLa capacidad es: " + libros.Capacity);
            Console.WriteLine("\nLa cantidad total de libros es: " + libros.Count);
            /*
             * 7)Insertar en la posicion 5, el libro "Los libres mueren de pie".
8)Buscar un libro x, informar ¿si existe o no?
9)Ordenar e Invertir la lista.
10)Remover el registro 3.*/
            libros.Insert(5, "Los arboles mueren de pie");
            if(libros.Contains("Los arboles mueren de pie"))
            {
                Console.WriteLine("\nExiste.");
            }
            else
            {
                Console.WriteLine("\nNo existe.");
            }

            //Buscar con binarySearch SI USO EL REVERSE PRIMERO NO FUNCIONAAA
            int binary = libros.BinarySearch("Los arboles mueren de pie");
            Console.WriteLine("\nBusqueda con binarySearch: ");
            if (binary > -1)
            {
                Console.WriteLine("\nExiste en la posicion " + binary);
            }
            else
            {
                Console.WriteLine("\nNo existe");
            }

            //Orden:
            libros.Sort();
            //Invertir:
            libros.Reverse();
            //Eliminar el 3:
            Console.WriteLine("\nLibro a eliminar: "+libros[3]);
            libros.RemoveAt(3);
            if (!(libros.Contains("Libro numero: 3")))
            {
                Console.WriteLine("\nEliminado correctamente");
            }

            Console.WriteLine("\nOrden invertido: ");
            foreach(String l1 in libros)
            {
                Console.WriteLine(l1);
            }


            
            Console.ReadKey();
        }
    }
}
