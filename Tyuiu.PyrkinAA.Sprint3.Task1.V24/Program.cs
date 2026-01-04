using Tyuiu.PyrkinAA.Sprint3.Task1.V24.Lib;
namespace Tyuiu.PyrkinAA.Sprint3.Task1.V24;

    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ВЫЧИСЛЕНИЕ СУММЫ РЯДА С ИСПОЛЬЗОВАНИЕМ ЦИКЛА WHILE                     *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("\nФормула: S = Σ[(2 / (6 + x^i))^i], где i от 1 до 12");
        Console.WriteLine("x = 5");

        DataService ds = new DataService();

        int x = 5;
        int startValue = 1;
        int stopValue = 12;

        double result = ds.GetSumSeries(x, startValue, stopValue);

        Console.WriteLine("\n***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine($"Сумма ряда для x = {x}, i от {startValue} до {stopValue}:");
        Console.WriteLine($"S = {result:F6}");

        Console.WriteLine("\nПервые 5 слагаемых:");
        Console.WriteLine("i\t(2/(6+x^i))\tСлагаемое");
        Console.WriteLine("--------------------------------------------");

        for (int i = 1; i <= 5; i++)
        {
            double powerValue = Math.Pow(x, i);
            double fraction = 2.0 / (6 + powerValue);
            double term = Math.Pow(fraction, i);

            Console.WriteLine($"{i}\t{fraction:F6}\t{term:F6}");
        }

        Console.WriteLine("\nВычисление с использованием цикла while:");
        double sum = 0;
        int index = startValue;
        while (index <= stopValue)
        {
            double term = Math.Pow(2.0 / (6 + Math.Pow(x, index)), index);
            sum += term;
            index++;
        }
        sum = Math.Round(sum, 3);
        Console.WriteLine($"Проверка: S = {sum:F6}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}

