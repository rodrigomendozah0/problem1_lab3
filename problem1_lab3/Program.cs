using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1_lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruta;
            float pago, pagot, km;
            int cajas;
            Console.WriteLine("Ingrese el tipo de fruta: ");
            fruta = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de cajas a transportar:");
            cajas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la distancia recorrida: ");
            km = float.Parse(Console.ReadLine());
            pago = 0f;

            switch (fruta.ToLower())
            {
                case "naranja":
                    if (km < 30)
                    {
                        pago = 2f;
                    }
                    else
                    {
                        pago = 4f;
                    }
                    break;
                case "fresa":
                    if (km < 30)
                    {
                        pago = 6f;
                    }
                    else
                    {
                        pago = 9f;
                    }
                    break;
                case "mango":
                    if (km < 30)
                    {
                        pago = 3f;
                    }
                    else
                    {
                        pago = 5f;
                    }
                    break;
            }
            pagot = pago * cajas;
            Console.WriteLine("El pago por esa carga será de: S/" + pagot.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
