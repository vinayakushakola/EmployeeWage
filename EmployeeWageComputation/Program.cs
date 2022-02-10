using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Welcome To Employee Wage Computation ===========");

            EmpWageComputation emp = new EmpWageComputation();
            emp.IsEmployeePresent();
        }
    }
}
