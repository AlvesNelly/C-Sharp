using System;
using System.Globalization;

namespace URI1035
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            string[] valor;
            int a, b, c, d;

            valor = Console.ReadLine().Split(' ');

            a = int.Parse(valor[0]);
            b = int.Parse(valor[1]);
            c = int.Parse(valor[2]);
            d = int.Parse(valor[3]);

            if (b > c && d > a && c+d > a+b && c>0 && d>0 && a%2==0){

                Console.WriteLine("Valores aceitos");


            }
            
            else {

                Console.WriteLine("Valores nao aceitos");
            }
        }

    }

}