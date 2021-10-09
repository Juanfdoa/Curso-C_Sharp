using System;

namespace condicionalSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio #1

            Console.WriteLine("Elige medio de trasporte (Coche, tren, avion)");

             string medioTransporte = Console.ReadLine();

             switch (medioTransporte)
             {
                 case "coche":
                     Console.WriteLine("Velocidad media: 100 km/h");
                     break;

                 case "tren":
                     Console.WriteLine("Velocidad media: 250 Km/h");
                     break;

                 case "avion":
                     Console.WriteLine("Velocidad media: 800 Km/h");
                     break;

                 default:
                     Console.WriteLine("Tranporte no encontrado");
                     break;

             }

             //Ejercicio #2

             Console.WriteLine("Introduce n° mes para calculo de la comision");

             int numeroMes = Int32.Parse(Console.ReadLine());

                switch (numeroMes)     // solo admite int, char, string
                {
                    case 1:
                        Console.WriteLine("Mes Enero");
                        break;

                    case 2:
                        Console.WriteLine("Mes Febrero");
                        break;

                    case 3:
                        Console.WriteLine("Mes Marzo");
                        break;

                    case 4:
                        Console.WriteLine("Mes Abril");
                        break;

                    case 5:
                        Console.WriteLine("Mes Mayo");
                        break;

                    case 6:
                        Console.WriteLine("Mes Junio");
                        break;

                    case 7:
                        Console.WriteLine("Mes Julio");
                        break;

                    case 8:
                        Console.WriteLine("Mes Agosto");
                        break;

                    case 9:
                        Console.WriteLine("Mes Septiembre");
                        break;

                    case 10:
                        Console.WriteLine("Mes Octubre");
                        break;

                    case 11:
                        Console.WriteLine("Mes Noviembre");
                        break;

                    case 12:
                        Console.WriteLine("Mes Diciembre");
                        break;

                    default:
                        Console.WriteLine("Numero no valido");
                        break;
                }

               Console.WriteLine("Programa Terminado");   
        }
    }
}
