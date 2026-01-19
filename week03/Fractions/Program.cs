using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
    }
    public class Fraction
    {
        private int[] _topNumber = {1, 5, 3, 1};
        public int[] topNumber
        {
            get { return _topNumber; }
        }

        private int[] _bottomNumber = {1, 1, 4, 3};
        public int[] bottomNumber
        {
            get { return _bottomNumber; }
        }
             
       
    }
    public class GetFraction
    {
        public static Func<double, double, double> GetFractionString()
        {
            Func<double, double, double> divide = (topNumber, bottomNumber) =>
            {
                if (bottomNumber == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                return topNumber / bottomNumber;
            };
            return divide;
        }
    }
}