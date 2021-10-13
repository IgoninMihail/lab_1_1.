using System;

namespace lab_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a, y, J, x;
                Console.WriteLine("Введите a:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите y:");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите x:");
                x = double.Parse(Console.ReadLine());
                J = (Math.Pow(Math.Cos(Math.Pow(a, 3)) / Math.Sin(Math.Pow(a, 3)), 3) + Math.Pow(Math.Atan(a), 2)) / (Math.Sqrt(Math.Pow(y, Math.Log(x))));
                Console.WriteLine("J=", +J);
                Console.WriteLine(string.Format("J={0:F2}", J));
            }
            catch (Exception e)
            {
                Console.WriteLine("Введите корректно переменную");
            }


        }
    }
}
