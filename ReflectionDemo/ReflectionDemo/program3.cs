using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Calculation
    {
        private int firstNumber;

        public int FirstNumber
        {
            get { return firstNumber; }
            set { firstNumber = value; }
        }
        private int secondNumber;

        public int SecondNumber
        {
            get { return secondNumber; }
            set { secondNumber = value; }
        }

        public int AddTwoNumbers()
        {
            return FirstNumber + SecondNumber;
        }
    }



    class program3
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            foreach (Type type in assembly.GetTypes())
            {
                if (type.Name == "Calculation")
                {
                    //Creating instance of Calculation Class
                    object obj =
                        assembly.CreateInstance("ReflectionDemo.Calculation");

                    //Setting Property Values
                    PropertyInfo[] property = type.GetProperties();
                    property[0].SetValue(obj, 10);
                    property[1].SetValue(obj, 9);

                    //Invoking Method
                    MethodInfo method = type.GetMethod("AddTwoNumbers");
                    int result = (int)method.Invoke(obj, null);
                    Console.WriteLine("Sum = " + result);
                }
            }

        }
    }
}

