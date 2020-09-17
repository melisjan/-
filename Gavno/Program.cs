using System;
using System.Linq;

namespace Gavno
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Введите число");
            if (!double.TryParse(Console.ReadLine(), out a) || a < 999 || a > 9999)
            {
                Console.WriteLine("error");

            }
            else 
            {
                Console.WriteLine(a.ToString().Reverse().ToArray());
            }
            Console.ReadLine();
        }
    }
}
