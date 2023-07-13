using System;
using System.Collections.Generic;
using System.Text;


namespace PositiveNum
{
    internal  class BasicProb

    {
        public void CheckNumber(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("number is positive");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("number is negative");
            }
        }

        public void CheckEvenOdd(int n)
        {
            if(n % 2 == 0)
            {
                Console.WriteLine("Even Number");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }

        public void CheckLeapYear( int year)
        {
            if (((year % 400 == 0))  || ((year % 4 == 0) && (year % 100 != 0))){
                Console.WriteLine("year is Leap Year");
                Console.ReadLine();
            } else { Console.WriteLine("Year is not Leap Year"); }

        }




    }
}
