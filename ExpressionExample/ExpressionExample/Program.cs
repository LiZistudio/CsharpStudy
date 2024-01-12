using System;
using System.Xml;

namespace Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 3 < 4;
            Console.WriteLine(x.GetType().Name);
            var y = default(Int32);
            Console.WriteLine(y);

            //Action action = () => Console.WriteLine("hello");     //lamda表达式 委托
            Action action = delegate () { Console.WriteLine("hello"); };//delegate 委托
            action();
        }
    }
}