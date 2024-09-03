using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter employee id");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter employee name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your job");
            string job = Console.ReadLine();

            Console.WriteLine("employee salary");
            int sal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("employee id is {0}", id);
            Console.WriteLine("employee id is {0}", name);
            Console.WriteLine("employee job is  {0}", job);
            Console.WriteLine("employee job is  {0}", sal);


            Console.ReadLine();

        }
    }
}
