using System;

namespace EmployeeWageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int WAGE_PER_HOUR = 20;
            const int FULL_DAY_HOUR = 8;
            const int PART_TIME_HOUR = 4;
            const int IS_ATTEND = 0;
            int dailyWage = 0, attendence = 0, empHour = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
            attendence = random.Next(0,1);
            switch (attendence)
            {
                case IS_ATTEND:
                    Console.WriteLine("Employee is present");
                    empHour = FULL_DAY_HOUR;
                    break;
                case 1:
                    Console.WriteLine("Part time employee is Present");
                    empHour = PART_TIME_HOUR;
                    break;
                default:
                    empHour = 0;
                    break;
            }
            dailyWage = WAGE_PER_HOUR * empHour;
        }
    }
}
