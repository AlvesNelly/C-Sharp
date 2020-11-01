using System;
using System.Globalization;

namespace URI1036
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            string[] valor;
            double a, b, c, delta, r1, r2;

            valor = Console.ReadLine().Split(' ');

            a = double.Parse(valor[0]);
            b = double.Parse(valor[1]);
            c = double.Parse(valor[2]);
            
            delta = Math.Pow(b,2) - 4 * a * c;

            if (a == 0 || delta < 0){
                Console.WriteLine("Impossivel calcular");

            }

            else {

                r1 = (-b + Math.Sqrt(delta)) / (2*a);
                r2 = (-b - Math.Sqrt(delta))/(2*a);
                
                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
                
            }
            
        }

    }

}