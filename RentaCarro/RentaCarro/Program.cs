using System;
namespace RentaCarro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int opc = 0;
            double Precio = 0;
            Console.WriteLine("Ingrese el precio del vehiculo");
            Precio = Convert.ToDouble(Console.ReadLine());
            Vehiculo vehiculo = new Vehiculo { Modelo = "Honda", Precio = Precio };
            Vehiculo.Descuento descuento = new Vehiculo.Descuento();
            Console.WriteLine("Elija una opcion para aplicar un descuento");
            Console.WriteLine("1. 10%  2. 20%  3. 50% 4. 70%");
            opc = Convert.ToInt32(Console.ReadLine());
            descuento.CalcDescuento(Precio , opc);
            vehiculo.MostrarinfoVehi();
            descuento.MostraDesc(Precio);



            Console.WriteLine("Elija una opcion para aplicar el tiempo de reserva");
            Console.WriteLine("1. 5 dias  2. 10 dias  3. 15 dias 4. 20 dias");
            opc = Convert.ToInt32(Console.ReadLine());
            //Reservacion reservacion = new Reservacion();
            double calc = Reservacion.CalcReserva(opc);
            Reservacion.MostrarReserva(Precio);

            
            
        }
    }
}