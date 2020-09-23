using System;

namespace S3T1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                do
                {
                    int a = 1;
                    while (a * (a + 1) % 222 != 0)
                    {
                        a++;

                        while (a * (a + 1) % 222 != 0)
                        {
                            a++;
                            int d = (a * (a + 1)) / 2;

                            Console.WriteLine($"Ответ: {d}");
                        }
                        Console.WriteLine($"Сложение натурального числа: {a}");
                    }

                    Console.WriteLine("Нажмите на ESC чтобы выйти");

                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Причина ошибки {ex.Message}");
            }
        }
    }
}
