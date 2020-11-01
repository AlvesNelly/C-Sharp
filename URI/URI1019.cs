using System;
using System.Globalization;

namespace URI1019
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            int segundos, horas, minutos, resto;
            

            segundos = int.Parse(Console.ReadLine());

            horas = segundos / 3600;
            resto = segundos % 3600;
            segundos = resto;

            minutos = resto / 60;
            resto = segundos % 60;
            segundos = resto;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
            
        }

    }

}