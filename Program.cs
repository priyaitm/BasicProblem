using System;

namespace PositiveNum
{
    internal class Program

    {
      static void Main(string[] args)

        {
            Console.WriteLine("Enter the Number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            BasicProb obj = new BasicProb();
           // obj.CheckNumber(n);
           // obj.CheckEvenOdd(n);
            obj.CheckLeapYear(n);

            Console.ReadLine();
         }
    }
}
