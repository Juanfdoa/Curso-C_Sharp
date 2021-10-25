using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos<DateTime> Personas = new AlmacenObjetos<DateTime>(3);    //Se debe especificar el tipo de dato dento de patentesis angular

            //Personas.agregar("Juan");      //Tipo string

            //Personas.agregar("Fernando");

            //Personas.agregar("Andres");


            //string getPersona = (string)Personas.getElemento(1);   //se debe crear un variable para almacenar los datos y hacer un casting
            //para convertir de tipo object a tipo string

            //string getPersona = Personas.getElemento(1);              //con la clase generica no se usa el casting

            //Console.WriteLine(getPersona);



            //Personas.agregar(new Empleado(277000));     //Tipo Empleado

            //Personas.agregar(new Empleado(250000));

            //Personas.agregar(new Empleado(200000));

            //Empleado Salario = (Empleado)Personas.getElemento(1);   //Tambien se debe hacer un casting para convertir a tipo Empleado si se usa el objecto
            //Empleado Salario = Personas.getElemento(1);             //si se usa la clase generica se puede presindir delcasting

            //Console.WriteLine(Salario.getSalario());                //Se deben llamar la variable creada anteriormente (salario) y la creada en la clase empleado (getSalario)


            Personas.agregar(new DateTime());

            Personas.agregar(new DateTime());

            Personas.agregar(new DateTime());

            DateTime fecha = Personas.getElemento(1);

            Console.WriteLine(fecha);


        }
    }

    class AlmacenObjetos<T>                      //Clase generica para recibir cualquier tipo de dato
    {
        public AlmacenObjetos(int z)
        {
            datosElemento = new T[z];    //z va ha ser igual al numero de posiciones que tendra el array
                                              

        }

        public void agregar (T obj)   //Object puede recibir como parametro cualquier tipo de dato
        {
            datosElemento[i] = obj;

            i++;
        }

        public T getElemento(int i)
        {
            return datosElemento[i];        //devolver los datos insertador en la posicion del parametro
        }
        

        private T[] datosElemento;

        private int i = 0;
    }

    class Empleado
    {
        public Empleado(double salario)   //constructor
        {
            this.salario = salario;
        }

        public double getSalario()     //getter
        {
            return salario;
        }
        private double salario;
    }
}
