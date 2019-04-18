using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Employee
    {
       public int EmployeeId { get;  }
       public string FirstName { get;  }
       public string LastName { get; set; }
       
       public string Department { get; set; }
       public double AnnualSalary { get;  private set; }
       
        // TODO Derived Property FullName 
        // Derrived property means that it is dependant upon other variables to initialize. 
        public string FullName
        {
            get
            {
                return $"{LastName}, {FirstName}";
              
            }
        }

        // TODO Constructor 
        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            AnnualSalary = salary;
        }








        // TODO Methods 

        public void RaiseSalary(double percent) { 
           double percentOfSalary = AnnualSalary * (percent / 100);
            AnnualSalary += percentOfSalary;
        }
   


        
    }
}
