using System;
using System.Collections.Generic;

namespace CSExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of points:");
            int numberOfPoints = int.Parse(Console.ReadLine());

            double[,] points = GetPointsFromUser(numberOfPoints);

            double sumX, sumY, sumX2, sumXY;
            sumX = 0; sumX2 = 0; sumXY = 0; sumY = 0;
            for (int i = 0; i < numberOfPoints; i++)
            {
                sumX += points[i, 0];
                sumY += points[i, 1];
                sumXY += points[i, 0] * points[i, 1];
                sumX2 += points[i, 0] * points[i, 0];
            }

            double n = points.Length;
            double m = (sumXY - sumX * sumY / n) / (sumX2 - sumX * sumX / n);
            double xAverage = sumX / n;
            double yAverage = sumY / n;
            double b = yAverage - m * xAverage;

            Console.WriteLine($"y = {m:F3} x + {b:F3}");
        }

        static double[,] GetPointsFromUser(int numOfPoints)
        {
            Console.WriteLine("Enter coordinates x and y of point:");
            var points = new double[numOfPoints, 2];

            for (int i = 0; i < numOfPoints; i++)
            {
                string input = Console.ReadLine();
                string[] inputsDivided = input.Split(',');
                points[i, 0] = double.Parse(inputsDivided[0]);
                points[i, 1] = double.Parse(inputsDivided[1]);

            }

            return points;
        }
    }
}
