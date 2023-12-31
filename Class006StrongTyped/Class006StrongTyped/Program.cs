using System;
using System.Numerics;

namespace StrongTyped
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            long y = 100L;
            //x = 100L;

            bool b = true;
            bool c = false;
            //b = 100;

            if (200 == x) {
                Console.WriteLine("it's OK");
            }
        }
    }
}