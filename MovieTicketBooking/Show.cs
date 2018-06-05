using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class Show
    {
        public int ShowID { get; set; }
        public int MovieID { get; set; }
        public int TheatreID { get; set; }
        public int ScreenID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PlatinumSeatRate { get; set; }
        public decimal GoldSeatRate { get; set; }
        public decimal SilverSeatRate { get; set; }

        public Show(int MovieID, int TheatreID, int ScreenID, DateTime Startdate, DateTime EndDate, decimal PlatinumSeatRate, decimal GoldSeatRate, decimal SilverSeatRate)
        {
            Random ran = new Random();
            this.ShowID = ran.Next();
            this.MovieID = MovieID;
            this.TheatreID = TheatreID;
            this.ScreenID = ScreenID;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.PlatinumSeatRate = PlatinumSeatRate;
            this.GoldSeatRate = GoldSeatRate;
            this.SilverSeatRate = SilverSeatRate;
        }

        public void DisplayShoeDetails()
        {
            Console.WriteLine("Show ID is {0}", ShowID);
            Console.WriteLine("Movie ID is {0}", MovieID);
            Console.WriteLine("Theatre ID is {0}", TheatreID);
            Console.WriteLine("Screen ID is {0}", ScreenID);
            Console.WriteLine("Startdate is {0}", StartDate);
            Console.WriteLine("Enddate is {0}", EndDate);
            Console.WriteLine("PlatinumSeatRate is {0}", PlatinumSeatRate);
            Console.WriteLine("GoldSeatRate is {0}", GoldSeatRate);
            Console.WriteLine("SilverSeatRate is {0}", SilverSeatRate);
        }

    }
}
