using System;

namespace LineComaparision
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp1 = GetEndPointsOfX();
            double temp2 = GetEndPointsOfY();
            double result1 = DistanceBtwnPoints(temp1, temp2);
            Console.WriteLine("Distance between two points: " + result1);
            double temp3 = GetEndPointsOfX();
            double temp4 = GetEndPointsOfY();
            double result2 = DistanceBtwnPoints(temp3, temp4);
            Console.WriteLine("Distance between two points: " + result2);
            bool checkLines = result1.Equals(result2);
            if ( checkLines == true)
            {
                Console.WriteLine("Both lines are equal");
            }
            else
            {
                Console.WriteLine("lines are not equal");
            }

        }

        public static double GetEndPointsOfX()
        {
            Console.WriteLine("Enter x1,x2");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var x2 = Convert.ToDouble(Console.ReadLine());

            return Math.Pow((x2 - x1), 2); 
        }

        public static double GetEndPointsOfY()
        {
            Console.WriteLine("Enter y1,y2");
            var y1 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());

            return Math.Pow((y2 - y1), 2); 
        }
        
        public static double DistanceBtwnPoints(double temp1, double temp2)
        {
            return Math.Sqrt(temp1 + temp2);
        }

    }
}



