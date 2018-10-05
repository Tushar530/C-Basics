using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] student = new string[,]
            {
                {"Tushar soni", "Narendra modi" ,"Ram Sharma" }

        };

            for (int i = 0; i < student.GetLength(0); i++)
            {
                for (int j = 0; j < student.GetLength(1); j++)
                {
                    Console.WriteLine(student[i, j]);

                }
            }
        }
    }
}

