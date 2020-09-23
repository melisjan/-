using System;

namespace S3T2
{
    class Program
    {
        static int ReversedNumber(int a)
        {

            string se = string.Empty;

            while (a != 0)
            {
                se += (a % 10).ToString();
                a /= 10;
            }

            return int.Parse(se);
        }
        static void Main(string[] args)
        {
            int numValue;
            try
            {
                do
                {
                    Console.Write("Напишите любое число: ");
                    string inputValue = Console.ReadLine();

                    if (!int.TryParse(inputValue, out numValue) || numValue < 0)
                    {
                        Console.WriteLine("Неккоректные данные!");
                    }
                    else
                    {
                        Console.WriteLine(ReversedNumber(numValue));
                    }

                    Console.WriteLine("Нажмите на ESC чтобы выйти..");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
    