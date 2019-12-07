using System;

namespace exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double num1 = double.Parse(Console.ReadLine());
            double z = num1 % 2;
            if (z != 0)
            {
                Console.WriteLine("Число не являеться простым");
            }
            else
            {
                Console.WriteLine("Число простое");
            }
        }
    }
}
