using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Select Employee Type");
            Console.WriteLine("1. Contract Employee");
            Console.WriteLine("2. Permanent Employee");
            int Choice = int.Parse(Console.ReadLine());
            switch (Choice)

            {
                case 1:
                    ContractEmployee ContractEmployee1 = new ContractEmployee();
                    Console.WriteLine("Enter Employee ID:");
                    int EmployeeId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Employee Name:");
                    String EmployeeName = Console.ReadLine();
                    Console.WriteLine("Enter hourly Wages : ");
                    double HourlyWages = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter No of hours worked");
                    double NoOfHoursWorked = double.Parse(Console.ReadLine());
                    ContractEmployee1.SetDetails(EmployeeId, EmployeeName, HourlyWages, NoOfHoursWorked);
                    ContractEmployee1.CalculateSalary();
                    ContractEmployee1.GetDetails();
                    break;

                case 2:
                    PermanentEmployee PermanentEmployee1 = new PermanentEmployee();
                    Console.WriteLine("Enter Employee ID:");
                    EmployeeId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Employee Name:");
                    EmployeeName = Console.ReadLine();
                    Console.WriteLine("Enter Basic Salary:");
                    double Basic_Salary = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Employee Hours WOrked:");
                    double Hra = double.Parse(Console.ReadLine());
                    PermanentEmployee1.SetDetails(EmployeeId, EmployeeName, Basic_Salary, Hra);
                    PermanentEmployee1.CalculateSalary();
                    PermanentEmployee1.GetDetails();
                    break;


            }

        }
    }
}
