using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_EstrturasDeRepeticao
{
    public class ListElement
    {
        public List<int> CollectionNumbers = new List<int>();
        public ListElement(int[] collectionNumbers)
        {
            foreach(int number in collectionNumbers) CollectionNumbers.Add(number);
        }

        //1. Menor elemento
        public int LowestElement()
        {
            return CollectionNumbers.Min();
        }

        public int HighestElement()
        {
            return CollectionNumbers.Max();
        }

        public int Average()
        {
            int sum = 0;
            foreach (int number in CollectionNumbers) sum += number;
            return sum / CollectionNumbers.Count;
        }

        public int NthElement(int position)
        {
            return CollectionNumbers[position-1];
        }

        public int LowestInBetween(int numberA, int numberB)
        {
            List<int> range = new List<int> { numberA, numberB };
            var sublist = Sublist(range);
            return sublist.Min();
        }

        public int HighestInBetween(int numberA, int numberB)
        {
            List<int> range = new List<int> { numberA, numberB };
            var sublist = Sublist(range);
            return sublist.Max();
        }

        public int AverageInBetween(int numberA, int numberB)
        {
            List<int> range = new List<int> { numberA, numberB };
            var sublist = Sublist(range);
            int sum = 0;
            foreach (int number in sublist) sum += number;
            return sum / sublist.Count;
        }

        public void NthInBetween(int position, int numberA, int numberB)
        {
            List<int> range = new List<int> { numberA, numberB };
            var sublist = Sublist(range);
            if (range.Count() < position) Console.WriteLine("Não existe {0}ª posição na sequência entre {1} e {2}, que só possui {3} elementos", position, range.Min(), range.Max(), sublist.Count());
            else Console.WriteLine("O {0}º elemento entre {1} e {2}: {3}", position, range.Min(), range.Max(), sublist[position-1]);
        }

        public List<Element> ElementList()
        {
            List<Element> elementList = new List<Element>();
            foreach(int number in CollectionNumbers)
            {
                Element element = new Element();
                element.Valor = number;
                elementList.Add(element);
            }
            foreach(Element element in elementList) Console.WriteLine(element.Valor);
            return elementList;
        }

        private List<int> Sublist(List<int> range)
        {
            List<int> sublist = new List<int>();

            foreach (int number in CollectionNumbers)
            {
                if (number >= range.Min() && number <= range.Max()) sublist.Add(number);
            }
            return sublist;
        }




    }
}
