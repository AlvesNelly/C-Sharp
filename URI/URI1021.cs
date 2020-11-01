using System;
using System.Globalization;

namespace URI1021
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            string[] valor;
            int valornota, valormoeda, resto, nota100, nota50, nota20, nota10, nota5, nota2, moeda1, moeda50, moeda25, moeda10, moeda05, moeda01;
            

            valor = Console.ReadLine().Split('.');

            valornota = int.Parse(valor[0]);
            valormoeda = int.Parse(valor[1]);

            nota100 = valornota / 100;
            resto = valornota % 100;
            valornota = resto;
            
            nota50 = valornota / 50;
            resto = valornota % 50;
            valornota = resto;
           
            nota20 = valornota / 20;
            resto = valornota % 20;
            valornota = resto;
           
            nota10 = valornota / 10;
            resto = valornota % 10;
            valornota = resto;
           
            nota5 = valornota / 5;
            resto = valornota % 5;
            valornota = resto;

            nota2 = valornota / 2;
            resto = valornota % 2;
            valornota = resto;

            moeda1 = valornota / 1;
            resto = valornota % 1;
            valornota = resto;

            moeda50 = valormoeda / 50;
            resto = valormoeda % 50;
            valormoeda = resto;

            moeda25 = valormoeda / 25;
            resto = valormoeda % 25;
            valormoeda = resto;

            moeda10 = valormoeda / 10;
            resto = valormoeda % 10;
            valormoeda = resto;

            moeda05 = valormoeda / 5;
            resto = valormoeda % 5;
            valormoeda = resto;

            moeda01 = valormoeda;

           

            Console.WriteLine("NOTAS:");
            Console.WriteLine(nota100 + " nota(s) de R$ 100.00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50.00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20.00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10.00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5.00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda05 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda01 + " moeda(s) de R$ 0.01");
            
        }

    }

}