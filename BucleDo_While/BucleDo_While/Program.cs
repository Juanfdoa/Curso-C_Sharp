using System;

namespace BucleDo_While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int z = 10;
              do                                             //Primero se ejecuta el do
              {
                  Console.WriteLine("Impresion " + z);
                  z++;

              } while (z < 15);                              //Y luego se verifica la condicion si es verdadera se repite.
            */

            //Ejercicio
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int miNumero;

            int intentos = 0;

            Console.WriteLine("Introduce un numero entre 0 y 100");

            do
            {
                intentos++;

                miNumero = int.Parse(Console.ReadLine());

                if (miNumero > aleatorio) Console.WriteLine("El numero es mas bajo");

                if (miNumero < aleatorio) Console.WriteLine("El numero es mas alto");

            } while (aleatorio != miNumero);

            Console.WriteLine("Correcto, te ha tomado " + intentos + " intentos");

         }
    }
}
