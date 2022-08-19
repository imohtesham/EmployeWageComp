using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComp
{
    public class Program
    {
        public const int PART_TIME = 1;
        public const int FULL_TIME = 2;
        public const int PER_HOUR_RATE = 20;
        public const int NUM_OF_WORKING_DAY = 20;

        static void Main(string[] args)
        {
            int EMPHR = 0;
            int empwge = 0;
            int totalempwage = 0;

            for (int day = 0; day <NUM_OF_WORKING_DAY; day++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);

                switch (empcheck)
                {
                    case PART_TIME:
                        EMPHR = 4;
                        break;
                    case FULL_TIME:
                        EMPHR = 8;
                        break;
                    default:
                        EMPHR = 0;
                        break;
                }
                empwge = EMPHR * PER_HOUR_RATE;
                totalempwage += empwge;
                Console.WriteLine("emp wage :" + empwge);
            }
            Console.WriteLine("totalempwage :" + totalempwage);
            
        }
           
    }
}
