using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permanent
{
   
        public class PermanentEmployee
        {

            int Id;
            string Name;
            double Basic_Salary;
            double Hra;


            public void SetDetails(int Id, string Name, double Basic_Salary, double Hra)
            {
                this.Id = Id;
                this.Name = Name;
                this.Basic_Salary = Basic_Salary;
                this.Hra = Hra;
            }

            public double CalculateSalary()
            {
                return Basic_Salary + Hra;
            }

            public void GetDetails()
            {
                Console.WriteLine("---------------------Employee Management System------------------");
                Console.WriteLine("Id: " + this.Id);
                Console.WriteLine("Name: " + this.Name);
                Console.WriteLine("Hourly Wage: " + this.Basic_Salary);
                Console.WriteLine("No of Days Worked: " + this.Hra);
                Console.WriteLine("Salary: " + CalculateSalary());
                Console.WriteLine("-----------------------------------------------------------------");
            }
        }
    }

