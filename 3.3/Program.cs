using System;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.3, 2-й вариант, Гребенюк
            Console.WriteLine("Введите значение x (в радианах): ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите колчество повторений цикла n: ");
            int n = int.Parse(Console.ReadLine());
            double S = 0;
            for (int i = 1; i <= n; i++)
            {
                S =+ Math.Cos(i * x) / i;
            }
            Console.WriteLine("Summ = " + S);
        }
    }
}
