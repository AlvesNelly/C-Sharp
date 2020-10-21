using System;
using System.Globalization;

namespace URI1018
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            int valor, nota100, nota50, nota20, nota10, nota5, nota2, nota1, resto, valorAtual;
            

            valor = int.Parse(Console.ReadLine());

            nota100 = valor / 100;
            resto = valor % 100;
            valorAtual = resto;
            
            nota50 = valorAtual / 50;
            resto = valorAtual % 50;
            valorAtual = resto;
           
            nota20 = valorAtual / 20;
            resto = valorAtual % 20;
            valorAtual = resto;
           
            nota10 = valorAtual / 10;
            resto = valorAtual % 10;
            valorAtual = resto;
           
            nota5 = valorAtual / 5;
            resto = valorAtual % 5;
            valorAtual = resto;

            nota2 = valorAtual / 2;
            resto = valorAtual % 2;
            valorAtual = resto;

            nota1 = valorAtual / 1;

           

            Console.WriteLine(valor);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");
            
        }

    }

}