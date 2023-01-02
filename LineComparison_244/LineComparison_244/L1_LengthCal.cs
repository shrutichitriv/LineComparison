using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison_244
{
    class L1_LengthCal
    {
        public static void Length()
        {
            //Accepting Values For Line 1
            Console.Write("Enter Value X1:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value Y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value X2:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value Y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double ans = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //Calculating For Line 1
            Console.WriteLine("Ans Is:" + ans);


            //Accepting Values For Line 2
            Console.Write("Enter Value C1:");
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value D1:");
            int d1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value C2:");
            int c2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value D2:");
            int d2 = Convert.ToInt32(Console.ReadLine());

            double ans2 = Math.Sqrt(Math.Pow((c2 - c1), 2) + Math.Pow((d2 - d1), 2));  //Calculating For Line 2
            Console.WriteLine("Ans Is:" + ans2);


            Console.WriteLine("**********Length Of Line Are**********");
            Console.WriteLine("Length Of Line1=" + ans);
            Console.WriteLine("Length Of Line2=" + ans2);

            //Comparing Both Lines

            //  if (ans > ans2)
            // {
            // Console.WriteLine("Line 1st Is Greater Than Line 2nd");
            // }
            //  else if (ans < ans2)
            // {
            //    Console.WriteLine("Line 2nd Is Greater Than Line 1st");
            // }
            // else
            // {
            //     Console.WriteLine("Both Lines Are Equal");
            // }

        }
    }
}
