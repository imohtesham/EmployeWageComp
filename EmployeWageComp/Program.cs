using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employePresent = 5;

            Random random = new Random();

            int empCheck = random.Next(0, 6);


            if (employePresent == empCheck)

                Console.WriteLine("Employe is present");


            else
                Console.WriteLine("Employe is absent");

            Console.ReadLine();

        }
    }
}
