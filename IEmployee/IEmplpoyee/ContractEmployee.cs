using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    public class ContractEmployee: IEmployee
    {
        
        int Id;
        string Name;
        double HourlyWages;
        double NoOfHourWorked;

        public void SetDetails(int Id, String Name, double HourlyWages, double NoOfHourWorked)
        {
            this.Id = Id;
            this.Name = Name;
            this.HourlyWages = HourlyWages;
            this.NoOfHourWorked = NoOfHourWorked;

        }

        public double CalculateSalary()
        {
            return HourlyWages * NoOfHourWorked;
        }

        public void GetDetails()
        {
            Console.WriteLine(" ....Employee details.....");
            Console.WriteLine("Id:" + this.Id);
            Console.WriteLine("Name:" + this.Name);
            Console.WriteLine("HourlyWages :" + this.HourlyWages);
            Console.WriteLine("No OF Hours Worked :" + this.NoOfHourWorked);
            Console.WriteLine("Salary :" + CalculateSalary());
        }

        
    }
}
