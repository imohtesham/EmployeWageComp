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
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            const int EMP_PER_HOUR = 20;
            const int NUM_OF_WORKINGDAYS = 20;

            int empHRS = 0;
            int empWage = 0;
            int totalwage = 0;

            Random random = new Random();
            int day = 1;
            for (day = 1; day <= NUM_OF_WORKINGDAYS; day++)
            {
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case FULL_TIME:
                        Console.WriteLine("full time employe is present");
                        empHRS = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("part time employe is absent ");
                        empHRS = 4;
                        break;

                    default:
                        Console.WriteLine("employe is absent");
                        empHRS = 0;
                        break;

                }

                empWage = empHRS * EMP_PER_HOUR;
                Console.WriteLine("Employe wage for (0)is (1)", day, empWage);
                totalwage += empWage;
                day++;

            }


            

            Console.WriteLine("Total Employee wage (0) for (1) day and workingHrs:{3}",totalwage ,day -1,EMP_PER_HOUR,totalwage);
            Console.ReadLine();
    }
}
