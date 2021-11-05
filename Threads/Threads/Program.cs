using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        { /*
            //Para desarrollar aplicaciones multitarea (Ejecutar simultaneamente) varios metodos
            Thread t = new Thread(Saludo);         //Declarar el Thread o Hilo
            t.Start();                              //Iniciar el Hilo
            t.Join();                               //Sincronizar hilos (Se ordena con el flujo de ejecucion)

            Thread t2 = new Thread(Saludo);
            t2.Start();
            t2.Join();

            Console.WriteLine("Hello World!");
            Thread.Sleep(500);                     //Retardar la ejecucion.
            Console.WriteLine("Hello World!");
            Thread.Sleep(500);
            Console.WriteLine("Hello World!");
            Thread.Sleep(500);
            Console.WriteLine("Hello World!");
            Thread.Sleep(500);
            Console.WriteLine("Hello World!");
            Thread.Sleep(500);

            //Saludo();
            */

            CuentaBancaria CuentaFamiliar = new CuentaBancaria(2000);

            Thread[] HilosPersonas = new Thread[15];

            for(int i = 0; i < 15; i++)
            {
                Thread t = new Thread(CuentaFamiliar.Retiremos);

                t.Name = i.ToString();

                HilosPersonas[i] = t;
            }

            for (int i = 0; i < 15; i++) HilosPersonas[i].Start();


        }
        
        static void Saludo()
        {
            Console.WriteLine("Hola Mundo");
            Thread.Sleep(500);
            Console.WriteLine("Hola Mundo");
            Thread.Sleep(500);
            Console.WriteLine("Hola Mundo");
            Thread.Sleep(500);
            Console.WriteLine("Hola Mundo");
            Thread.Sleep(500);
            Console.WriteLine("Hola Mundo");
            Thread.Sleep(500);

        }
    }

    class CuentaBancaria
    {
        private Object BloqueaSaldo = new object();
        double Saldo { set; get; }
        public CuentaBancaria(double Saldo)
        {
            this.Saldo = Saldo;

        }

        public double RetirarEfectivo(double Cantidad)
        {
            if((Saldo - Cantidad) < 0)
            {
                Console.WriteLine($"No tienes fondos suficientes; Saldo: {Saldo} Hilo {Thread.CurrentThread.Name}");

                return Saldo;
            }

            lock(BloqueaSaldo){ 
            if (Saldo >= Cantidad)
            {
                Console.WriteLine("Retirado {0}, Restante {1} en la cuenta {2}", Cantidad, (Saldo - Cantidad), Thread.CurrentThread.Name );

                Saldo -= Cantidad;
            }

            return Saldo;
            }
        }

        public void Retiremos()
        {
            
            RetirarEfectivo(500);
        }
    }
}
