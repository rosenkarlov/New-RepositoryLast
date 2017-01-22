using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());

            var perimeter = 2 * width + 2 * heigh;
            var area = width * heigh;
            var diagonal = Math.Sqrt(width * width + heigh * heigh);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);
        }
    }
}
