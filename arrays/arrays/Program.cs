using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;       //Declaracion del array

            numeros = new int[5];  //Inicializar array y darle un espacio

            numeros[0] = 15;       //Rellenar array
            numeros[1] = 27;
            numeros[2] = 19;
            numeros[3] = 80;
            numeros[4] = 52;

            Console.WriteLine(numeros[4]);


            //Sintaxis simplificada

            // int[] numeros = { 15, 27, 19, 80, 52 };  //sin restricciones

            //  Console.WriteLine(numeros[3]);

            //ARRAY IMPLICITO
            //Es mas flexible

            var datos = new[] { "Juan", "Acevedo", "Colombia" };    //Solo strings

            var num = new[] { 30, 25, 67, 40.23, 54.32, 56 };   //Se evidencian enteros y double, pero se les da un tipo double a todos

            //ARRAY DE OBJECTOS

            Empleados Ana = new Empleados("Ana", 27);            //Se crea un nuevo objecto

            Empleados[] arrayEmpleados = new Empleados[3];       //Se crea un array con capacidad par 2 objectos

            arrayEmpleados[0] = new Empleados("Sara", 37);       //Se llena el primer epsacio y a la vez se crea un objecto

            arrayEmpleados[1] = Ana;                             //Se llena el segundo espacio con el objecto previamente creado

            arrayEmpleados[2] = new Empleados("Mateo", 24);

            //ARRAY DE TIPOS O CLASES ANONIMAS

            var persona = new[]
            {  //Deben contener la misma cantidad, el mismo tipo y mismo nombre
                new{Nombre = "Juan", Edad = 19},

                new { Nombre = "Maria", Edad = 49 },

                new {Nombre = "Diana", Edad =35}
            };
            //BUCLE FOR
            for(int i = 0; i < arrayEmpleados.Length; i++)
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());
            }

            //BUCLE FOREACH
            //Se usa cuando no sabemos las cantidad, ni el tipo, no sabemos nada acerca del array
            foreach(double contador in num)
            {
                Console.WriteLine(contador);
            }

            //Ejemplo array como parametro (dentro del main)

            int[] numbers = new int[4];

            numbers[0] = 7;
            numbers[1] = 9;
            numbers[2] = 15;
            numbers[3] = 3;

            ProcesaDatos(numbers);    //Se salta al metodo procesaDatos y le suma 10

            foreach(int o in numbers)
            {
                Console.WriteLine(o);   //Imprime el numero ya sumado con 10
            }


            //Ejemplo devolver un array (dentro del main)

            int[] arrayElementos = LeerDatos();

            Console.WriteLine("imprimiendo desde el main");

            foreach(int i in arrayElementos)
            {
                Console.WriteLine(i);
            }
        }

        //ARRAY COMO PARAMETRO DE UN METODO
        static void ProcesaDatos(int[] datos)
        {
            for(int a = 0; a < 4; a++)
            {
                datos[a] += 10;
            }

        }

        //Devolver un array

        static int[] LeerDatos()
        {
            Console.WriteLine("Cuantos elementos quieres que tenga el array");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] dates = new int[numElementos];

            for(int b = 0; b < numElementos; b++)
            {
                Console.WriteLine($"Indroduce el dato para la posicion {b}");

                respuesta = Console.ReadLine();

                int datosElemento = int.Parse(respuesta);

                dates[b] = datosElemento;
            }
            return dates;
        }
        

    }

    class Empleados
    {
        public Empleados(string Nombre, int Edad)
        {
            this.Nombre = Nombre;

            this.Edad = Edad;
        }

        public string getInfo()
        {
            return "Nombre del empleado: " + Nombre + " Edad: " + Edad;
        }

        private string Nombre;

        private int Edad;
    }
}
