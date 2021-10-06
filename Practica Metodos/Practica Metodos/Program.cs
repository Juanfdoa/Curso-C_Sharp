using System;

namespace Practica_Metodos
{
    class Program
    {
        int Numero1 = 7;      //Variables a utilizar en los metodos 1 y 2 de forma global.
        int Numero2 = 8;
        
        static void Main(string[] args)
        {
            mensajeEnPantalla();
            Console.WriteLine("mensaje desde el main");
            sumaNumeros(7,9);
            sumaNumeros(8,4);
            Console.WriteLine("El resultado de la division es igual a " + divisionNumeros(50,3));
            Console.WriteLine("El resultado de la otra division es igual a " + divisionNumeros1(50, 5));
            Console.WriteLine(suma(7,2.8));   //Ejemplo sobrecarga
            Console.WriteLine(opcional(5, 7.6));  // Ejemplo Parametros Opcionales

        }

        

        //METODO TIPO VOID
        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el metodo mensaje en pantalla");
        }

        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine("La suma de los números es igual a " + (num1 + num2) );
        }

        //METODO TIPO RETURN
        static int divisionNumeros(int num1, int num2)  //Se debe de tener en cuenta que tipo de dato va ha devolver
        {
            return num1 / num2;
        }

        static int divisionNumeros1(int num1, int num2) => num1 / num2;  //Cuando solo se tiene un RETURN se puede simplificar de esta manera.

        //Ambito y Alcance
        //Si las variables si inician fuera del metodo pueden ser utilizadas por varios metodos de lo contrario solo se usa de forma local.
        void metodo1()
        {
            Console.WriteLine(Numero1 + Numero2);
        }

        void metodo2()
        {
            Console.WriteLine(Numero1 + Numero2);
        }

        //Sobrecarga de metodos
        //Se utliza para definir varios metodos con el mismo nombre
        //Pero se debe diferir en la cantidad de parametros o en el tipo de dato

        static int suma(int num1, int num2) => num1 + num2;

        static int suma(int num1, int num2, int num3) => num1 + num2 + num3;

        static double suma(int num1, double num2) => num1 + num2;


        //Parametros Opcionales
        //Ayudas para desarrolladores
        //https://www.youtube.com/watch?v=Rmnz3xUrrks&list=PLU8oAlHdN5BmpIQGDSHo5e1r4ZYWQ8m4B&index=14

        private static double opcional(int num1, double num2, double num3 = 0) // El parametro num3 es opcional
        {
            return num1 + num2 + num3;
        }
    }
}
