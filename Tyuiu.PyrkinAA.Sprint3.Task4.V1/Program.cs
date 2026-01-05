using Tyuiu.PyrkinAA.Sprint3.Task4.V1.Lib;
namespace Tyuiu.PyrkinAA.Sprint3.Task4.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double result = ds.Calculate(startValue, stopValue);

            Console.WriteLine("Сумма значений функции sin(x)/x от {0} до {1} = {2}", startValue, stopValue, result);
            Console.ReadKey();
        }
    }
}