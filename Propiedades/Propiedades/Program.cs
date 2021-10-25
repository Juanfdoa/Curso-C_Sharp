using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Empleado1 = new Empleado("Fernando");

            Empleado1.SALARIO = 1200;

            Empleado1.SALARIO += 500;   //Incrementar 

            Console.WriteLine("El salario es: " + Empleado1.SALARIO);

            Empleado1.SALARIO += 500;
            
        }
    }

    class Empleado
    {
        private string nombre;
        private double salario;

        public Empleado(string nombre)
        {
            this.nombre = nombre;
        }

        /*
        public void setSalario(double salario)
        {
            if(salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo, Se asignara o como salario");
                this.salario = 0;
            }
            else
            {
                this.salario = salario;
            }
        }

        public double getSalario()
        {
            return salario;
        }
        */

        public double evaluaSalario(double salario)
        {
            if (salario < 0) return 0;

            else return salario;
        } 


        //CREACION DE PROPIEDAD
        //simplificado
        /*
        public double SALARIO
        {
            get { return this.salario; }

            set { this.salario = evaluaSalario(value); }
        }
        */

        //MAS SIMPLIFICADO (BODIES AND OPERADOR LANDA)

        public double SALARIO
        {
            get => this.salario;

            set => this.salario = evaluaSalario(value);

        }
    }
}
