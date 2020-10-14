using System;
using System.Globalization;

namespace URI1002
{
    class Programa
    {
        static void Main(string[] args)
        {
            double area, n, raio;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n = 3.14159;
            area = n* (raio*raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

        }

    }

}