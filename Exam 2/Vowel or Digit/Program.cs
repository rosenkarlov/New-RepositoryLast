using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char number = char.Parse(Console.ReadLine().ToLower());
            if (number == 'a' || number == 'e' || number == 'i' || number == 'o' || number == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (number == '1' || number == '2' || number == '3' || number == '4' || number == '5' ||
               number == '6' || number == '7' || number == '8' || number == '9' || number == '0')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
            
              
        }
    }
}
