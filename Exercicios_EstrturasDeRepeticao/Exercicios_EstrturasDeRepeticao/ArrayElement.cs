using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_EstrturasDeRepeticao
{
    public class ArrayElement
    {
        public int[] CollectionNumbers { get; private set; }
        public ArrayElement(int[] collectionNumbers)
        {
            CollectionNumbers = collectionNumbers;
        }

        //1. Menor elemento
        public int LowestElement()
        {
            int lowestNumber = CollectionNumbers[0];

            for (int i = 0; i < CollectionNumbers.Length; i++)
            {
                if (CollectionNumbers[i] < lowestNumber) lowestNumber = CollectionNumbers[i];
            }
            return lowestNumber;
        }

        internal string LowestNumber()
        {
            throw new NotImplementedException();
        }

        //2. Maior elemento
        public int HighestElement()
        {
            int highestNumber = 0;

            for (int i = 0; i < CollectionNumbers.Length; i++)
            {
                if (CollectionNumbers[i] > highestNumber) highestNumber = CollectionNumbers[i];
            }
            return highestNumber;
        }

        //3. Média dos elementos
        public double Average()
        {
            int sum = 0;
            int elements;

            for (elements = 0; elements < CollectionNumbers.Length; elements++)
            {
                sum += CollectionNumbers[elements];
            }

            return sum / elements;
        }

        //4. Quarto elemento da sequência
        public int NthElement(int elementPosition)
        {
            return CollectionNumbers[elementPosition-1];
        }

        //5. Menor elemento entre 20 e 300
        public int LowestInBetween(int numberA, int numberB)
        {
            int highestNumber = HighestNumber(numberA, numberB);
            int lowestNumber = LowestNumber(numberA, numberB);
            int lowestInBetween = highestNumber;

            for (int i = 0; i < CollectionNumbers.Length; i++)
            {
                if (CollectionNumbers[i] >= lowestNumber && CollectionNumbers[i] <= highestNumber && CollectionNumbers[i] < lowestInBetween) lowestInBetween = CollectionNumbers[i];
            }

            return lowestInBetween;
        }

        //6. Maior elemento entre 20 e 300
        public int HighestInBetween(int numberA, int numberB)
        {
            int highestInBetween = 0;
            int highestNumber = HighestNumber(numberA, numberB);
            int lowestNumber = LowestNumber(numberA, numberB);

            for (int i = 0; i < CollectionNumbers.Length; i++)
            {
                if (CollectionNumbers[i] >= lowestNumber && CollectionNumbers[i] <= highestNumber && CollectionNumbers[i] > highestInBetween) highestInBetween = CollectionNumbers[i];
            }

            return highestInBetween;
        }

        private int HighestNumber(int numberA, int numberB)
        {
            if (numberA > numberB) return numberA;
            else return numberB;
        }

        private int LowestNumber(int numberA, int numberB)
        {
            if (numberA > numberB) return numberB;
            else return numberA;
        }

        //7. Média dos elementos entre 20 e 300
        public int AverageInBetween(int numberA, int numberB)
        {
            int highestNumber = HighestNumber(numberA, numberB);
            int lowestNumber = LowestNumber(numberA, numberB);
            int sum = 0;
            int elements = 0;

            for (int i = 0; i < CollectionNumbers.Length; i++)
            {
                if (CollectionNumbers[i] >= lowestNumber && CollectionNumbers[i] <= highestNumber)
                {
                    sum += CollectionNumbers[i];
                    elements++;
                }
            }

            return sum / elements;
        }

        //8. Quarto elemento entre 20 e 300
        public void NthInBetween(int position, int numberA, int numberB)
        {
            int highestNumber = HighestNumber(numberA, numberB);
            int lowestNumber = LowestNumber(numberA, numberB);
            int elements = 0;

            for (int i = 0; i < CollectionNumbers.Length; i++)
            {
                if (CollectionNumbers[i] >= lowestNumber && CollectionNumbers[i] <= highestNumber)
                {
                    elements++;
                    if (elements == position) Console.WriteLine("O {0}º elemento entre 20 e 30: {1}", position, CollectionNumbers[i]);
                }
            }
            if (elements < 4) Console.WriteLine("Não existe {0}º elemento na sequência, só existem {1} elementos entre 20 e 30", position, elements);
        }

        //9. Array de Element
        public Element[] ElementArray()
        {
            Element[] elementArray = new Element[CollectionNumbers.Length];

            for (int i = 0; i < CollectionNumbers.Length; i++)
            {
                Element newElement = new Element();
                newElement.Valor = CollectionNumbers[i];
                elementArray[i] = newElement;
            }
            for (int i = 0; i < elementArray.Length; i++) Console.WriteLine(elementArray[i].Valor);
            return elementArray;
        }
    }
}
