using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PyrkinAA.Sprint3.Task4.V1.Lib
{
    public class DataService : ISprint3Task4V1
    {
        public double Calculate(int startValue, int stopValue)
        {
            double sum = 0.0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    sum += 1; 
                }
                else
                {
                    sum += Math.Sin(x) / x;
                }
            }
            return sum;
        }
    }
}