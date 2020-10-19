using System;
using System.Globalization;

namespace URI1013
{
    class Programa
    {
        static void Main(string[] args)
        {
            string[] numeros;
            int a, b, c, maiorAB, maiorTOTAL;

            numeros = Console.ReadLine().Split(' ');

            a = int.Parse(numeros[0]);
            b = int.Parse(numeros[1]);
            c = int.Parse(numeros[2]);

            maiorAB = (a + b + Math.Abs(a - b))/2;

            maiorTOTAL = (maiorAB + c + Math.Abs(maiorAB - c))/2;

            Console.WriteLine(maiorTOTAL + " eh o maior");
            
        }

    }

}