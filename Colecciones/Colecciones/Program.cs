using System;
using System.Collections.Generic;     //Paquete importado

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {    //LIST

            /*List<int> numeros = new List<int>();   //Declarar una lista (coleccion de tipo lista)

            //numeros.Add(5);     //Agregar elementos a la lista previamente creada de forma manual

            int[] listaNumeros = new int[] { 3, 5, 8, 15, 32 };     //Array
            
            for(int i = 0; i < 5; i++)            //Agregar elementos a la lista desde un array
            {
                numeros.Add(listaNumeros[i]);
            }

            

            for(int i = 0; i < 5; i++)        //Recorrer la lista
            {
                Console.WriteLine(numeros[i]);
            }
            */

            /*
            Console.WriteLine("Cuantos elementos quieres introducir");

            int elem = int.Parse(Console.ReadLine());                    //Introducir por consola el numero de elementos a ingresar

            for(int i = 0; i < elem; i++)
            {
                Console.WriteLine("Intoduce el elemento " + i);        //Indroduccion de elementos mediante un ciclo for
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Elementos Ingresados");                 //Lectura de elementos ingresados mediante un ciclo for
            for(int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            


            Console.WriteLine("Introduce los elementos necesarios (0 para salir)");

            int elem = 1;

            while (elem != 0)
            {
                elem = int.Parse(Console.ReadLine());

                numeros.Add(elem);
            }

            numeros.RemoveAt(numeros.Count - 1);    //Eliminar el ultimo elemento en este caso seria el 0

            Console.WriteLine("Listado de numeros ingresados");
            foreach(int elemento in numeros)                   //El ciclo foreach es comunmente usado cuando no sabemos la cantidad de elementos en la coleccion
            {
                Console.WriteLine(elemento);
            }
            





            //LINKEDLIST
            LinkedList<int> numeros = new LinkedList<int>();    //Crear LinkedList

            foreach (int numero in new int[] { 10, 8, 6, 4, 2 })   //Ciclo foreache y array declarado
            {
                //numeros.AddFirst(numero);   //Agregar el array a la linkedList
                numeros.AddLast(numero);      //funciona igual pero inserta los numeros al final
            }

            //numeros.Remove(6);    //Eliminar un elemento de la lista

            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);   //Crear un objecto de tipo nodo

            numeros.AddFirst(nodoImportante);                                   //Insertar el nodo a la lista

            numeros.Remove(nodoImportante);                                     //Eliminar el nodo

            /*foreach (int numero in numeros)   //imprimir en pantalla
            {
                Console.WriteLine(numero);
            }

            for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next)   //Imprimir linkedList con el metodo likedListNode
            {
                int numero = nodo.Value;

                Console.WriteLine(numero);

            }
            


            //QUEUE (primero en entrar, primero en salir)

            Queue<int> numeros = new Queue<int>();   //Declarar queue

            foreach(int numero in new int[5] { 2, 4, 6, 8, 10 })   //insertar en la cola y declarar array
            {
                numeros.Enqueue(numero);
            }

            Console.WriteLine("Elementos Insertados:");
            foreach(int numero in numeros)            //Recorrer la cola
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Se eliminara el primer elemento, Elementos restante:");
            numeros.Dequeue();                       //Eliminar de la cola
            foreach (int numero in numeros)            //Recorrer la cola despues de eliminar un elemento
            {
                Console.WriteLine(numero);
            }
            


            //STACK (ultimo en entrar,primero en salir)

            Stack<int> numeros = new Stack<int>();   //Declarar stack

            foreach(int numero in new int[5] { 2, 4, 6, 8, 10 })   //insertar en el stack y declarar array
            {
                numeros.Push(numero);
            }

            Console.WriteLine("Elementos Insertados:");
            foreach (int numero in numeros)            //Recorrer el Stack
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Se eliminara el ultimo numero insertado");
            numeros.Pop();
            Console.WriteLine("Elementos Restantes:");
            foreach (int numero in numeros)            //Recorrer el Stack despues de la eliminacion
            {
                Console.WriteLine(numero);
            }
            */


            //DICTIONARY

            Dictionary<string, int> edades = new Dictionary<string, int>();    //Declarar diccionario

            edades.Add("Juan", 24);          //Insertar valor manualmente

            edades.Add("Andres", 19);

            edades["Maria"] = 25;            //Otra forma de insertar valores

            edades["Antonio"] = 19;

            foreach (KeyValuePair<string, int> persona in edades)
            {
                // Console.WriteLine("Nombre: " + persona.Key + " Edad: " + persona.Value);     //Recorrer el diccionario
                Console.WriteLine("Nombre: {0} Edad: {1}", persona.Key, persona.Value);         //Otra forma
            }

        }
    }
}
