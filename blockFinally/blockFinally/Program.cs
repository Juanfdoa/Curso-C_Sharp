using System;

namespace blockFinally
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.StreamReader archivo = null;

            try
            {
                string linea;

                int contador = 0;

                string path = @"C:\Users\Juan.acevedo\Desktop\Varios/archivo.txt";  //Conexion a fichero

                archivo = new System.IO.StreamReader(path);  //Abrir conexion debe cerrarse para que no consuma recursos

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);

                    contador++;

                }

            }
            catch(Exception ex)
            {

                Console.WriteLine("Error con la lectura del archivo");
            }
            finally
            {
                if (archivo != null) archivo.Close(); // Cerrar la conexion

                Console.WriteLine("Conexion con el fichero cerrada");

            }
        }
    }
}
