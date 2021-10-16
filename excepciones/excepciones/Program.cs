using System;

namespace excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Excepciones en C#
             * Son errores en tiempo de ejecucion que escapan al control del programador
             * Memoria Corrupta
             * Desbordamiento de pila
             * Sectores de disco duro defectuoso
             * Acceso a ficheros inexistentes
             * Conexiones a BBDD interrumpidas
             */

            //BLOQUE TRY... CATCH...

            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int miNumero;

            int intentos = 0;

            Console.WriteLine("Introduce un numero entre 0 y 100");

            do
            {
                intentos++;

                try
                {

                    miNumero = int.Parse(Console.ReadLine());

                } catch (FormatException ex)   // Fallo de formato si en vez de valor numerico se inserta un string
                {

                    Console.WriteLine("No has introducido un valor numérico, el valor sera tomado como cero(0)");
                    Console.WriteLine(ex.Message);
                    miNumero = 0;

                }catch (OverflowException ex)  // Fallo de int "numero demasiado extenso.
                {
                    Console.WriteLine("El numero insertado no es valido, intenta de nuevo, el valor tomado sera cero (0)");
                    Console.WriteLine(ex.Message);
                    miNumero = 0;

                }
                finally
                {
                    //codigo que se ejecuta siempre, se usa con bases de datos y/o ficheros
                }
                // se puede usar una excepcion generica con un solo catch (Exception ex){ pero no muestra la info pertinente, no recomendable
                // se puede poner una exception especifica (para dar un tratamiento especial )y despues una general para las demas exceptions
                // catch (Exception ex) when (ex.GetType()!=typeof(FormatException))  para ignorar una exception "filtro"
                // Exception throw para lanzae una ecepscion
                if (miNumero > aleatorio) Console.WriteLine("El numero es mas bajo");

                if (miNumero < aleatorio) Console.WriteLine("El numero es mas alto");

            } while (aleatorio != miNumero);

            Console.WriteLine("Correcto, te ha tomado " + intentos + " intentos");

            Console.WriteLine("A partir de aqui el programa continuaria");
        }
    }
}
