using MovieTheater_System.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System
{
    public class Ticket : ITicket
    {
        public Session session { get; set; }
        public double price { get; set; }
        public string ticketID { get; private set; }

        public Ticket(string movie, DateTime schedule)
        {
            session = GetSession(movie, schedule);
            GenerateID();
        }

        public void CalculatePrice(DateTime schedule)
        {
            price = 0;
        }

        private void GenerateID()
        {
            int i = 9;
            do
            {
                Random random = new Random();
                ticketID += random;
                i--;
            }
            while (i > 0);
        }

        public string TicketToString(Ticket ticket)
        {
            string ticketDescription = "Movie: " + ticket.session.movie.Name + "\n;
            return ticketDescription;
        }

    }
}
