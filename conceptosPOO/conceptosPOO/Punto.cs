using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceptosPOO
{
    class Punto
    {
        public Punto(int x, int y)
        {
            this.x = x;

            this.y = y;

            contadorDeObjectos++;
        }

        public Punto()
        {
            this.x = 0;

            this.y = 0;

            contadorDeObjectos++;

        }

        public double Distancia(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;

            int yDif = this.y - otroPunto.y;

            double DistaciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return DistaciaPuntos;
        }

        public static int ContadorDeObjectos() => contadorDeObjectos;  //para devolver el valor de una variable static

        private int x, y;

        //VARIABLES STATIC.
        //Estas varibles pueden ser compartidas pero no pueden
        //ser modificadas por ningun objecto, solo la puede modificar la clase dueña

        private static int contadorDeObjectos = 0;
    }
}
