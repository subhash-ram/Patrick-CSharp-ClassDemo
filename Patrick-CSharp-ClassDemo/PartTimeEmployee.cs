using System;

namespace Patrick_CSharp_ClassDemo
{
    public class PartTimeEmployee : Employee
    {
        public override void VacationDays(int grade)
        {
            Console.WriteLine(grade > 5 ? "5 days vacation" : "2 days vacation");
        }
    }
}