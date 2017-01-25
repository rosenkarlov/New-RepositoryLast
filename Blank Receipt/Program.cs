namespace Blanck
{
    using System;
    public class Program
    {

        public static void Main()
        {
            PrintBlanck();
        }

        public static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        public static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }
        public static void PrintBlanck()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
    }
}
