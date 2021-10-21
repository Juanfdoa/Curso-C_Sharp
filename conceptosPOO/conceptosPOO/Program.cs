using System;

using static System.Math; //Importar toda la clase Math
// No es recomendable
using static System.Console; //Importar consola



namespace conceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //realizarTarea();

            double raiz = Math.Sqrt(9);      //Operador matematico

            double potencia = Pow(3, 4);     //Solo usamos pow, ya que impotamos la clase Math.

            Console.WriteLine(raiz);
            Console.WriteLine(potencia);

            //CLASES ANONIMAS
            //se utiliza la palabra reservada var, y no se le asigna tipo
            var miVariable = new { Nombre = "Juan", Edad = 19 };

            Console.WriteLine(miVariable.Nombre + " " + miVariable.Edad);
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();        //ficheros fuente
                                               //Crea un constructor en una clase diferente
            Punto destino = new Punto(128, 80);

            Punto medio = new Punto();

            double distancia2 = origen.Distancia(destino);

            Console.WriteLine("La distancia entre los puntos X y Y es: " + distancia2);

            Console.WriteLine($"Numero de objectos creados: {Punto.ContadorDeObjectos()}");
        }
    }
}
