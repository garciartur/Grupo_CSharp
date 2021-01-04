using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System
{
    public class MovieSession : MovieCollection
    {
        public Movie Playing { get; set; }
        public MovieTheater Theater{ get; private set;}
        public DateTime Schedule { get; private set; }
        public int AvaiableSeats { get; private set; }
        public int SessionsQty { get; private set; }

        public MovieSession(string movie, string theater, DateTime schedule, )
        {

            Playing = GetMovie(movie);
            Theater = GetTheater(theater);
            AvaiableSeats = Playing.Seats;
            SessionsQty++;
        }

        public GetTheater(string )

    }
}
