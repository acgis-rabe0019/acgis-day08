using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarsAndExp
{
    class Program
    {
        /// <summary>
        /// This program will convert DMS into Degrees, while taking the bearing (N,E,S,W) into consideration.
        /// </summary>
        /// <param name="deg">DEGREES</param>
        /// <param name="min">MINUTES</param>
        /// <param name="sec">SECONDS</param>
        /// <param name="bearing"> BEARING is a string that contains the quadrant of the dms coordinate (i.e. N,S,E,W)</param>
        /// <returns></returns>
        /// 

        static void Main(string[] args)
        {
            int deg = 45;
            int min = 20;
            double sec = 5.6;
            string bearing = "N";
            double dd = Dms2Dd(deg, min, sec, bearing);
            double expected = 45.4255;
            Console.WriteLine("Expected: {0} Actual: {1}", expected, dd);

            deg = 50;
            min = 30;
            sec = 4;
            bearing = "E";
            dd = Dms2Dd(deg, min, sec, bearing);
            expected = -60.5;
            Console.WriteLine("Expected: {0} Actual: {1}", expected, dd);

            deg = 60;
            min = 30;
            sec = 4.5;
            bearing = "S";
            dd = Dms2Dd(deg, min, sec, bearing);
            expected = 60.5;
            Console.WriteLine("Expected: {0} Actual: {1}", expected, dd);

            deg = 60;
            min = 1;
            sec = 1;
            bearing = "W";
            dd = Dms2Dd(deg, min, sec, bearing);
            expected = 60.5;
            Console.WriteLine("Expected: {0} Actual: {1}", expected, dd);
            Console.ReadKey();
        }
        /// <summary>
        /// This program will convert DMS into Degrees, while taking the bearing (N,E,S,W) into consideration.
        /// </summary>
        /// <param name="deg">DEGREES</param>
        /// <param name="min">MINUTES</param>
        /// <param name="sec">SECONDS</param>
        /// <param name="bearing"> BEARING is a string that contains the quadrant of the dms coordinate (i.e. N,S,E,W)</param>
        /// <returns></returns>
        /// 
        static double Dms2Dd(int deg, int min, double sec, string bearing) ///function
        {
            int swithValue;

            bool positive; ///Business Rule #1 The first three parameters must be positive numbers
            positive = (deg > 0 && min > 0 && sec > 0);

            if (positive == false)
            {
                return 9999;
            }
            switch (bearing.ToUpper()) ///
            {
                case "N":
                case "S":
                    if (deg > 90) { return 9999; }
                    break;
                case "E":
                case "W":
                    if (deg > 180) { return 9999; }
                    break;

                default: return 9999;
            }
            return (deg + ((min + (sec / 60)) / 60)) * switchValue; /// conversion on equation
        }
    }
}
