using System;
using System.Globalization;

namespace URI1008
{
    class Programa
    {
        static void Main(string[] args)
        {
            int numFuncionario, numHorasTrabalhadas;
            double salarioHora, salarioTotal;

            numFuncionario = int.Parse(Console.ReadLine());
            numHorasTrabalhadas = int.Parse(Console.ReadLine());
            salarioHora = double.Parse(Console.ReadLine());
            salarioTotal = salarioHora * numHorasTrabalhadas;

            Console.WriteLine("NUMBER = " + numFuncionario);
            Console.WriteLine("SALARY = U$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
            
        }

    }

}