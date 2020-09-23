using System;

namespace S2T2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите температуру в градусах цельсия: ");
            double celsia;
            double.TryParse(Console.ReadLine(), out celsia);
            Console.WriteLine("Температура по шкале Ранкина: {0}", (celsia + 273.15) * 9 / 5);
            Console.WriteLine("Температура по шкале Демиля: {0}", (100 - celsia) * 3 / 2);
            Console.WriteLine("Температура по шкале Ньютона: {0}", celsia * 33 / 100);
            Console.WriteLine("Температура по шкале Реомюра: {0}", celsia * 4 / 5);
            Console.WriteLine("Температура по шкале Рёмера: {0}", celsia * 21 / 40 + 7, 5);
        }
    }
}
