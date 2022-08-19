using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int PART_TIME = 1;
            int FULL_TIME = 1;
            int PER_HOUR_RATE = 20;

            int EMPHR = 0;
            int EMPWGE = 0;

            Random random = new Random();       
            int empcheck = random.Next(0,2);

            if(empcheck == PART_TIME)
            {
                EMPHR = 4;
            }
            else if (empcheck == FULL_TIME)
            {
                EMPHR = 8;
            }
            else
            {
                EMPHR = 0;
            }
            EMPWGE = EMPHR * PER_HOUR_RATE;
            Console.WriteLine("emp wage :" + EMPWGE);
        }
        
           
            


            

           
    }
}
