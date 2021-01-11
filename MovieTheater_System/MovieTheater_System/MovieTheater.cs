using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System
{
    public class MovieTheater
    {
        public List<Session> playing = new List<Session>();
        public string theaterID { get; set; }

        public MovieTheater(string id)
        {
            theaterID = id;
        }

        public void ScheduleMovie(string movie, DateTime schedule)
        {
            if (FreeSchedule(schedule))
            {
                var session = new Session(movie, schedule);
                playing.Add(session);
                Console.WriteLine(session.movie.Name + " was successfully scheduled!");
            }
            else Console.WriteLine("This schedule is not avaiable!");         
        }

        public void DescheduleMovie(DateTime schedule)
        {
            if (!FreeSchedule(schedule))
            {
                foreach (Session session in playing)
                {
                    if (session.schedule == schedule)
                    {
                        playing.Remove(session);
                        Console.WriteLine(session.movie.Name + " was successfully descheduled!");
                    }
                }
            }
            else
                    Console.WriteLine("This schedule was not found!");
        }

        public bool FreeSchedule(DateTime schedule)
        {
            foreach (Session session in playing)
            {
                if (session.schedule == schedule) 
                    return false;
            }         
            return true;
        }
    }
}
