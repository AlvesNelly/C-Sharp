using System;
using System.Globalization;

namespace URI1044
{
    class Programa
    {
        static void Main(string[] args)
        {
            string[] numeros;
            int a, b;

            numeros = Console.ReadLine().Split(' ');

            a = int.Parse(numeros[0]);
            b = int.Parse(numeros[1]);
            
            if (a%b==0 || b%a==0){

                Console.WriteLine("Sao Multiplos");
            }
            
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }

    }

}