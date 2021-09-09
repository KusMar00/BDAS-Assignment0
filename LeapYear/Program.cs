using System;

namespace LeapYear
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            //Console.WriteLine("Welcome to the leap year tester! \nWrite a year:");
            var input = Console.ReadLine();
            try
            {
                int year = Int32.Parse(input);
                bool result = p.IsLeapYear(year);
                if (result)
                {
                    Console.WriteLine("yay");
                } else
                {
                    Console.WriteLine("nay");
                }
            } catch (FormatException)
            {
                Console.WriteLine("Please write an integer");
            } catch (InvalidYearException)
            {
                Console.WriteLine("I only accept years after 1581");
            }

        }

        public bool IsLeapYear(int year)
        {
            if (year < 1582) {
                throw new InvalidYearException();
            }
            if (year%4==0)
            {
                if (year%100==0 && year%400!=0) return false;
                else return true;
            } 
            return false;
        }
    }

    public class InvalidYearException : System.Exception
    {
        public InvalidYearException(){

        }
    }
}
