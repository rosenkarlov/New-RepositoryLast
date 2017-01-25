
namespace _2.Sign_of_Integer_Number
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }
        public static void PrintSign(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("The number 0 is zero.");
            }
            else if (n < 0)
            {
                Console.WriteLine("The number {0} is negative.", n);
            }
            else
            {
                Console.WriteLine("The number {0} is positive.", n);
            }
        }
    }
}
