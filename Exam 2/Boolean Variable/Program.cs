using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            bool trueOrFalse = bool.Parse(str);
            if (str=="True")
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            } 

            

        }
    }
}
