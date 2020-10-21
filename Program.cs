using System;

namespace LineComaparision
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Declared variables for getting end points of line 
            ///By calling the  respective method
            double temp1 = GetEndPointsOfX();
            double temp2 = GetEndPointsOfY();
            ///Storing the result of distance between the points in
            ///result1 variables by calling the DistanceBtwnPoints method
            double result1 = DistanceBtwnPoints(temp1, temp2);
            Console.WriteLine("Distance between two points: " + result1);
            double temp3 = GetEndPointsOfX();
            double temp4 = GetEndPointsOfY();
            double result2 = DistanceBtwnPoints(temp3, temp4);
            Console.WriteLine("Distance between two points: " + result2);
            ///Comparing the distances of two lines
            ///the result gives 0 if both are equal and -1 if first one is less than second
            ///+1 if first one is greater than second one 
            int compare = result1.CompareTo(result2);

            if (compare == 0)
            {
                Console.WriteLine("Lines are equal");
            }
            else if (compare == -1)
            {
                Console.WriteLine("First line is less than second line");
            }
            else
            {
                Console.WriteLine("First line is greater than second line");
            }

        }
        /// <summary>
        /// Gets the end points of line for x coordinates and returns power of difference.
        /// between the points
        /// </summary>
        /// <returns></returns>
        public static double GetEndPointsOfX()
        {
            Console.WriteLine("Enter x1,x2");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var x2 = Convert.ToDouble(Console.ReadLine());

            return Math.Pow((x2 - x1), 2);
        }
        /// <summary>
        /// Gets the end points of line y coordinates and returns power of difference
        /// between the points
        /// </summary>
        /// <returns></returns>
        public static double GetEndPointsOfY()
        {
            Console.WriteLine("Enter y1,y2");
            var y1 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());

            return Math.Pow((y2 - y1), 2);
        }
        /// <summary>
        /// Distance the Between points by using the temp values
        /// </summary>
        /// <param name="temp1">The temp1.</param>
        /// <param name="temp2">The temp2.</param>
        /// <returns></returns>
        public static double DistanceBtwnPoints(double temp1, double temp2)
        {
            return Math.Sqrt(temp1 + temp2);
        }

    }
}



