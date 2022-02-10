using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation
{
    public class EmpWageComputation
    {
        const int IS_PRESENT = 1;
        Random generateNum = new Random();

        public void IsEmployeePresent()
        {
            int check = generateNum.Next(0, 2);
            if (check == IS_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
