using System;
using System.Globalization;

namespace URI1009
{
    class Programa
    {
        static void Main(string[] args)
        {
            string nomeFuncionario;
            double salarioFixo, bonusVenda, salarioTotal;

            nomeFuncionario = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine());
            bonusVenda = double.Parse(Console.ReadLine());
            salarioTotal = salarioFixo + (bonusVenda * 15.0 / 100.0);

            Console.WriteLine("TOTAL = R$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
            
        }

    }

}