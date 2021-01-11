using MovieTheater_System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System
{
    public class BoxOffice : MovieCollection, IBoxOffice
    {
        public string CashierID { get; set; }
        public List<Ticket> soldTickets = new List<Ticket>();
        public List<MovieTheater> theater = new List<MovieTheater>();
        public List<Session> sessionsSchedule = new List<Session>();

        public BoxOffice(string cashierID)
        {
            CashierID = cashierID;
        }

        public string SellTicket(string movie, DateTime schedule)
        {
            Ticket ticket = new Ticket(movie, schedule);
            ticket.CalculatePrice(schedule);
            soldTickets.Add(ticket);
            return ticket.TicketToString(ticket);
        }

        public bool CancelTicket(string ticketID)
        {
            foreach (Ticket ticket in soldTickets)
            {
                if (ticket.ticketID == ticketID)
                {
                    soldTickets.Remove(ticket);
                    return true;
                }
            }
            return false;
        }

        public string PrintTicket(string ticketID)
        {
            string ticketString = "";
            foreach (Ticket ticket in soldTickets)
            {
                if (ticket.ticketID == ticketID)
                {
                    ticketString = "";
                }
            }
            return ticketString;
        }

        public void CreateMovieTheater(string id)
        {
            MovieTheater movieTheater = new MovieTheater(id);
            theater.Add(movieTheater);
            Console.WriteLine("The movie theater " + movieTheater.theaterID + " was successfully created!");
        }









    }
}
