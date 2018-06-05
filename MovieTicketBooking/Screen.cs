using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class Screen
    {
        public int ScreenID { get; set; }
        public SortedList<int,string> Seats { get; set; }

        public Screen()
        {
            ScreenID = 1000;
            Seats = new SortedList<int, string>(50);
        }
    }
}
