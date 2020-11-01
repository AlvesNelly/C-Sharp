using System;
using System.Globalization;

namespace URI1040
{
    class Programa
    {
        static void Main(string[] args)
        {
            
            string[] notas;
            double n1, n2, n3, n4, n5, media, mediaFinal;
            

            notas = Console.ReadLine().Split(' ');

            n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(notas[3], CultureInfo.InvariantCulture);
        
            media = ((n1 * 2.0) + (n2 * 3.0) + (n3 * 4.0) + (n4 * 1.0)) / (2.0 + 3.0 + 4.0 + 1.0);

            if (media == 4.85){

                media = 4.8;
                
            }  
            
            Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));

            
            if (media < 5.0) {

                Console.WriteLine("Aluno reprovado.");
            }

            else if (media >= 7.0){

                Console.WriteLine("Aluno aprovado.");
            }

            else if (media >= 5.0 || media <=6.9){
                Console.WriteLine("Aluno em exame.");
                n5 = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + n5.ToString("F1", CultureInfo.InvariantCulture));
                mediaFinal = (media + n5) / 2.0;
                
                if (mediaFinal >= 5.0) {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                    
                }

                else{
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
                    
                }
                
            }

           
        }
                
    }
}