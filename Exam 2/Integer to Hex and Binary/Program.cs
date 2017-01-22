using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        
            {
                long numberN = long.Parse(Console.ReadLine());

            Console.WriteLine("{0}", Convert.ToString(numberN, 16).ToUpper());
            Console.WriteLine("{0}", Convert.ToString(numberN, 2));
            
            }

        }
    }

