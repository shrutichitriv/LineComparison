using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison_244
{
    internal class L2_Equality2Lines
    {
        public static void Equal()
        {
            //First Accept Length Of Two Line From User

            Console.Write("Enter Value C1:");
            int a1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value D1:");
            int b1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value C2:");
            int a2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value D2:");
            int b2 = Convert.ToInt32(Console.ReadLine());

            double ans1 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2)); //Calculate Length For Line1
            Console.WriteLine("Ans Is:" + ans1);


            Console.Write("Enter Value C1:");
            int c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value D1:");
            int d1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value C2:");
            int c2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Value D2:");
            int d2 = Convert.ToInt32(Console.ReadLine());

            double ans2 = Math.Sqrt(Math.Pow((c2 - c1), 2) + Math.Pow((d2 - d1), 2)); //Calaculate Length For Line2
            Console.WriteLine("Ans Is:" + ans2);

            if (ans1 == ans2)
            {

                Console.WriteLine("Both Lines Are Equal");
            }
            else
            {
                Console.WriteLine("Both Lines Are Not Equal");
            }
        }
    }
}
