using System;
using System.IO;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new ManejoArchivos();

            miArchivo.mensaje();
        }
    }

    class ManejoArchivos
    {
        StreamReader archivo = null;

        int contador = 0;

        string linea;

        public ManejoArchivos()
        {
            archivo = new StreamReader(@"C:\Users\Juan.acevedo\Desktop\Varios\archivo.txt");   //fichero externo

            while((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);

                contador++;
            }
        }

        public void mensaje()
        {
            Console.WriteLine("hay {0} lineas", contador);
        }

        //SINTAXIS DESTRUCTOR

        ~ManejoArchivos()
        {
            archivo.Close();

        }

        //solo se usan en clases
        //cada clase solo puede tener un destructor
        //no se heredan
        //no se llaman
        //no tiene modificadore
        //no es recomendable utilizar destructores
    }
}
