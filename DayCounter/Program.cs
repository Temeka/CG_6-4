using System;

namespace DayCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day Counter!");

            
            Console.WriteLine("Please enter any date (i.e mm/dd/yyy): ");
            string FirstDate = Console.ReadLine();

            //parsing the input to the string
            DateTime DateOne = DateTime.Parse(FirstDate);

            Console.WriteLine("Please enter your second date:");
            string SecDate = Console.ReadLine();

            DateTime DateTwo = DateTime.Parse(SecDate);

            //declaring the time span
            TimeSpan Count = DateOne - DateTwo;

            //prompting the compiler to print result. Works whether adding or subtracting dates.
            Console.WriteLine("There were " + Count.TotalDays + "days between the dates");

            Console.ReadLine();
        }
    }
}
