using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System.Interface
{
    interface ITicket
    {
        void CalculatePrice(DateTime schedule);
    }
}
