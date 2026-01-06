using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.PyrkinAA.Sprint3.Task7.V6.Lib
{
    public class DataService : ISprint3Task7V6
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 4 * x - 0.5;
                double y;

                if (Math.Abs(denominator) < 1e-12)
                {
                    y = 0;
                }
                else
                {
                    y = (3 * Math.Cos(x)) / denominator + Math.Sin(x) - 5 * x - 2;
                }


                y = Math.Round(y, 2);
                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}