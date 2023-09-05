using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Ingrese el tipo de fruta (naranja/fresa/mango):");
            string tipoDeFruta = Console.ReadLine().ToLower();

            Console.WriteLine("Ingrese la distancia en kilómetros:");
            double distanciaEnKilometros = double.Parse(Console.ReadLine());

            double precioPorCaja = 0.0;

            if (distanciaEnKilometros < 30)
            {
                switch (tipoDeFruta)
                {
                    case "naranja":
                        precioPorCaja = 2.00;
                        break;
                    case "fresa":
                        precioPorCaja = 6.00;
                        break;
                    case "mango":
                        precioPorCaja = 3.00;
                        break;
                    default:
                        Console.WriteLine("Tipo de fruta no válido.");
                        return;
                }
            }
            else
            {
                switch (tipoDeFruta)
                {
                    case "naranja":
                        precioPorCaja = 4.00;
                        break;
                    case "fresa":
                        precioPorCaja = 9.00;
                        break;
                    case "mango":
                        precioPorCaja = 5.00;
                        break;
                    default:
                        Console.WriteLine("Tipo de fruta no válido.");
                        return;
                }
            }
            Console.WriteLine("Ingrese la cantidad de cajas de frutas:");
            int cantidadCajas = int.Parse(Console.ReadLine());

            double precioTotal = precioPorCaja * cantidadCajas;
            Console.WriteLine($"El precio total del transporte es: S/{precioTotal}");

            Console.ReadLine();
        }
    }
}
