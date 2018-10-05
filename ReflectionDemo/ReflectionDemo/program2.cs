using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class program2
    {
        static void Main(string[] args)
        {
            Type empType = typeof(Employee);

            MethodInfo[] methods = empType.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();

            ConstructorInfo[] constructors = empType.GetConstructors();
            foreach(ConstructorInfo m in constructors)
            {
                Console.WriteLine(m.Name);
            }


            //property info
        }
        class Employee
        {
            public int id;
            public string name;
            public float salary;

            public Employee() { }
            public Employee(int id, string name, float salary) { }

            public void SetEmployee() { }
            public void GetEmployee() { }

            public int TotalExperience { get; set; }
            public int CurrentExperience { get; set; }
        }

    }


}
