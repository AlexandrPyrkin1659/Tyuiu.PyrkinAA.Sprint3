using Tyuiu.PyrkinAA.Sprint3.Task6.V7.Lib;
namespace Tyuiu.PyrkinAA.Sprint3.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = 17;
            int stopValue = 26;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Cумма делителей = " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadKey();
        }
    }
}