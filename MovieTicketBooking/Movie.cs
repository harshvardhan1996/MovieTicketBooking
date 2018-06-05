using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Cast { get; set; }
        public double Duration { get; set; }
        public string Story { get; set; }
        public string Type { get; set; }

        public Movie(string MovieName, string Director, string Producer, string Cast, double Duration, string Story, string Type)
        {
            Random random = new Random();
            this.MovieID = random.Next();
            this.MovieName = MovieName;
            this.Director = Director;
            this.Producer = Producer;
            this.Cast = Cast;
            this.Duration = Duration;
            this.Story = Story;
            this.Type = Type;
        }

        public void DisplayMovieDetails()
        {
            Console.WriteLine("Movie Id is : {0}", MovieID);
            Console.WriteLine("Movie Name is : {0}", MovieName);
            Console.WriteLine("Director is : {0}", Director);
            Console.WriteLine("Porducer is : {0}", Producer);
            Console.WriteLine("Cast is : {0}", Cast);
            Console.WriteLine("Duration is : {0}", Duration);
            Console.WriteLine("Story is : {0}", Story);
            Console.WriteLine("Type is : {0}", Type);
        }





    }
}
