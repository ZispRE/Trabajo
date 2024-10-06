using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RentaCarro
{
     internal class Vehiculo
    {
        public string Modelo { get; set; }
        public double Precio { get; set; }




        public class Descuento
        {
            public double DescApli { get; set;}

            public double CalcDescuento( double Precio, int opc)
            {
                switch (opc)
                {
                    case 1:
                        DescApli = Precio * 0.10;
                        break;
                    case 2:
                        DescApli = Precio * 0.20;
                        break;
                    case 3:
                        DescApli =  Precio * 0.50;
                        break;
                    case 4:
                        DescApli = Precio *  0.70;
                        break;
                }
                return DescApli;

                
            }
           public void MostraDesc(double Precio)
            {
                Console.WriteLine($"El monto con descuento es: {Precio - DescApli}");
            }
        }
        public void MostrarinfoVehi()
        {
            Console.WriteLine($"Modelo: {Modelo}    Precio: {Precio}");
        }
    }
}
