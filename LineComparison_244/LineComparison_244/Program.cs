using System;

namespace LineComparison_244
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program");

            //L1_LengthCal.Length();
            //Console.ReadLine();

             //L2_Equality2Lines.Equal();
             //Console.ReadLine();

            //L3_EqualGreaterLess.Greater();
            //Console.ReadLine();

            //L4_LineLength
            //First Line Point
            Console.WriteLine("Enter the value of X1");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y1");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of X2");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            //Second Line Point
            Console.WriteLine("Enter the value of X3");
            double x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y3");
            double y3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of X4");
            double x4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of Y4");
            double y4 = Convert.ToDouble(Console.ReadLine());



            L4_LineLength linelength = new L4_LineLength();
            double firstLineLength = linelength.GetLineLength(x1, y1, x2, y2);
            double secondLineLength = linelength.GetLineLength(x3, y3, x4, y4);
            Console.WriteLine($"{firstLineLength}    {secondLineLength}");

            if (firstLineLength.Equals(secondLineLength))
            {
                Console.WriteLine("The line length are equal");
            }
            else if (firstLineLength.CompareTo(secondLineLength) > 0)
            {
                Console.WriteLine("First line is greater than Second line");
            }
            else
            {
                Console.WriteLine("Second line is greater than First Line");
            }

        }
    
    }
}
