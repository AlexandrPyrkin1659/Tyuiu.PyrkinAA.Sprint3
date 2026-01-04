using Tyuiu.PyrkinAA.Sprint3.Task2.V28.Lib;
namespace Tyuiu.PyrkinAA.Sprint3.Task2.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ВЫЧИСЛЕНИЕ ПРОИЗВЕДЕНИЯ РЯДА С ИСПОЛЬЗОВАНИЕМ ЦИКЛА DO...WHILE        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("\nФормула: P = Π[(2^k)/(k+1) * cos(1.8)], где k от 1 до 9");
            Console.WriteLine("cos(1.8) в радианах");

            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;

            double result = ds.GetMultiplySeries(startValue, stopValue);

            Console.WriteLine("\n***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Произведение ряда для k от {startValue} до {stopValue}:");
            Console.WriteLine($"P = {result:F6}");

            Console.WriteLine("\nПервые 5 множителей:");
            Console.WriteLine("k\t2^k\tk+1\t(2^k)/(k+1)\tМножитель");
            Console.WriteLine("----------------------------------------------------------------");

            double cosValue = Math.Cos(1.8);
            for (int k = 1; k <= 5; k++)
            {
                double numerator = Math.Pow(2, k);
                double denominator = k + 1;
                double fraction = numerator / denominator;
                double term = fraction * cosValue;

                Console.WriteLine($"{k}\t{numerator}\t{denominator}\t{fraction:F6}\t{term:F6}");
            }
            Console.WriteLine("\nВычисление с использованием цикла do...while:");
            double product = 1.0;
            int index = startValue;

            do
            {
                double term = (Math.Pow(2, index) / (index + 1)) * cosValue;
                product *= term;
                index++;
            }
            while (index <= stopValue);

            product = Math.Round(product, 3);
            Console.WriteLine($"Проверка: P = {product:F6}");

            Console.WriteLine($"\ncos(1.8) = {cosValue:F6}");
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}