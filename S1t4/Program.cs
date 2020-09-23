using System;

namespace S1t4
{
    class Program
    {
        static double Gipotenusa(string catet1, string catet2)
        {
            double ct1, ct2;
            double.TryParse(catet1, out ct1);
            double.TryParse(catet2, out ct2);
            return Math.Pow(Math.Pow(ct1, 2) + Math.Pow(ct2, 2), 0.5);
 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну первого катета, а затем второго");
            Console.WriteLine(Gipotenusa(Console.ReadLine(), Console.ReadLine()));
        }
    }
}
