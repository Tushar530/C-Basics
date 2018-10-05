using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] ITparks = new string[3][];
            {
                ITparks[0] = new string[3] { "Sipcot", "Dlf", "mipl" };
                ITparks[1] = new string[4] { "merceds", "sonata", "google" ,"yahoo"};
                ITparks[2] = new string[1] { "insta" };
                for (int i = 0; i <ITparks.GetLength(0); i++)
                {
                    for (int j = 0; j < ITparks[i].GetLength(0); j++)
                    {
                        Console.Write(ITparks[i][j]+ "\t");
                    }
                    Console.WriteLine();
                    Console.ReadLine();
                }
                

            }
        }
    }
}
