using System;

namespace Patrick_CSharp_ClassDemo
{
    public class Employee
    {
        public void CalculateTax(int salary)
        {
            Console.WriteLine(salary > 100000 ? "Tax is $1000" : "Tax is $100");
        }

        public virtual void VacationDays(int grade)
        {
            Console.Write(grade > 5 ? "10 days vacation" : "5 days vacation");
        }
    }
}