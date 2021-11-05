using System;
using System.Threading;
using System.Threading.Tasks;

namespace Threads1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tareaTerminada = new TaskCompletionSource<bool>();

            var Hilo1 = new Thread(() =>
            {
                for(int i=0; i < 5; i++)
                {
                    Console.WriteLine("Hilo1");
                    Thread.Sleep(1000);
                }

                tareaTerminada.TrySetResult(true);    //Terminar tarea

            });

            var Hilo2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo2");
                    Thread.Sleep(1000);
                }

                tareaTerminada.TrySetResult(true);

            });

            var Hilo3 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hilo3");
                    Thread.Sleep(1000);
                }

            });

            Hilo1.Start();

            Hilo2.Start();

            var resultado = tareaTerminada.Task.Result;

            Hilo3.Start();
        }
    }
}
