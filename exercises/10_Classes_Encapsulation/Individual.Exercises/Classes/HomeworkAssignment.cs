using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
        
        public int TotalMarks { get; set; }
        public int PossibleMarks { get; }
        public string SubmitterName { get; }
      
       
        
        public string LetterGrade {

            get
            {
                double Grade = (double)TotalMarks / PossibleMarks;
                if(Grade >= 0.90)
                {
                    return "A";
                }
                else if (Grade >= 0.80 && Grade <= 0.89)
                {
                    return "B";
                }
                else if (Grade >= 0.70 && Grade <= 0.79)
                {
                    return "C";
                }
                else if (Grade >= 0.60 && Grade <= 0.69)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }

            }


        }
      


        // Create a constructor 
        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
             PossibleMarks = possibleMarks;
;            SubmitterName = submitterName;


        }



        //  Methods 

    }
}
