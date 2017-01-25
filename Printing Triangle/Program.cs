using System;


namespace _03.Printing_Triangle
{
    public class Program
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            PrintTriangle(number);
        }
        public static void PrintCol(int row)
        {
            for (int column = 1; column <= row; column++)
            {
                Console.Write($"{column} ");
            }
            Console.WriteLine();
        }
        public static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {

                PrintCol(row);
            }
            for (int row = n - 1; row >= 1; row--)
            {
                PrintCol(row);
            }
        }
    }
}