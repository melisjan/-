using System;

namespace S2T3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a1;
            double.TryParse(Console.ReadLine(), out a1);
            
            double a2 = a1 * a1;
            
            double a3 = a1 * a2;
            double a4 = a2 * a2;
            
            double a5 = a3 * a2;
            double a6 = a3 * a3;
            double a8 = a4 * a4;
            
            double a7 = a3 * a4;
            double a9 = a6 * a3;
            double a10 = a4 * a2 * a4;
            double a16 = a8 * a8;
            double a12 = a8 * a4;
            
            double a14 = a7 * a7;
            double a13 = a12 * a1;
            double a15 = a10 * a5;
            double a32 = a16 * a16;
            
            double a64 = a32 * a32;
            double a21 = a7 * a7 * a7;
            double a28 = a14 * a14;
        }
    }
}
