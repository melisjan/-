using System;

namespace S1T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите код символа(от 32 до 127): ");
            int a;
            int.TryParse(Console.ReadLine(), out a);
            
            Console.WriteLine((char)a);
            
        }
    }
}
