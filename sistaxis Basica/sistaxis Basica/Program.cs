using System;

namespace sistaxis_Basica
{
    class Program
    {
        static void Main(string[] args)
        {
            // SISTAXIS BASICA C#

            Console.WriteLine("Hello World!"); //Esto imprime un mesanje en consola.

            int edad = 24;                     //Definir variables en C#.
            // edad++;               incremento
            Console.WriteLine("Mi edad es: " + edad + " años");       // Concatenacion
            Console.WriteLine($"Tienes una edad de {++edad} años");    // Interpolacion de strings

            Console.WriteLine(7 * 5);          //Operador aritmetico 


            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            // Inicializar todas la variables al mismo tiempo
            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 24;
            Console.WriteLine("Su edad es de " + edadPersona3);


            var edadPersona5 = 30; //Si se define una variable con la pr var se debe inicializar en la misma linea.
            Console.WriteLine(edadPersona5);


            //Conversion explicita
            double temperatura = 34.5;
            int temperaturaMedellin;

            temperaturaMedellin = (int)temperatura;    // se debe especificar el tipo de dato para hacer la conversion.
            Console.WriteLine("La temperatura de Medellin es de " + temperaturaMedellin);


            //Conversion implicita
            int habitantes = 10000;
            long habitantes2021;

            habitantes2021 = habitantes;        //Se debe tener las mismas caracteristicas del tipo de dato
            Console.WriteLine(habitantes2021);


            //Conversion de texto a valor numerico

            Console.WriteLine("Inserte un número");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Inserta un segundo número");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la multiplicacion es: " + num1 * num2);


            //Definir Constantes
            const int VALOR = 8;            //se debe inicializar en la misma linea "es recomendable ponerla en mayuscula para diferenciarla facilmente

            Console.WriteLine("El valor de la constante es {0}: ", VALOR);


            //Ejercicio
            const double PI = 3.1416;

            Console.WriteLine("Introduce la medida de el radio");

            double radio = double.Parse(Console.ReadLine());

            double area = radio * radio * PI;
            // double area = math.Pow(radio, 2)*PI;

            Console.WriteLine("El area del circulo es: " + area);

        }
    }
}
