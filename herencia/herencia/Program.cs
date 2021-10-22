using System;

namespace herencia
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

            for(int i = 0; i < 3; i++)
            {
                almacenMamifero[i].pensar();

            }





        }
    }

    class Mamiferos
    {
        private string NombreSerVivo;

        public Mamiferos(string nombre)
        {
            NombreSerVivo = nombre;
        }

        public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }

        public virtual void pensar()
        {
            Console.WriteLine("Pensamiento intuitivo basico");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias hasta que se valgan por si solas");
        }

        public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + NombreSerVivo);
        }
        
    }

    class Caballo: Mamiferos     //Se heredan los metodos de la clase mamiferos
    {
        public Caballo (string nombreCaballo): base(nombreCaballo)   //heredar el constructor
        {

        }
        public void galopar()    //Y se le agregan los metodos propios de la clases
        {
            Console.WriteLine("Puedo galopar");
        }
    }

    class Humano : Mamiferos
    {
        public Humano (string nombreHumano): base(nombreHumano)
        {

        }
       public override void pensar()                   //Ya que se hereda un metodo con el mismo nombre de la clase mamifero
        {                                             //el compilador oculta el metodo que hereda e imprime el propio
            Console.WriteLine("Puedo pensar");       //para quitar la advertencia se debe usar la palabra reservada "new" si se quiere que se oculte
        }                                           //o modificar el metodo en la clase padre con la palabra reservada "virtual" 
    }                                               //y las demas metodos de clases con la parabra override para modificar el metodo

    class Gorila : Mamiferos
    {
        public Gorila(string nombreGorila): base(nombreGorila)
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
    }

}
