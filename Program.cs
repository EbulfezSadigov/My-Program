using System;

namespace Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateArea(1,2,3));
        }
        static int CalculateArea(int r)
        {
            int sum=1, p = 3;
            sum = p * r;
            return sum;
        }
        static int CalculateArea(int a, int b)
        {
            int sum = 1;
            sum = sum * (a * b);
            return sum;
        }
        static int CalculateArea(int a, int b, int c)
        {
            int sum = 1;
            sum = sum * 2 * (a * b + b * c + a * c);
            return sum;
        }
    }
}
