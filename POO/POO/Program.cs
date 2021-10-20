using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulo1;  //Creacion de objecto /variable objecto

            circulo1 = new Circulo();   //Iniciacion de variable objecto / instancia

            Console.WriteLine(circulo1.CalculoArea(5));

            Circulo circulo2 = new Circulo();    //Se define y se inicializa en la misma linea.

            Console.WriteLine(circulo2.CalculoArea(9));

            ConversorEuroDolar valor1 = new ConversorEuroDolar();

            valor1.CambiaValorEuro(1.5);

            Console.WriteLine(valor1.Convierte(50));


        }
    }

    class Circulo      //Crear nuevas clases dentro del namespace
    {
       //private const double pi = 3.1416;    para encapsurar la variable, que no sea accepcible desde otra clase

        const double pi = 3.1416;    //Propiedad

       public double CalculoArea(int radio)     //Metodo
        {
            return pi * radio * radio;
        }

        //Convenciones
        //Cuando se usa public la variable debe comenzar con mayuscula
        // Los que no la usan comienzan con minuscula.

    }

    class ConversorEuroDolar
    {
       private double euro = 1.16;

        public double Convierte(double cantidad)
        {
            return euro * cantidad;
        }

        public void CambiaValorEuro(double nuevoValor)   // metodo de acceso para cambiar un valor
        {
            if (nuevoValor < 0) euro = 1.16;
            else 
                euro = nuevoValor;
        }
    }
}
