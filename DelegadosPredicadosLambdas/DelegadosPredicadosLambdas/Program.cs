using System;
using System.Collections.Generic;

namespace DelegadosPredicadosLambdas
{
    class Program
    {
        static void Main(string[] args)
        {   //DELEGADOS USO
            //Creacion del objecto delegado apuntando al mensaje bienvenida
            /*
             ObjetoDelegado ElDelegado = new ObjetoDelegado(MensajeBienvenida.SaludoBienvenida);

             //Utilizacion del delegado
             ElDelegado("Hola, Como Estas");

             ElDelegado = new ObjetoDelegado(MensajeDespedida.SaludoDespedida);

             ElDelegado("Hasta pronto");
            */

            //DELEGADOS PREDICADOS USO

           /* List<int> listaNumeros = new List<int>();       //Crear Lista

            listaNumeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });     //insertar un array con valores a la lista previamente creada

            //Declaramos DELEGADO PREDICADO
            Predicate<int> ElDelegado1 = new Predicate<int>(Pares);

            List<int> NumPares = listaNumeros.FindAll(ElDelegado1);     //Crear una lista para que guarde los numero pares

            foreach(int numero in NumPares)
            {
                Console.WriteLine(numero);
            }
           */



         

        }

        //DEFINICION DEL OBJETO DELEGADO
        //delegate void ObjetoDelegado(string msj);



        //DELEGADOS PREDICADOS
        //Devuelven un valor booleano (filtar)

        /*static bool Pares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }
        */
    }
    /*
     //DELEGADOS
    class MensajeBienvenida
    {
        public static void SaludoBienvenida(string msj)
        {
            Console.WriteLine("Mensaje Bienvenida: {0}", msj);
        }
    }

    class MensajeDespedida
    {
        public static void SaludoDespedida(string msj)
        {
            Console.WriteLine("Mensaje de Despedida: {0}", msj);
        }
    }
    */

   
}
