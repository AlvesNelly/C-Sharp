using System;
using System.Globalization;

namespace URI1038
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            string[] pedido;
            double valorFinal;
            int escolha, quantidadePedido;
            valorFinal = 0.00;
            pedido = Console.ReadLine().Split(' ');

            escolha = int.Parse(pedido[0]);
            quantidadePedido = int.Parse(pedido[1]);
            
            if (escolha == 1){
                valorFinal = (double) quantidadePedido * 4.00;

            }

            else if (escolha == 2) {
                valorFinal = (double) quantidadePedido * 4.50;

            }

            else if (escolha == 3){

                valorFinal = (double) quantidadePedido * 5.00;
            }

            else if (escolha == 4){

                valorFinal = (double) quantidadePedido *  2.00;
            }

            else if (escolha == 5){

                valorFinal = (double) quantidadePedido * 1.50;
            }
            
            Console.WriteLine("Total: R$ " + valorFinal.ToString("F2", CultureInfo.InvariantCulture));


        }
                
    }

}
