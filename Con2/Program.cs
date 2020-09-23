using System;

namespace Con2
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = Console.ReadLine();
            int w;
            bool r = int.TryParse(a, out w);

            string a = Console.ReadLine();
            int s;
            bool d = int.TryParse(a, out s);

            if (!r || d) 
            {
                Console.WriteLine("Incorrect input");
            }
            Console.WriteLine(w - s);
        }
    }
}
