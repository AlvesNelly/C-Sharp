using System;
using System.Globalization;

namespace URI1011
{
    class Programa
    {
        static void Main(string[] args)
        {
            double raio, pi, volume;

            raio = double.Parse(Console.ReadLine());

            pi = 3.14159;

            volume = (double) (4.0/3.0) * pi * (raio*raio*raio);

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
            
        }

    }

}