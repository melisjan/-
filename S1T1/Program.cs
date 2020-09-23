using System;

namespace S1T1
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();
            const string b = "*";
            for (var i = 0; i < a.Length; i++)
            {
                Console.Write(b);
            }

        }
    }
}
