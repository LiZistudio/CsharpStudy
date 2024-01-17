//委托详解（delegate）
//一切皆地址
//直接调用与间接调用
//委托的简单使用
//  Action委托
//  Func委托

using System;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Action action = new Action(calculator.Report);
            action.Invoke();
            action();                   //间接调用
            calculator.Report();        //直接调用

            Func<int,int,int> func1 = new Func<int,int,int> (calculator.Add);
            Func<int,int,int> func2 = new Func<int,int,int> (calculator.Sub);

            Console.WriteLine(func1(2,3));
            Console.WriteLine(func2(2,3));
        }
    }

    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods.");
        }

        public int Add(int x,int y)
        {
            int result = x + y;
            return result;
        }
        public int Sub(int x, int y)
        {
            int result = x - y;
            return result;
        }
        
    }
}