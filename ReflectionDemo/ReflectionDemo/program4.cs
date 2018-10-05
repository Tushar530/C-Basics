using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Calculator
    {
        [Obsolete("This method is no longer support use AddNumbers instead", true)]

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int AddNumbers(params int[] arr)
        {
            int sum = 0;
            foreach (int x in arr)
            {
                sum += x;
            }

            return sum;
        }
    }

    class program4
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            //This is method is no use , we can use AddNumber method instead of this 
           // calculator.Add(10,20);
            calculator.AddNumbers(10, 20);
        }
    }
}
