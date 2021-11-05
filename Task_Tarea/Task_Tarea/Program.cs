using System;
using System.Threading;
using System.Threading.Tasks;

namespace Task_Tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task tarea = new Task(Ejecutartarea);   //Definir task con metodo

            //tarea.Start();

            //Task tarea = Task.Run(() => Ejecutartarea());

           // Task tarea2 = tarea.ContinueWith(EjecutarOtratarea);  //Continua despues de finalizar la primera

            /*Task tarea2 = new Task(() =>            //Definir task con expresion lambda
            {
                for (int j = 0; j < 100; j++)
                {
                    var miThread = Thread.CurrentThread.ManagedThreadId;

                    Thread.Sleep(1000);

                    Console.WriteLine("Tarea correspondiente al hilo: " + miThread + " Ejecutandose desde el main");

                }
            
            });

            tarea2.Start();*/

            Console.ReadLine();
        }



        static void Ejecutartarea()
        {
            for(int i=0; i<10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine("Esta vuelta de bucle corresponde al Tread: " + miThread );
            }
        }
        
        static void EjecutarOtratarea(Task obj)
        {
            for (int i = 0; i < 10; i++)
            {
                var miThread = Thread.CurrentThread.ManagedThreadId;

                Thread.Sleep(1000);

                Console.WriteLine("Esta vuelta de bucle corresponde a la otra tarea del Tread: " + miThread);
            }
        }
    }
}
