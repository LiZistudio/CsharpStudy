/*泛型委托*/

using System;

namespace GenericExample3004 {

    public delegate TResult AddToStringL<in T1,in T2,out TResult> (T1 num1,T2 num2);
    class Program {
        static void Main(string[] args) {
            Action<string> action = new Action<string>(System.Console.WriteLine);
            //action.Invoke("hello");
            action("hello");
            Func<int, int, int> func = new Func<int, int, int>(Add);
            //Console.WriteLine(func.Invoke(1,2));
            Console.WriteLine(func(1,2));
            Func<double, double, double> func1 = new Func<double, double, double>(Add);
            Console.WriteLine(func1(1.1,2.2));

            AddToStringL<int,int,string> addtostring = new AddToStringL<int, int, string>(AddToString);
            Console.WriteLine(addtostring(1,2));
            Console.WriteLine((addtostring.Invoke(1, 2)) is string);
            Func<string,string,string> func2 = (/*double*/str1,/*double*/str2) => { return str1 + str2; };  //泛型委托与lamda表达式
            Console.WriteLine(func2.Invoke("Hi!", "Authur"));
        }

        static int Add(int a, int b) {
            return a + b;
        }
        static double Add(double a, double b) {
            return (double)a + b;
        }
        static string AddToString(int a, int b) {
            int res = a + b;
            string result = Convert.ToString(res);
            return result;
        }
    }
}