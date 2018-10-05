using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"D:\M1\IEmployee\IEmployee\bin\Debug\IEmplpoyee.dll");

            Type[] types = assembly.GetTypes();

            foreach(Type type in types)
            {
                Console.WriteLine(type.Name + "--" +type.FullName + "--"+ type.BaseType);
            }
        }
    }

}