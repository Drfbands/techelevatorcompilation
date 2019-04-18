using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
       public bool IsOn { get; private set; }
       public int CurrentChannel { get; private set; }
       public int CurrentVolume { get; private set; }


        // Constructor 
        public Television()
        {
            CurrentChannel = 3;
            CurrentVolume = 2;
            IsOn = false;
        }

        // Methods:
        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
        }
        public void ChangeChannel(int newChannel)
        {
            if (IsOn)
            {
                CurrentChannel = newChannel;
            }
            else {
                CurrentChannel = CurrentChannel;
            }
        }

       public void ChannelUp()
        {
            if (IsOn)
            {
                if(CurrentChannel > 18)
                {
                    CurrentChannel = 3 ;
                }
                CurrentChannel += 1;
            }
            
        }

        public void ChannelDown()
        {
            if (IsOn)
            {
                CurrentChannel -= 1;
            }
        }

        public void RaiseVolume()
        {
            if (IsOn)
            {
                CurrentVolume += 1;
            }
        }

        public void LowerVolume()
        {
            if (IsOn)
            {
                if (CurrentVolume == 0)
                {
                    CurrentVolume = 0;
                } 

            }
            CurrentVolume -= 1;
        }
       




    }
}
