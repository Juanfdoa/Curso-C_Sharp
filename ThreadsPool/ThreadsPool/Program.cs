using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsPool
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                //Thread t = new Thread(EjecutarTarea);

                // t.Start();

                ThreadPool.QueueUserWorkItem(EjecutarTarea, i);
            }

            Console.ReadLine();
           
        }

        static void EjecutarTarea(Object o)
        {
            int nTarea = (int)o;

            Console.WriteLine($"Thread N°: {Thread.CurrentThread.ManagedThreadId} ha comenzado la tarea N° " + nTarea);

            Thread.Sleep(1000);

            Console.WriteLine($"Thread N°: { Thread.CurrentThread.ManagedThreadId}ha terminado la tarea" + nTarea);
        }
    }
}
