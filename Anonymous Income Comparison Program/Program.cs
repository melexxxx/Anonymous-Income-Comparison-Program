using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print Title
            Console.WriteLine("Anonymous Income Comparison Program");

            //Get Person 1 details
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate: ");
                double hourlyRatePerson1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            double hoursPerWeekPerson1 = Convert.ToDouble(Console.ReadLine());

            double annualPerson1 = hourlyRatePerson1 * hoursPerWeekPerson1 * 52;

            //Get Person 1 details
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate: ");
                double hourlyRatePerson2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            double hoursPerWeekPerson2 = Convert.ToDouble(Console.ReadLine());

            double annualPerson2 = hourlyRatePerson2 * hoursPerWeekPerson2 * 52;

            Console.WriteLine($"annual Salary of Person 1 : {annualPerson1}");
            Console.WriteLine($"annual Salary of Person 2 : {annualPerson2}");

            string comparison = (annualPerson1 > annualPerson2).ToString();

            Console.WriteLine($"Person1 makes more money tha Person 2 \n {comparison}");
            Console.ReadLine();
        }
    }
}
