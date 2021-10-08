using System;

namespace condicional_If
{
    class Program
    {
        static void Main(string[] args)
        {
            bool haceFrio;             //Declaracion valor booleano

            haceFrio = false;

            Console.WriteLine(!haceFrio); //! operador a la inversa


            int edad = 15;

            Console.WriteLine("Vamos a evaluar si eres mayor de edad");

            if(edad < 18) Console.WriteLine("No puedes pasar, porque eres menor de edad"); // si tiene solo una linea de codigo se pueden omitir las llaves
            
            else Console.WriteLine("Puedes pasar");

            //Ejercicio #1
            Console.WriteLine("Vamos ha evaluar si puedes conducir un auto");
            Console.WriteLine("Introduce tu edad");
            
            int edad1 = Int32.Parse(Console.ReadLine());

            if(edad1 >= 18)
            { 
               Console.WriteLine("Tienes carnet");

               string carnet = Console.ReadLine();
           

              if (edad1 >= 18 && carnet == "si") Console.WriteLine("Puedes conducir");

              else Console.WriteLine("No puedes conducir");
            }
            else Console.WriteLine("No puedes conducir");


            //Ejercicio #2
            Console.WriteLine("Introduce el primer parcial");

            float parcial1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo parcial");

            float parcial2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer parcial");

            float parcial3 = Int32.Parse(Console.ReadLine());

            if (parcial1 >= 5 && parcial2 >= 5 && parcial3 >= 5)
            {
                float resultado = (parcial1 + parcial2 + parcial3) / 3;
                Console.WriteLine("La nota media es igual a : " + resultado);
            }
            else Console.WriteLine("Debes recuperar");

            
            //Ejercicio #3
            Console.WriteLine("introduce tu edad");

            int edad3 = Int32.Parse(Console.ReadLine());

            if (edad3 < 18) Console.WriteLine("Eres un niño");

            else if (edad3 < 30) Console.WriteLine("Eres Joven");

            else if (edad3 < 60) Console.WriteLine("Eres maduro");

            else Console.WriteLine("Debes cuidarte");
        }
    }
}
