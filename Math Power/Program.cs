using System;


namespace _6.Math_Power
{
    public class Program
    {
        public static void Main()
        {
            double baseNumber = double.Parse(Console.ReadLine());
            double Power = double.Parse(Console.ReadLine());
            double area = Pow(baseNumber, Power);
            Console.WriteLine(area);
        }
        public static double Pow(double baseNumber, double Power)
        {
            double result = 1;
            for (int i = 1; i <= Power; i++)
            {
                result *= baseNumber;
            }
            return result;
            {

            }
        }
    }
}
