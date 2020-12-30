using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_EstrturasDeRepeticao
{
    public interface IElement
    {
        int LowestElement();
        int HighestElement();
        double Average();
        void NthElement(int position);
        int LowestInBetween(int numberA, int numberB);
        int HighestInBetween(int numberA, int numberB);
        double AverageInBetween(int numberA, int numberB);
        int NthInBetween(int position, int numberA, int numberB);
    }
}
