using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_EstrturasDeRepeticao
{
    public class LinqElement : IElement
    {
        public IEnumerable<int> CollectionNumbers { get; private set; }

        public LinqElement(int[] collectionNumbers)
        {
            CollectionNumbers = OrderByAscending(collectionNumbers);
        }

        public LinqElement(List<int> collectionNumbers)
        {
            CollectionNumbers = OrderByAscending(collectionNumbers);
        }

        private IEnumerable<int> OrderByAscending(int[] collectionNumbers)
        {
            var queryOrder =
                from number in collectionNumbers
                orderby number ascending
                select number;
            return queryOrder;
        }

        private IEnumerable<int> OrderByAscending(List<int> collectionNumbers)
        {
            var queryOrder =
                from number in collectionNumbers
                orderby number ascending
                select number;
            return queryOrder;
        }

        //1. Menor elemento
        public int LowestElement()
        {
            return CollectionNumbers.Min();
        }

        //2. Maior elemento
        public int HighestElement()
        {
            return CollectionNumbers.Max();
        }

        //3. Média dos elementos
        public double Average()
        {
            return CollectionNumbers.Average();
        }

        //4. Quarto elemento da sequência
        public void NthElement(int position)
        {
            int i = 0;
            int nthElement = 0;
            if (CollectionNumbers.Count() < position)
            {
                Console.WriteLine("A sequência possui menos de {0} elementos!", position);
                return;
            }
            foreach (int number in CollectionNumbers)
            {
                if (i == position - 1) nthElement = number;
                i++;
            }
            Console.WriteLine("{0}º elemento da sequência: {1}", position, nthElement);
        }

        //5. Menor elemento entre 20 e 300
        public int LowestInBetween(int numberA, int numberB)
        {
            var queryRange = Range(numberA, numberB);
            return queryRange.Min();
        }

        //6. Maior elemento entre 20 e 300
        public int HighestInBetween(int numberA, int numberB)
        {
            var queryRange = Range(numberA, numberB);
            return queryRange.Max();
        }

        //7. Maior elemento entre 20 e 300
        public double AverageInBetween(int numberA, int numberB)
        {
            var queryRange = Range(numberA, numberB);
            return queryRange.Average();
        }

        //8. Quarto elemento entre 20 e 300
        public void NthInBetween(int position, int numberA, int numberB)
        {
            int i = 0;
            int nthElement = 0;
            var queryRange = Range(numberA, numberB);

            if (queryRange.Count() < position)
            {
                Console.WriteLine("A sequência possui menos de {0} elementos!", position);
                return;
            }
            foreach (int number in queryRange)
            {
                if (i == position - 1) nthElement = number;
                i++;
            }
            Console.WriteLine("{0}º elemento da sequência: {1}", position, nthElement);
        }

        private IEnumerable<int> Range(int numberA, int numberB)
        {
            int highestNumber = HighestNumber(numberA, numberB);
            int lowestNumber = LowestNumber(numberA, numberB);

            var queryRange =
                from number in CollectionNumbers
                where number >= lowestNumber && number <= highestNumber
                select number;

            return queryRange;
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

        //9. List de Element 
        public List<Element> ElementList()
        {
            List<Element> elementList = new List<Element>();

            foreach (int number in CollectionNumbers)
            {
                Element element = new Element();
                element.Valor = number;
                elementList.Add(element);
            }
            foreach (Element element in elementList) Console.WriteLine(element.Valor);

            return elementList;
        }

        int IElement.NthInBetween(int position, int numberA, int numberB)
        {
            throw new NotImplementedException();
        }
    }
}
