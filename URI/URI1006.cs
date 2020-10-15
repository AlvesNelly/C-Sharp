using System;
using System.Globalization;

namespace URI1006
{
    class Programa
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;
            A = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            MEDIA = ((A*2) + (B*3) + (C*5)) / 10;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
        }

    }

}