using ConsoleApp4.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
    

        static void Main(string[] args) 
        {
            Johnson Mr_Johnson = new Johnson();
            Lindsay Lindsay = new Lindsay();
            Meghan Meghan = new Meghan();

            //TODO make the next teacher method a Interface and see how to incorporate those. 

            // could console app this here very easily now.
            // Could have a console app method, and a method here that keeps going 
            // Could loop it so you can run them one after another. 
            Combat.Hallway(Mr_Johnson, Meghan);

            Console.ReadKey(); 

        

          
        }

        //public Day[] DayMaker(List<Day> monday, string[] periods)
        //{
        //    List<Day> Weekdays = new List<Day>();
        //    string[] PeriodsMonday = new string[] { "Math", "English", "Science", "HomeEconmics", "History", "MicroEconomics", "Gym" };

        //    monday = new Day("Monday", PeriodsMonday);
        //    Day Tuesday = new Day("Tuesday", PeriodsMonday);
        //    Day Wednesday = new Day("Wednesday", PeriodsMonday);
        //    Day Thursday = new Day("Thursday", PeriodsMonday);
        //    Day Friday = new Day("Friday", PeriodsMonday);
        //    Weekdays.Add(monday);
        //    Weekdays.Add(Tuesday);
        //    Weekdays.Add(Wednesday);
        //    Weekdays.Add(Thursday);
        //    Weekdays.Add(Friday);
        //    Weekdays.ToArray();

        //    Console.WriteLine(Weekdays[1]);
        //    foreach(Day da in Weekdays)
        //    {
        //        Console.WriteLine($"Hello Today is {Weekdays[1]}");
        //    }
        //    return Weekdays;

        //}
    }
}
