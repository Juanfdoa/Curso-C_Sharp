using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploInterfaz
{
    class AvisoTransito : IAviso
    {
        public AvisoTransito()
        {
            remitente = "Agencia de transito y Transporte";

            mensaje = "Pague su impuesto vehicular antes de la fecha estipulada, si ya realizo el pago omita este mensaje";

            fecha = "22/10/2021";
        }

        public AvisoTransito(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;

            this.mensaje = mensaje;

            this.fecha = fecha;
        }

        public string getFecha()
        {
            return fecha;

        }

        public void MostrarAviso()
        {
            Console.WriteLine("Mensaje: {0} enviado por: {1} el dia: {2}", mensaje, remitente, fecha);
        }

        private string remitente;

        private string mensaje;

        private string fecha;


    }
}
