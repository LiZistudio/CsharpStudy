
//具名参数；     可选参数；       扩展方法（this参数）;

using System;

namespace NameParametric
{
    class Program
    {
        //----------------------------------具名参数------------------------------------------
        //static void Main(string[] args)
        //{
        //    //Program.PrintInfo("lihua", 23);
        //    Program.PrintInfo(age: 23, name: "lihua");      //这就是具名参数（具名调用），易读，不受参数顺序约束。
        //}

        //static void PrintInfo(string name,int age)
        //{
        //    Console.WriteLine("Hello {0},you are {1}",name,age);
        //}

        //--------------------------------可选参数--------------------------------------------

        //static void Main(string[] args)
        //{
        //    PrintInfo();        //调用时可选参数可以不用输入实参，此时为形参默认值
        //}

        //static void PrintInfo (string name = "NULL",int age = 26)   //声明时赋予参数默认值就变成了可选参数
        //{
        //    Console.WriteLine("Hello {0},you are {1}",name,age);
        //}

        //------------------------------扩展方法（this参数）------------------------------------

        //方法必须是公有、静态的，即public static
        //必须是由一个静态类（一般类名为SomeTypeExtension）来统一收纳对SomeType类型的扩展方法
        //例：LINQ方法

        static void Main(string[] args)
        {
            double p = 3.14159;
            //double x = Math.Round(p,4);
            //Console.WriteLine(x);         //double方法无Round方法（精确到小数点后几位），想到可以用扩展方法为double类型实现此方法。

            //double res = double.Round(p, 4);
            double res = p.Round(4);
            Console.WriteLine(res);
        }
        
    }

    static class DoubleExtension {
        public static double Round(this double input ,int digits)
        {
            double result = Math.Round(input, digits);
            return result;
        }
    }
}