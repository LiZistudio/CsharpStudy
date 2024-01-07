using System;

namespace FunctionMethod{
    class Program{
        static int Main()
        {
            Console.WriteLine("MethodAndFunction");
            Console.WriteLine(MyMethod.Add(6.66,8.88));
            return 0;
        }
    }

    class MyMethod
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
    }
}