using System;
using System.Globalization;

namespace URI1012
{
    class Programa
    {
        static void Main(string[] args)
        {
            string[] valoresArea;
            double valorA, valorB, valorC, triangulo, circulo, trapezio, quadrado, retangulo;

            valoresArea = Console.ReadLine().Split(' ');

            valorA = double.Parse(valoresArea[0]); 
            valorB = double.Parse(valoresArea[1]);
            valorC = double.Parse(valoresArea[2]);

            //  a) a área do triângulo retângulo que tem A por base e C por altura. = (base*altura)/2

            triangulo = (valorA * valorC) / 2;

            //  b) a área do círculo de raio C. (pi = 3.14159) = pi * r²

            circulo = 3.14159 * Math.Pow(valorC, 2);

            //  c) a área do trapézio que tem A e B por bases e C por altura. = altura (base maior * base menor) / 2

            trapezio = (valorC * (valorA + valorB))/ 2;

            //  d) a área do quadrado que tem lado B. = lado²

            quadrado = Math.Pow(valorB,2);

            //  e) a área do retângulo que tem lados A e B. = base * altura

            retangulo = valorA * valorB;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));


        }

    }

}