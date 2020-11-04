using System;
using System.Globalization;

namespace URI1043
{
    class Programa
    {
        static void Main(string[] args)
        {
            string[] numeros;
            double a, b, c, perimetro, area;

            numeros = Console.ReadLine().Split(' ');

            a = double.Parse(numeros[0]);
            b = double.Parse(numeros[1]);
            c = double.Parse(numeros[2]);

            if (a+b > c && a+c>b && b+c>a){
                perimetro = a + b + c;

                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));

            }

            else{

                area = ((a + b)*c)/2;

                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
            
        }

    }

}