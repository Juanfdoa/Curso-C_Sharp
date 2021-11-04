using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //FORMA COMUN

            /* int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

             Console.WriteLine("Numeros Pares");

             List<int> numerosPares = new List<int>();

             foreach(int i in numeros)
             {
                 if(i % 2 == 0)
                 {
                     numerosPares.Add(i);
                 }
             }

             foreach(int i in numerosPares)
             {
                 Console.WriteLine(i);
             }


            //FORMA CON LINQ

            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Numeros Pares");

            IEnumerable<int> numerosPares = from numero in numeros where numero % 2 == 0 select numero;
      
            foreach(int i in numerosPares)
            {
                Console.WriteLine(i);
            }*/

            ControlEmpresaEmpleado CEO = new ControlEmpresaEmpleado();
            Console.WriteLine("Empleados CEO");
            CEO.getCEO();
            Console.WriteLine();
            Console.WriteLine("Empleados Ordenados Alfabeticamente");
            CEO.getEmpleadosOrdenados();
            Console.WriteLine();
            Console.WriteLine("Selecciona el Id de la empresa (1 = Google, 2 = Microsoft)");
            // CEO.empleadosEmpresa(int.Parse(Console.ReadLine()));
            string entrada = Console.ReadLine();
            try 
            { 
                int entradaId = Convert.ToInt32(entrada);
                CEO.empleadosEmpresa(entradaId);

            }catch(Exception)
            {
                Console.WriteLine("Has introducido un Id erroneo");
            }
        }
    }

    class Empresa
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public void getData()
        {
            Console.WriteLine("Empresa{0} con Id {1}", Nombre, Id);
        }
    }

    class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Cargo { get; set; }

        public double Salario { get; set; }

        //Clave foranea
        public int EmpresaId { get; set; }

        public void getDataEmpleado()
        {
            Console.WriteLine("Emleado {0} con Id {1}, Cargo {2} con Salario {3} y perteneciente a la Empresa{4}", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }

    class ControlEmpresaEmpleado
    {
        public ControlEmpresaEmpleado()
        {
            ListaEmpresas = new List<Empresa>();

            ListaEmpleados = new List<Empleado>();

            ListaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });

            ListaEmpresas.Add(new Empresa { Id = 2, Nombre = "Microsoft" });

            ListaEmpleados.Add(new Empleado { Id = 1, Nombre = "Juan", Cargo = "CEO", Salario = 998000, EmpresaId = 2 });

            ListaEmpleados.Add(new Empleado { Id = 2, Nombre = "Andres", Cargo = "CEO", Salario = 998000, EmpresaId = 1 });

            ListaEmpleados.Add(new Empleado { Id = 3, Nombre = "Carlos", Cargo = "Co-CEO", Salario = 998000, EmpresaId = 2 });

            ListaEmpleados.Add(new Empleado { Id = 4, Nombre = "Maria", Cargo = "Co-CEO", Salario = 998000, EmpresaId = 1 });
        }

        public void getCEO()
        {
            IEnumerable<Empleado> EmpleadosCEO = from empleado in ListaEmpleados where empleado.Cargo == "CEO" select empleado;

            foreach (Empleado empleado1 in EmpleadosCEO)
            {
                empleado1.getDataEmpleado();
            }
        }

        public void getEmpleadosOrdenados()
        {
            IEnumerable<Empleado> Empleados = from empleado in ListaEmpleados orderby empleado.Nombre select empleado;

            foreach (Empleado empleado1 in Empleados)
            {
                empleado1.getDataEmpleado();
            }

        }

        public void empleadosEmpresa(int ID)
        {
            
            IEnumerable<Empleado> EmpleadosE = from empleado in ListaEmpleados join  empresa in ListaEmpresas 
                                              on empleado.EmpresaId equals empresa.Id where empresa.Id == ID select empleado;

            foreach (Empleado empleado1 in EmpleadosE)
            {
                empleado1.getDataEmpleado();
            }

        }



        public List<Empresa> ListaEmpresas;
        public List<Empleado> ListaEmpleados;
    }
}
