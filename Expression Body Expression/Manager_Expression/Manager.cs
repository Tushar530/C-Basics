using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Expression
{
    /// <summary>
    /// Author: Tushar Soni
    /// DOC : 12th September
    /// Showing Expression Bodied Function
    ///
    /// </summary>

    public class Manager
    {
        public Manager(int ManagerID, string sName)
        {
            Manager_ID = ManagerID;
            Name = sName;
        }

        private int Manager_ID;
        private string Name;

        public override string ToString() => $"{Manager_ID} {Name}".Trim();
        public void DisplayName() => Console.WriteLine(ToString());
    }

    class Example
    {
        static void Main()
        {
            Manager p = new Manager(1001, "Suresh");
         
            p.DisplayName();
        }
    }
}




