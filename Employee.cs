using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Employee 
    {
       
        public static void EmpComputation()
        {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Wage_Per_Hour=20;
            int FullDayHour = 8;
            int DailyEmpWage;
            Random R = new Random();
            int empCheck = R.Next(3);
            if(empCheck==Is_Full_Time)
            {
                Console.WriteLine("Employee is present.");
                 FullDayHour = 8;
                 DailyEmpWage = Wage_Per_Hour * FullDayHour;
                Console.WriteLine("Daily employee wage is :- " + DailyEmpWage);
            }
            else if(empCheck==Is_Part_Time)
            {
                Console.WriteLine("Employee present PartTime.");
                int PartTimeHour = 4;
                 DailyEmpWage = Wage_Per_Hour * PartTimeHour;
                Console.WriteLine("Daily employee wage of Part time  is :- " + DailyEmpWage);
            }
            else
            {
                Console.WriteLine("Employee is absent.");
                FullDayHour = 0;
                 DailyEmpWage = Wage_Per_Hour * FullDayHour;
                Console.WriteLine("Daily employee wage is :- " + DailyEmpWage);
            }
        }
    }
}
