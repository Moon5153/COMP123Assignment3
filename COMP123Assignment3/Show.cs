using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Assignment3
{
    class Show
    {
        public double Price { get; }
        public Day Day { get; }
        public Movie Movie { get; }
        public Time Time { get; }
        public Show(Movie movie,Day day,double price,Time time)
        {
            Movie = movie;
            Day = day;
            Price = price;
            Time = time;
        }
        public override string ToString()
        {
            return $"Movie {Movie}Day: {Day}\nPrice: {Price}$\nTime: {Time}\n";
        }
    }
}
