using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieCollection movieCollection = new MovieCollection();
            movieCollection.AddMovie("O Clã das Adagas Voadoras");
            movieCollection.RemoveMovie("Shrek");
            Console.ReadLine();
        }
    }
}
