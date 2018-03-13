using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarsAndExp
{
    class Program
    {
        public static void Main(string[] args)
        {
            double dd = Dms2Dd(45, 55, 38, "N");
            double expected = 40.927;
            Console.WriteLine("Expect: {0} Actual: {1}", expected, dd);

            double dd = Dms2Dd(124, 08, 10, "W");
            double expected = -124.136;
            Console.WriteLine("Expected: {0} Actual: {1}", expected, dd);

            double dd = Dms2Dd(40, 51, 08, "N");
            double expected = 40.852;
            Console.WriteLine("Expected: {0} Actual: {1}", expected, dd);
        }

        /// <summary>
        /// This function will convert degrees, minutes, seconds into degrees.
        /// </summary>
        /// <param name="deg">degrees</param>
        /// <param name="min">minutes</param>
        /// <param name="sec">seconds</param>
        /// <param name="bearing"> The qaudrant of the DMS coordinate (i.e. N,S,E,W)</param>
        /// 

        public static double Dms2Dd(int deg, int min, int sec, string bearing)
        {
            int deg = Convert.ToInt32(Console.ReadLine());
            if (deg <= 180) {
                Console.WriteLine("")
            } else {
                return 9999;
            }
        }

    }
}
