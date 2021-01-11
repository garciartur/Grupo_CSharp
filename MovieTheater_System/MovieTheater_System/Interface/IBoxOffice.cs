using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System.Interface
{
    interface IBoxOffice
    {
        string SellTicket(string movie, DateTime schedule);
        bool CancelTicket(string ticketID);
        string PrintTicket(string ticketID);
    }
}
