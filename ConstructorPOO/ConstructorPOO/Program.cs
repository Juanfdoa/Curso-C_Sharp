using System;

namespace ConstructorPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();     //Crear el objecto

            Coche coche2 = new Coche();

            Console.WriteLine(coche1.getInfo());  //Imprimir el metodo

            Coche coche3 = new Coche(200.1, 1.11);
            Console.WriteLine(coche3.getInfo());

            coche3.setExtras(true, "cuero"); //Ingresar los parametros opcionales "Extras"

            Console.WriteLine(coche3.getExtras());   //Revisar los estras del metodo


        }
    }

    class Coche
    {
        public Coche()   //Constructor
        {
            ruedas = 4;

            largo = 2300.5;

            ancho = 0.800;
        }

        public Coche(double largoCoche, double anchoCoche)   //Constructor 2
        {
            ruedas = 4;

            largo = largoCoche;

            ancho = anchoCoche;
        }

        public string getInfo ()      //Acceder a las propiedades privadas 
        {
            return "Informacion del coche:\n " + "Ruedas: " + ruedas + " \n Largo: " + largo + "\n Ancho: " + ancho;
        }

        //Para utilizar las demas propiedades debemos establecer un metodo setter,
        //Si lo utilizamos detro del metodo coche todos los coches lo tendran por defecto
        // Debe ser de tipo void ya que no devuelve nada, osea que no ejcuta un return

        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;    //Se utiliza la palabra reservada this para que no haya error de ambiguedad 
                                                 //ya que tanto el metodo como la variable tienen exactamente el mismo nombre
            this.tapiceria = tapiceria;          //this hace referencia a la variable antes declarada
        }

        //El metodo anterior debe tener su correspondiente getter.

        public string getExtras()
        {
            return "Extras del coche:\n " + "Climatizador: " + climatizador + "\n Tapiceria: " + tapiceria;
        }

        //Propiedades
        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private string tapiceria;

        

    }
}
