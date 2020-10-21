using System;
using System.Globalization;

namespace URI1017
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            int tempoGasto, velocidadeMedia;
            double quantidadeLitros;



            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            quantidadeLitros = (double) (velocidadeMedia * tempoGasto) / 12;

            Console.WriteLine(quantidadeLitros.ToString("F3", CultureInfo.InvariantCulture));
            
        }

    }

}