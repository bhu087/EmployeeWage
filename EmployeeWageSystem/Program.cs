using System;

namespace EmployeeWageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int attendence = 0;
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
            attendence = random.Next(0,1);
        }
    }
}
