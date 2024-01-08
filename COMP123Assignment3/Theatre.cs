using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Assignment3
{
    class Theatre
    {
        List<Show> shows;
        public string Name { get; }
        
        public Theatre(string name)
        {
            Name = name;
            shows = new List<Show>();
        }
        public void AddShow(Show show)
        {
            shows.Add(show);
        }
        public void PrintShows()
        {
            Console.WriteLine($"\nTheatre Name: {Name}\n");
            Console.WriteLine($"----------All shows-----------\n");
            int count = 0;
            foreach (var showList in shows)
            {
                count++;
                Console.WriteLine($"{count}.{showList}");
            }
                               
        }
        public void PrintShows(Genre genre)
        {
            Console.WriteLine($"\nTheatre Name: {Name}\n");
            Console.WriteLine($"-------------Genre.{genre}-------------\n");
            int count = 0;
            foreach(var showList in shows)
            {
                Movie m = showList.Movie;
                Genre g = m.Genre;
                if (g.HasFlag(genre))
                {
                    count++;
                    Console.WriteLine($"{count}.{showList}");
                }
                   
            }
        }
        public void PrintShows(Day day)
        {
            Console.WriteLine($"\nTheatre Name: {Name}\n");
            Console.WriteLine($"-------------Day.{day}-------------\n");
            int count = 0;
            foreach(var showList in shows)
            {
                Day d = showList.Day;
                if (d == day)
                {
                    count++;
                    Console.WriteLine($"{count}.{showList}");
                }
                   
            }
        }
        public void PrintShows(Time time)
        {
            Console.WriteLine($"\nTheatre Name: {Name}\n");
            Console.WriteLine($"-------------Time {time}-------------\n");
            int count = 0;
            foreach (var showList in shows)
            {
                Time t = showList.Time;
                if (t==time)
                {
                    count++;
                    Console.WriteLine($"{count}.{showList}");
                }
                   
            }
        }
        public void PrintShows(string actor)
        {
            Console.WriteLine($"\nTheatre Name: {Name}\n");
            Console.WriteLine($"-------------Actor {actor}-------------\n");
            int count = 0;
            foreach (var showList in shows)
            {
                Movie m = showList.Movie;
                List<string> list = m.Cast;
                foreach (string l in list)
                {
                    if (l.Contains(actor))
                    {
                        count++;
                        Console.WriteLine($"{count}.{showList}");
                    }
                        
                }
            }

        }
        public void PrintShows(Day day, Time time)
        {
            Console.WriteLine($"\nTheatre Name: {Name}\n");
            Console.WriteLine($"-------------Day.{day} and Time {time}-------------\n");
            int count = 0;
            foreach (var showList in shows)
            {
                
                Day d = showList.Day;
                Time t = showList.Time;
                if (d == day&&t==time)
                {
                    count++;
                    Console.WriteLine($"{count}.{showList}");
                }
                    
            }
            
        }
    }
}
