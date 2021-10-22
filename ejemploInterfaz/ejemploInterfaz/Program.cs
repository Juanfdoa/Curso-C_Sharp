using System;

namespace ejemploInterfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisoTransito General = new AvisoTransito();

            General.MostrarAviso();

            Console.WriteLine();

            AvisoTransito Especifico = new AvisoTransito("Director General Tansita", "Recuerde pagar su impuesto vehicular", "20/10/2021");

            Especifico.MostrarAviso();


        }
    }

}