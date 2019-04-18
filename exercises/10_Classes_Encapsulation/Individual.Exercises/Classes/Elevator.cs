using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
       public int CurrentLevel { get; private set; }
       public int NumberOfLevels { get; }
       public bool DoorIsOpen { get; private set; }

        // Constructor 
        public Elevator(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
            CurrentLevel = 1;
        }

        // Methods 
        public void OpenDoor()
        {
            DoorIsOpen = true;
               
        }

        public void CloseDoor()
        {
            DoorIsOpen = false;
        }

        public void GoUp(int desiredFloor)
        {
            if (!DoorIsOpen && desiredFloor > CurrentLevel)
                CurrentLevel = desiredFloor;
            else
                CurrentLevel = CurrentLevel;
        }

        public void GoDown(int desiredFloor)
        {
            if(!DoorIsOpen && desiredFloor < CurrentLevel)
            CurrentLevel = desiredFloor;
            else
                CurrentLevel = CurrentLevel;
        }





    }


}
