using System;

namespace DayCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day(s) Counter!");

            
            Console.WriteLine("Please enter any date (ex: mm/dd/yyyy): ");
            string FirstDate = Console.ReadLine();

            //parsing the input to the string
            DateTime DateOne = DateTime.Parse(FirstDate);

            Console.WriteLine("Enter your second date: ");
            string SecDate = Console.ReadLine();

            DateTime DateTwo = DateTime.Parse(SecDate);

            //declaring the time span
            TimeSpan Count = DateOne - DateTwo;

            //prompting the compiler to print result. Works whether adding or subtracting dates.
            Console.WriteLine("Number of day(s) between the dates entered: " + Count.TotalDays);

            Console.ReadLine();
        }
    }
}
