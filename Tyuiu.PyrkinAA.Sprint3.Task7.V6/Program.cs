using Tyuiu.PyrkinAA.Sprint3.Task7.V6.Lib; 
using System;

namespace Tyuiu.PyrkinAA.Sprint3.Task7.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*******************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:            *");
            Console.WriteLine("*******************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            double[] valueArray = ds.GetMassFunction(startValue, stopValue);
            int len = valueArray.Length;

            Console.WriteLine("*******************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                  *");
            Console.WriteLine("*******************************");

            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("|     x     |   F(x)    |");
            Console.WriteLine("+-----------+-----------+");

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                Console.WriteLine("| {0,5}     | {1,9:F2} |", x, valueArray[i]);
            }

            Console.WriteLine("+-----------+-----------+");
            Console.ReadKey();
        }
    }
}