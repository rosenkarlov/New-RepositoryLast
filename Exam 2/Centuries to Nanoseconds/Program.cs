using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal centuries = decimal.Parse(Console.ReadLine());
            decimal years = centuries * 100m;
            decimal days=Math.Floor(years*365.2422m);
            decimal hours = days * 24m;
            decimal minutes = hours * 60m;
            decimal seconds = minutes * 60m;
            decimal milliseconds = (decimal)seconds * 1000m;
            decimal microseconds = milliseconds * 1000m;
            decimal nanoseconds = microseconds * 1000m;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",
                centuries,years,days,hours,minutes,seconds,milliseconds,microseconds,nanoseconds);

        }
    }
}
