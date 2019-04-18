using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        // properites 
        public string PlaneNumber { get; }
        public int BookedFirstClassSeats { get; private set; }
      
        public int TotalFirstClassSeats { get; }
        public int BookedCoachSeats { get; private set; }
        
        public int TotalCoachSeats { get; }

        // Derrived Propperty 

        public int AvailableFirstClassSeats
        {
            get
            {
                return TotalFirstClassSeats - BookedFirstClassSeats;


            }
        }
        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
             

            }
        }

        // Constructor to set the initial state of each object
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }

        // Reseve Seats method:

       public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {

           

            if (forFirstClass)
            {
                if(totalNumberOfSeats < AvailableFirstClassSeats)
                {
                    BookedFirstClassSeats += totalNumberOfSeats;
                    return true;
                }
                return false;
            }else
            {
                if (totalNumberOfSeats < AvailableCoachSeats)
                {
                    BookedCoachSeats += totalNumberOfSeats;
                    return true;
                }
            }return false;
                

        }
    }
}