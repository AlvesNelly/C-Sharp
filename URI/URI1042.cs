using System;
using System.Globalization;

namespace URI1042
{
    class Programa
    {
        static void Main(string[] args)
        {
            string[] numeros;
            int a, b, c, maiorAB, maiorTOTAL, menor, medio;

            numeros = Console.ReadLine().Split(' ');

            a = int.Parse(numeros[0]);
            b = int.Parse(numeros[1]);
            c = int.Parse(numeros[2]);
            menor = 0;
            medio = 0;

            maiorAB = (a + b + Math.Abs(a - b))/2;

            

            if (maiorAB == a){
                menor = b;
                maiorTOTAL = (maiorAB + c + Math.Abs(maiorAB - c))/2;
                if (maiorTOTAL == maiorAB){
                    medio = (b + c + Math.Abs(b - c))/2;
                    if (medio == b){

                        menor = c;
                    }

                    else{

                        menor = b;
                    }

                }

                else if (maiorTOTAL == c){

                    medio = a;
                }
                Console.WriteLine(menor);
                Console.WriteLine(medio);
                Console.WriteLine(maiorTOTAL);
                Console.WriteLine();
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }

            else if (maiorAB == b){

                menor = a;
                
                maiorTOTAL = (maiorAB + c + Math.Abs(maiorAB - c))/2;
               
                if (maiorTOTAL == maiorAB){
                   medio = (a + c + Math.Abs(a - c))/2;
                    if (medio == a){

                        menor = c;
                    }

                    else{

                        menor = a;
                    }
 

                }

                else if (maiorTOTAL == c){

                    medio = b;
                }
                Console.WriteLine(menor);
                Console.WriteLine(medio);
                Console.WriteLine(maiorTOTAL);
                Console.WriteLine();
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            

            }
            
        }

    }

}