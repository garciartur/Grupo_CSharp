using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System
{
    public class MovieTheater
    {
        public string Id { get; private set; }
        public List<Movie> Playing { get; private set; }
        public List<DateTime> Schedule { get; private set; }
        public int Seats { get; private set; }

        public MovieTheater(string id, int seats)
        {
            Id = id;
            Seats = seats;
        }


    }
}
