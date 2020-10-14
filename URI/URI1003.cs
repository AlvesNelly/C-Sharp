using System;
using System.Globalization;

namespace URI1003
{
    class Programa
    {
        static void Main(string[] args)
        {
            int A, B, SOMA;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            SOMA = A + B;

            Console.WriteLine("SOMA = "+ SOMA);
        }

    }

}