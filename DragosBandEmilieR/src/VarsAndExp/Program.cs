using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarsAndExp
{
    class Program
    {
        static void Main(string[] args)
        {
            double dd = Dms2Dd(60, 30, 0, "N");
            double expected = 1;
            Console.WriteLine("Expected: {0} Actual: {1}", expected, actual);
        }
        /// <summary>
        /// This program will convert DMS into Degrees, while taking the bearing (N,E,S,W) into consideration.
        /// </summary>
        /// <param name="deg">DEGREES</param>
        /// <param name="min">MINUTES</param>
        /// <param name="sec">SECONDS</param>
        /// <param name="bearing"> BEARING is a string that contains the quadrant of the dms coordinate (i.e. N,S,E,W)</param>
        /// <returns></returns>
        static double Dms2Dd(int deg, int min, int sec, string bearing)
        {
        return 1;
        }
    }
}
