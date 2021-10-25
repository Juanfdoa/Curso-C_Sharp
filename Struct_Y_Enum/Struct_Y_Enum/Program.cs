using System;

namespace Struct_Y_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado Fernando = new Empleado(250000, 35000);

            Fernando.cambiaSalario(Fernando, 10000);
            //si se hace la modificacion con clase se efectua
            //si se hace con struct no se hace la modificacion
            //Clases (heap), struct(stack)

            Console.WriteLine(Fernando);

            Estaciones alergia = Estaciones.Primavera;  //solo muestra las posibilidades del enum
            Estaciones? alergia2 = null;   //Para valores nulos
            Console.WriteLine(alergia);

            Bonus Juan = Bonus.Bueno;

            double bonusJuan = (double)Juan;   //Casting

            double salarioJuan = 12000 + bonusJuan;

            Console.WriteLine(salarioJuan);
        }
    }
    //DIFERENCIAS DE STRUCTS
    //No permite el constructor por defecto
    //El compilador no inicia los campos.
    //No se puede la sobrecarga
    //No heredan de otras clases, solo de interfases
    //y son selladas

    public class Empleado                                 //Para cambiar una clase a una estructura solo se debe cambiar la palabra reservada class por struct
    {                                                     //Visualmente no tiene cambio alguno la diferencia esta en la memoria que ocupan
        private double salarioBase, comision;

        public Empleado(int salarioBase, int comision)
        {
            this.salarioBase = salarioBase;

            this.comision = comision;
        }

        public override string ToString()     //Para sobrescribir a texto plano
        {
            return string.Format("El salario del empleado es igual a: {0} mas una comision de: {1}", this.salarioBase, this.comision);
        }

        public void cambiaSalario(Empleado emp, double incremento)
        {
            emp.salarioBase += incremento;  //incremento salario

            emp.comision += incremento;   //incremento comision
        }
    }


    //DECLARACION DE ENUM

    enum Estaciones { Primavera, Verano, Otoño, Invierno};  //constantes de tipo enumerado

    enum Bonus { Bajo=500, Normal=1000, Bueno=1500, Extra=3000};
}
