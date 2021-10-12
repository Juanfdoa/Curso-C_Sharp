using System;

namespace BucleWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Deseas entar en el buque While?");

             string respuesta = Console.ReadLine();

             while(respuesta != "no")
             {
                 Console.WriteLine("Estas ejecutado el Bucle");

                 Console.WriteLine("Introduce tu nombre");

                 string nombre = Console.ReadLine();

                 Console.WriteLine($"Saldras del Bucle {nombre} Cuando respondas 'no' a la pregunta");

                 Console.WriteLine("Deseas repeitr otra vez");

                 respuesta = Console.ReadLine();
             } */

            //Ejercicio
            Random numero = new Random();

            int numeroAleatorio = numero.Next(0, 100);

            int numeroUsuario = 101;

            int intentos = 0;

            Console.WriteLine("Introduce un numero entre o y 100");

            while(numeroAleatorio != numeroUsuario)
            {
                intentos++;

                numeroUsuario = int.Parse(Console.ReadLine());

                if (numeroUsuario > numeroAleatorio) Console.WriteLine("El Numero es mas bajo");

                if (numeroUsuario < numeroAleatorio) Console.WriteLine("El numero es mas alto");

               
            }

            Console.WriteLine("Correcto! Haz necesitado " + intentos + " intentos");




            Console.WriteLine("El bucle ha finalizado");
        }
    }
}
