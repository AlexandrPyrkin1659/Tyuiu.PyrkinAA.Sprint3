using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PyrkinAA.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;
            while (i <= stopValue)
            {
                // x^i
                double powerValue = Math.Pow(value, i);

                double denominator = 6 + powerValue;

                double fraction = 2.0 / denominator;

                double term = Math.Pow(fraction, i);

                sum += term;

                i++;
            }

            return Math.Round(sum, 3); 
        }
    }
}