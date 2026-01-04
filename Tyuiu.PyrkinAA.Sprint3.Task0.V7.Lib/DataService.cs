using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PyrkinAA.Sprint3.Task0.V7.Lib
{
    public class DataService : ISprint3Task0V7
    {
        public double GetSumSeries(double a, int startValue, int stopValue)
        {
            double sum = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = Math.Pow(a, k) + 1;
                double cosValue = Math.Cos(k); 
                double seriesMember = term * cosValue;

                sum += seriesMember;
            }

            return Math.Round(sum, 3); 
        }
    }
}
