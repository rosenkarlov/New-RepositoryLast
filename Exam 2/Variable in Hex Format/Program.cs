using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            // Convert it back to a number.
            try
            {
                int number = Convert.ToInt32(value, 16);
                Console.WriteLine("{0}",number.ToString());
            }
            catch (OverflowException)
            {
                Console.WriteLine("Unable to convert '0x{0}' to an integer.", value);
            }
        }
    }
}
