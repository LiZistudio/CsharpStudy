//声明委托
//注意，委托也是一种类，需要声明在名称空间里


using System;
using System.Net.Http.Headers;

namespace DelegateExample02
{
    public delegate double Calc(double x,double y);     //自定义委托类型的声明
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Calc calc1 = new Calc(calculator.Add);
            Calc calc2 = new Calc(calculator.Sub);
            Calc calc3 = new Calc(calculator.Mul);
            Calc calc4 = new Calc(calculator.Div);
            Console.WriteLine(calc1(2,3));
            Console.WriteLine(calc2(2,3));
            Console.WriteLine(calc3(2,3));
            Console.WriteLine(calc4.Invoke(2,3));      //委托类型的调用可以使用如：calc.invoke();或者仿照函数指针调用如：calc();
            //Calculator calculator = new Calculator();
            //Func<double, double, double> func = new Func<double, double, double> (calculator.Add);
            ////func.Invoke(2, 3);
            //Console.WriteLine(func(2.0, 3.0));

        }
    }

    class Calculator
    {
        public double Add (double x,double y)
        {
            double result = x + y;
            return result; 
        }
        public double Sub(double x, double y)
        {
            double result = x - y;
            return result;
        }
        public double Mul (double x, double y)
        {
            double result = x * y;
            return result;
        }
        public double Div(double x, double y)
        {
            double result = x / y;
            return result;
        }
    }
}