using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System
{
    public class Session : MovieCollection
    {
        public Movie movie { get; set; }
        public DateTime schedule { get; private set; }

        public Session(string movie, DateTime schedule)
        {
            this.movie = GetMovie(movie);
            this.schedule = schedule;         
        }
    }
}
