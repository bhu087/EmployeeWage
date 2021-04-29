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
            const int WORKING_DAYS_PER_MONTH = 20;
            const int IS_ATTEND = 0;
            const int MONTHLY_HOUR = 100;
            int dailyWage, attendence, empHour, monthlyWage = 0, workHours = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
            for (int i = 0; i < WORKING_DAYS_PER_MONTH; i++)
            {
                if (workHours < MONTHLY_HOUR)
                {
                    attendence = random.Next(0, 3);
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
                            Console.WriteLine("Employee is absent");
                            empHour = 0;
                            break;
                    }
                    dailyWage = WAGE_PER_HOUR * empHour;
                    workHours += empHour;
                    monthlyWage += dailyWage;
                }
            }
            Console.WriteLine(workHours);
            Console.WriteLine(monthlyWage);
        }
    }
}
