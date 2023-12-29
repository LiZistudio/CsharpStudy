using System;

namespace Class04
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("******类、对象和类的成员******");

            int maxnum = Math.Max(3, 6);
            double resnum = Math.Tan(double.Pi/4);
            Console.WriteLine(maxnum);
            Console.WriteLine(resnum);
            double x = Math.Sqrt(9);
            Console.WriteLine(x);
            return 0;
        }
    }
}