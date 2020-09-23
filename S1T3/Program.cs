using System;

namespace S1T3
{
    class Program
    {
       
            static double Vvod(string name)
            {
                
                Console.WriteLine($"Введите значение {name}: ");
                double rtn;
                double.TryParse(Console.ReadLine(), out rtn);
                return rtn;
            }

            static void Main(string[] args)
            {
                
                double U, R;
                Console.WriteLine("Введите значение U: ");
                double.TryParse(Console.ReadLine(), out U);
                Console.WriteLine("Введите значение R: ");
                double.TryParse(Console.ReadLine(), out R);
                
                Console.WriteLine("Значение напряжения P: {0}", Math.Pow(U, 2) / R);


               
                U = Vvod("U");
                R = Vvod("R");
                Console.WriteLine("Значение напряжения P: {0}", Math.Pow(U, 2) / R);
               
                Console.WriteLine("Введите значение U и R: ");
                string[] value = Console.ReadLine().Split();
                
                double.TryParse(value[0], out U);
                double.TryParse(value[1], out R);
                Console.WriteLine("Значение напряжения P: {0}", Math.Pow(U, 2) / R);
                
            }
        }
    }
