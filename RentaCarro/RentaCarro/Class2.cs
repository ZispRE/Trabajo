using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCarro
{
    internal class Reservacion
    {
        static double Reserva {  get; set; }

        public static double CalcReserva(int opc)
        {
            do
            {
                switch (opc)
                {
                    case 1:
                        Reserva = 500;
                        break;
                    case 2:
                        Reserva = 1000;
                        break;
                    case 3:
                        Reserva = 1500;
                        break;
                    case 4:
                        Reserva = 2000;
                        break;
                }
                return Reserva;
            } while (opc > 4 || opc < 0);
        }
        public static void MostrarReserva(double Precio)
        {
            Console.WriteLine($"El total de la reserva es: {Reserva }\nLa reserva con el precio es de:{Reserva + Precio}");

        }
    }
}
