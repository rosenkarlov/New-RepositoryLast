using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float timeInSeconds = hours * 3600f + minutes * 60f + seconds;
            float Milles = 1609f;
            float speedInMettersPerSecond =(float)distanceInMeters / timeInSeconds;
            float speedInKilometersPerHour =(float)speedInMettersPerSecond*3.6f;
            float speednInMilesPerHour= (float)(speedInMettersPerSecond/1.609f)*3.6f;
            
            Console.WriteLine("{0}", speedInMettersPerSecond);
            Console.WriteLine("{0}", speedInKilometersPerHour);
           Console.WriteLine("{0}", speednInMilesPerHour);
        }
    }
}
