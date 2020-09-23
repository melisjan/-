using System;

namespace S2T1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int a;
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine((a / 100) % 10);
        }
    }
}
