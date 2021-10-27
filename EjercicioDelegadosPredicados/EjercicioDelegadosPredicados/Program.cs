using System;
using System.Collections.Generic;

namespace EjercicioDelegadosPredicados
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List<Personas> gente = new List<Personas>();            //Creamos la lista

             Personas P1 = new Personas();                       //Creamos una persona, utilizando la clase personas
             P1.Nombre = "Juan";                                 //Llamamos las instancias para darle valores a las personas
             P1.Edad = 17;

             Personas P2 = new Personas();
             P2.Nombre = "Maria";
             P2.Edad = 12;

             Personas P3 = new Personas();
             P3.Nombre = "Ana";
             P3.Edad = 15;

             gente.AddRange(new Personas[] { P1, P2, P3 });      //Agregamos las personas a la lista, creando un array

             Predicate<Personas> ElPredicado = new Predicate<Personas>(MayorEdad);    //Utlizacion del delegado predicado

             bool existe = gente.Exists(ElPredicado);

             if (existe) Console.WriteLine("Hay personas Mayores de edad");
             else Console.WriteLine("No hay personas mayores de edad");
            */

            //Operacion Matematica = new Operacion(Cuadrado);
            Operacion Matematica = new Operacion(num => num * num); //Este operador lo que hace es simplificar el codigo Ya que no debemos 
                                                                    //llamar un metodo sino que se desarrolla en el mismo espacio
            Console.WriteLine(Matematica(4));

            //Ejemplo con 2 Parametros   (Si es mas de un parametro deben estar entre parentesis)
            Operacion1 Suma = new Operacion1((numero1, numero2) => numero1 + numero2);  //No necesita metodo
            Console.WriteLine(Suma(12,24));

            //Ejemplo 3
            List<int> Numeros = new List<int> { 1,2,3,4,5,6,7,8,9,10};    //Crear lista con todos los numeros

            List<int> Pares = Numeros.FindAll(i => i % 2 == 0);       //Crear lista para almacenar los pares y hacer la condicion con el metodo lambda

            //foreach (int par in Pares) Console.WriteLine(par);      //Recorrer la lista

            Pares.ForEach(numero => Console.WriteLine(numero));       //Otra forma de recorrer un lista con el metodo lambda
            


        }
        /*
        static bool MayorEdad(Personas persona)                  //Creamos la condicion que devolvera un tipo bool
        {
            if (persona.Edad >= 18) return true;
            else return false;
        }
        */

        //LAMBDA
        public delegate int Operacion(int numero);

        public delegate int Operacion1(int numero1, int numero2);
        public static int Cuadrado(int num)
        {
            return num * num;

        }
    }
    
    class Personas            //Creamos las clase para el ejercicio
    {

        private string nombre;

        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
    
}
