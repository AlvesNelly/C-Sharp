using System;
using System.Globalization;

namespace URI1010
{
    class Programa
    {
        static void Main(string[] args)
        {
            string[] vet1, vet2;
            int idPECA1, idPECA2, quantidadePECA1, quantidadePECA2;
            double valorPECA1, valorPECA2, valorPAGAR;

            vet1 = Console.ReadLine().Split(' ');
            vet2 = Console.ReadLine().Split(' ');

            
            idPECA1 = int.Parse(vet1[0]);
            quantidadePECA1 = int.Parse(vet1[1]);
            valorPECA1 = double.Parse(vet1[2]);

            idPECA2 = int.Parse(vet2[0]);
            quantidadePECA2 = int.Parse(vet2[1]);
            valorPECA2 = double.Parse(vet2[2]);
    
            valorPAGAR = (double) (quantidadePECA1 * valorPECA1) + (quantidadePECA2 * valorPECA2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valorPAGAR.ToString("F2", CultureInfo.InvariantCulture));
            
        }

    }

}