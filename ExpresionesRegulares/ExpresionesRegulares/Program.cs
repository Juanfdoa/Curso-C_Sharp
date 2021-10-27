using System;
using System.Text.RegularExpressions;

namespace ExpresionesRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Las expresiones regulares pueden servir para hacer busquedas en l programa
            //Ejemplo 1
            string frase = "Mi nombre es Juan y mi n° es(+57)311-312-31-07 y mi codigo postal es 26679";

            string Patron = "[J]";                           //Expresion regular para buscar letras

            Regex MiRegex =  new Regex(Patron);              //Clase regex

            MatchCollection elMatch = MiRegex.Matches(frase); //Coleccion para guardar las coincidencias

            if (elMatch.Count > 0) Console.WriteLine("Se ha encontrado una J");
            else Console.WriteLine("No se ha encontrado J");


            //Ejemplo 2
            string frase1 = "Mi nombre es Juan y mi n° es(+57)311-312-31-07 y mi codigo postal es 26679";

            string Patron1 = @"\d{3}-";                           //Expresion regular para buscar valores numericos \d(por unidad)

            Regex MiRegex1 = new Regex(Patron1);              //Clase regex

            MatchCollection elMatch1 = MiRegex1.Matches(frase1); //Coleccion para guardar las coincidencias

            if (elMatch1.Count > 0) Console.WriteLine("Se ha encontrado un numero de telefono");
            else Console.WriteLine("No se han encontrado numeros");


            //Ejemplo3
            string frase2 = "Mi web es http://tuaportealmundo.com";

            string Patron2 = "https?://(www.)?tuaportealmundo.com";                           //Expresion regular con cuantificadore el simbolo ? se refiere a que 
                                                                                              //la palabra puede estar presente o no
            Regex MiRegex2 = new Regex(Patron2);              //Clase regex

            MatchCollection elMatch2 = MiRegex2.Matches(frase2); //Coleccion para guardar las coincidencias

            if (elMatch2.Count > 0) Console.WriteLine("Se ha encontrado una web");
            else Console.WriteLine("No se ha encontrado web");

            //NOTA: Generador de expresiones regulares

        }
    }
}
