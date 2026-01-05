using Tyuiu.PyrkinAA.Sprint3.Task3.V6.Lib;
namespace Tyuiu.PyrkinAA.Sprint3.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string value = "12able 1o s4gh";
            char item = '*';

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine("Символ для замены цифр: " + item);

            string res = ds.ReplaceNumOnChar(value, item);

            Console.WriteLine("Результат: " + res);
            Console.ReadKey();
        }
    }
}
