using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConce
{
    internal class SwitchEm
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int empRatePerHour;
        private int numOfWorkingDays;
        
        public SwitchEm(int empRatePerHour, int numOfWorkingDays )
        {
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
        }

        public  void EmpSwitch()
        {
            int empHrs = 0, empWage = 0, totalEmpWage = 0;
            for (int day = 0; day < numOfWorkingDays; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(2);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;


                }
                empWage = empHrs * empRatePerHour;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage :" + empWage);
            }
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);

        }
    }
}

    

