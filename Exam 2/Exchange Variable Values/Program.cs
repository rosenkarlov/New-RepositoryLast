using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 5;
            var number2 = 10;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",number1);
            Console.WriteLine("b = {0}", number2);
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", number2);
            Console.WriteLine("b = {0}", number1);
        }
    }
}
