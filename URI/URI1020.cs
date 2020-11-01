using System;
using System.Globalization;

namespace URI1020
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            int dias, meses, anos, resto;

            dias = int.Parse(Console.ReadLine());

            anos = dias / 365;
            resto = dias % 365;
            dias = resto;

            meses = dias / 30;
            resto = dias % 30;
            dias = resto;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
            
        }

    }

}