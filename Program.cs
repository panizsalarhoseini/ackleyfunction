using System;

namespace HillClimbingAckley
{
    class Program
    {
        
        static double Ackley(double x, double y)
        {
            double a = 20;
            double b = 0.2;
            double c = 2 * Math.PI;
            double term1 = -a * Math.Exp(-b * Math.Sqrt((x * x + y * y) / 2));
            double term2 = -Math.Exp((Math.Cos(c * x) + Math.Cos(c * y)) / 2);
            return term1 + term2 + a + Math.Exp(1);
        }

        
        static void HillClimbing()
        {
            double x = 5; 
            double y = 5; 
            double stepSize = 0.1; 

            while (true)
            {
                double currentValue = Ackley(x, y);
                double nextX = x + stepSize;
                double nextY = y + stepSize;
                double nextValue = Ackley(nextX, nextY);

                if (nextValue < currentValue)
                {
                    x = nextX;
                    y = nextY;
                }
                else
                {
                    stepSize *= 0.9; 
                }

                if (stepSize < 1e-6) 
                    break;
            }

            Console.WriteLine($"نقطه global minimum: x = {x}, y = {y}");
        }

        static void Main(string[] args)
        {
            HillClimbing();
        }
    }
}

