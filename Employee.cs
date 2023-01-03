using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static int EmpComputation(string company,int Wage_Per_Hour, int Max_Days_IN_Month, int Max_HrsInMonth)
        {
            int empHour;
            int totalHours = 0;
            int totalDays = 0;
            Console.WriteLine(company);
            while (totalHours < Max_HrsInMonth && totalDays < Max_Days_IN_Month)
            {
                Random R = new Random();
                int empCheck = R.Next(3);
                totalDays++;
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        {
                            empHour = 8;
                            break;
                        }
                    case IS_PART_TIME:
                        {
                            empHour = 4;
                            break;
                        }
                    default:
                        {
                            empHour = 0;
                            break;
                        }
                }
                totalHours = (totalHours + empHour);
                
                Console.WriteLine("Day# : " + totalDays + " emp Hrs : " + empHour);
            }
                int sallery = totalHours * Wage_Per_Hour;
                Console.WriteLine("Total employee wage of {0} Hrs is :- {1}",totalHours , sallery);
                Console.WriteLine("\n");
            return sallery;
            

        }
    }
}
