using System;

namespace clasesAbstractas
{
    class Program
    {

        static void Main(string[] args)
        {
            Caballo Caballo1 = new Caballo("Babieca");

            Humano Humano1 = new Humano("Juan");

            Gorila Gorila1 = new Gorila("Copito");

            // Humano1.getNombre();

            // Caballo1.getNombre();

            // Gorila1.getNombre();

            Mamiferos animal = new Caballo("Canela");  //Principio de sustitucion, solo hereda los metodos 
                                                       //de la clase mamiferos

            Mamiferos animal2 = new Mamiferos("Luna");

            Caballo caballo2 = new Caballo("Luna");

            animal2 = caballo2;

            //Array con pricipio de susutitucion

            Mamiferos[] almacenMamifero = new Mamiferos[3];

            almacenMamifero[0] = Caballo1;
            almacenMamifero[1] = Humano1;
            almacenMamifero[2] = Gorila1;


            // almacenMamifero[2].getNombre();

            for (int i = 0; i < 3; i++)
            {
                almacenMamifero[i].pensar();

            }

            Ballena wally = new Ballena("wally");

            wally.nadar();

            Console.WriteLine("numero de patas de babieca: " + Caballo1.numeroPatas());

            Lagartija Rango = new Lagartija("Rango");

            Rango.respirar();
            


        }
    }
    //Las interfaces se usan como herencia, pero solo cuando algunas clases lo aceptan
    //y se modifican a su manera
    interface IMamiferosTerrestres
    {
        int numeroPatas();     //No se le debe poner modificador de acceso
        //Por ejemplo esta interface solo se usara en los mamiferos terrestres
    }

    abstract class Animales    // clase abstracta mas general para ser heredada por diferentes clases
    {
        public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }

        public abstract void getNombre();    //Metodo abstrato

    }


    class Mamiferos : Animales
    {
        private string NombreSerVivo;

        public Mamiferos(string nombre)
        {
            NombreSerVivo = nombre;
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento intuitivo basico");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public override void getNombre()
        {
            Console.WriteLine("El nombre del mamifero es: " + NombreSerVivo);
        }

    }

    class Ballena : Mamiferos
    {
        public Ballena(string nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Puedo nadar");
        }
    }

    class Caballo : Mamiferos, IMamiferosTerrestres     //Se heredan los metodos de la clase mamiferos y de la interface
    {//una clase solo puede heredar de una clase, y asu vez de varias interfaces
        public Caballo(string nombreCaballo) : base(nombreCaballo)   //heredar el constructor
        {

        }
        public void galopar()    //Y se le agregan los metodos propios de la clases
        {
            Console.WriteLine("Puedo galopar");
        }

        public int numeroPatas()
        {
            return 4;
        }
    }

    class Humano : Mamiferos
    {
        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }
        public override void pensar()                   //Ya que se hereda un metodo con el mismo nombre de la clase mamifero
        {                                             //el compilador oculta el metodo que hereda e imprime el propio
            Console.WriteLine("Puedo pensar");       //para quitar la advertencia se debe usar la palabra reservada "new" si se quiere que se oculte
        }                                           //o modificar el metodo en la clase padre con la palabra reservada "virtual" 
    }                                               //y las demas metodos de clases con la parabra override para modificar el metodo

    class Gorila : Mamiferos, IMamiferosTerrestres
    {
        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }

        public override void pensar()
        {
            Console.WriteLine("Pensamiento intuitivo avanzado");
        }

        public void trepar()
        {
            Console.WriteLine("Puedo trepar");
        }

        public int numeroPatas()
        {
            return 2;
        }
    }

    class Lagartija : Animales    //Hereda de la clase abstracta
    {
        private string nombreReptil;

        public Lagartija(string nombre)
        {
            nombreReptil = nombre;
        }
        public override void getNombre()
        {
            Console.WriteLine("El nombre del reptil es: + nombreReptil");
        }

        //Las clases selladas son las que no permiten que se hereden 
        //despues de ella y se declara con la palabra reservada sealed
    }

}