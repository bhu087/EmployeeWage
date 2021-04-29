using System;

namespace EmployeeWageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int WAGE_PER_HOUR = 20;
            const int FULL_DAY_HOUR = 8;
            int dailyWage = 0;
            int attendence = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
            attendence = random.Next(0,1);
            dailyWage = WAGE_PER_HOUR * FULL_DAY_HOUR;
        }
    }
}
