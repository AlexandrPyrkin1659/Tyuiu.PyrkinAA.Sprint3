using Tyuiu.PyrkinAA.Sprint3.Task0.V7.Lib;
namespace Tyuiu.PyrkinAA.Sprint3.Task0.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВЫЧИСЛЕНИЕ СУММЫ РЯДА                                                   *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("\nФормула: S = Σ[(a^k + 1) * cos(k)], где k от 1 до 20");
            Console.WriteLine("a = 0.75");

            DataService ds = new DataService();

            double a = 0.75;
            int startValue = 1;
            int stopValue = 20;

            double result = ds.GetSumSeries(a, startValue, stopValue);

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Сумма ряда для a = {a}, k от {startValue} до {stopValue}:");
            Console.WriteLine($"S = {result:F6}");
            Console.WriteLine("\nТаблица слагаемых (первые 10):");
            Console.WriteLine("k\t(a^k + 1)\tcos(k)\t\tСлагаемое");
            Console.WriteLine("------------------------------------------------------------");

            for (int k = 1; k <= 10; k++)
            {
                double term = Math.Pow(a, k) + 1;
                double cosValue = Math.Cos(k);
                double member = term * cosValue;

                Console.WriteLine($"{k}\t{term:F6}\t{cosValue:F6}\t{member:F6}");
            }

            Console.WriteLine($"\nСумма первых 10 слагаемых: {GetPartialSum(a, 1, 10):F6}");
            Console.WriteLine($"Полная сумма (20 слагаемых): {result:F6}");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        static double GetPartialSum(double a, int start, int end)
        {
            double sum = 0;
            for (int k = start; k <= end; k++)
            {
                sum += (Math.Pow(a, k) + 1) * Math.Cos(k);
            }
            return Math.Round(sum, 6);
        }
    }
}