using System;


//Crear tres clases (Avion, Vehiculo, Coche)
//metodos comunes en las 3 (Arrancar motor, parar motor)
//metodo virtual (Conducir)
namespace ejercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coche");

            Coche Mazda = new Coche();

            Mazda.arrancarMotor("rummm");

            Mazda.acelerar();

            Mazda.conducir();

            Mazda.frenar();

            Mazda.apagarMotor("truck");

            

            

        }
    }

    class Vehiculo
    {
       
        public void arrancarMotor(string sonidoArranque)
        {
            Console.WriteLine("El motor esta encendido " + sonidoArranque);
        }

        public void apagarMotor(string sonidoApagar)
        {
            Console.WriteLine("El motor esta apagado " + sonidoApagar);
        }

        public virtual void conducir()
        {
            Console.WriteLine("Se puede conducir");
        }
    }

    class Avion : Vehiculo
    {
        public void despegar()
        {
            Console.WriteLine("El avion ha despegado");
        }

        public void aterrizar()
        {
            Console.WriteLine("El avion ha aterrizado");
        }

        public override void conducir()
        {
            Console.WriteLine("se debe pilotear");
        }

    }

    class Coche : Vehiculo
    {
        public void acelerar()
        {
            Console.WriteLine("Acelerando");
        }

        public void frenar()
        {
            Console.WriteLine("frenando");
        }

        public override void conducir()
        {
            Console.WriteLine("Se conduce por carretera");
        }
    }
}
