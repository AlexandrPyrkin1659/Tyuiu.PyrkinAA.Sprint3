using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PyrkinAA.Sprint3.Task2.V28.Lib
{ 
    public class DataService : ISprint3Task2V28
{
    public double GetMultiplySeries(int startValue, int stopValue)
    {

        double cosValue = Math.Cos(1.8);

        double product = 1.0;

        int k = startValue;

        if (startValue <= stopValue)
        {
            do
            {
                double numerator = Math.Pow(2, k);

                double denominator = k + 1;

                double term = (numerator / denominator) * cosValue;

                product *= term;

                k++;
            }
            while (k <= stopValue);
        }

        return Math.Round(product, 3); 
    }
}
}
