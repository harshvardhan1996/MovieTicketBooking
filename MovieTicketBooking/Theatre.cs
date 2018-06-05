using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class Theatre
    {
        public int TheatreID { get; set; }
        public string TheatreName { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public int NumberOfScreens { get; set; }
        public List<Screen> Screens { get; set; }

        public Theatre(string TheatreName, string CityName, string Address, int NumberOfScreens)
        {
            Random ran = new Random();
            this.TheatreID = ran.Next();
            this.TheatreName = TheatreName;
            this.CityName = CityName;
            this.Address = Address;
            this.NumberOfScreens = NumberOfScreens;
            this.Screens = new List<Screen>(NumberOfScreens);
        }

        public void DisplayTheatreDetails()
        {
            Console.WriteLine("Threatre ID is: {0}", TheatreID);
            Console.WriteLine("Threatre Name is: {0}", TheatreName);
            Console.WriteLine("CityName is: {0}", CityName);
            Console.WriteLine("Address is: {0}", Address);
            Console.WriteLine("NumberOfScreens is: {0}", NumberOfScreens);
            Console.WriteLine("Screens Information:");

            foreach (Screen sc in Screens)
            {
                Console.WriteLine(sc);
            }
        }
    }
}
