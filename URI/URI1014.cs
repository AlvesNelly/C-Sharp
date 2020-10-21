using System;
using System.Globalization;

namespace URI1014
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            int x;
            double y, consumoMedioKm;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            consumoMedioKm = x / y;

            Console.WriteLine(consumoMedioKm.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
            
        }

    }

}