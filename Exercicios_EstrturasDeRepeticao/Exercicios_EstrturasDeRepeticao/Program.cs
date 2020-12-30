﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_EstrturasDeRepeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] collectionNumbers = { 9, 11, 482, 237, 934, -40 };
            //DESAFIO #1
            ArrayElement collectionArray = new ArrayElement( collectionNumbers );

            //1. Menor elemento
            Console.WriteLine("Menor elemento da sequência: " + collectionArray.LowestElement());

            //2. Maior elemento
            Console.WriteLine("Maior elemento da sequência: " + collectionArray.HighestElement());

            //3. Média dos elementos
            Console.WriteLine("Média dos elementos: " + collectionArray.Average());

            //4. Quarto elemento da sequência
            Console.WriteLine("Quarto elemento da sequência: " + collectionArray.NthElement(4));

            //5. Menor elemento entre 20 e 300
            Console.WriteLine("Menor elemento entre 20 e 30: " + collectionArray.LowestInBetween(20, 300));

            //6. Maior elemento entre 20 e 300
            Console.WriteLine("Maior elemento entre 20 e 30: " + collectionArray.HighestInBetween(20, 300));

            //7. Média dos elementos entre 20 e 300
            Console.WriteLine("Média dos elementos entre 20 e 30: " + collectionArray.AverageInBetween(20, 300));

            //8. Quarto elemento entre 20 e 300
            collectionArray.NthInBetween(4, 20, 300);

            //9. Array de Element 
            var elementArray = collectionArray.ElementArray();

            Console.ReadLine();
        }
    }
}