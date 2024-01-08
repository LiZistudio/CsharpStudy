using System;
using System.ComponentModel;

/*
 * 本节内容
 *  构造器（一种特殊的方法）（构造函数）
 *  方法的重载（Overload）
 *  如何对方法进行debug
 *  方法的调用与栈*
 */


namespace CSharpMethod
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("======分割线=======");
            Student XiaoMing = new Student(666,"XiaoMing");
            Console.WriteLine("姓名:{0};学号:{1}",XiaoMing.GetName(),XiaoMing.GetID());
            Console.WriteLine("======分割线========");
            Student LiHua = new Student();
            Console.WriteLine("姓名:{0};学号:{1}",LiHua.GetName(),LiHua.GetID());
            Console.WriteLine("======分割线========");
            Console.WriteLine(Calculator.Add(1,2));
            Console.WriteLine(Calculator.Add(1.0, 2.0));

            return 0;
        }
    }
    class Student
    {
        //构造函数(构造器)
        public Student(int initID,string initName) { 
            this.ID = initID;
            this.Name = initName;
        }
        public Student()
        {
            this.ID = 0;
            this.Name = "NoName";
        }
        public String GetName()
        {
            return this.Name;
        }
        public int GetID()
        {
            return this.ID;
        }

        private int ID;
        private string Name;

    }

    class Calculator()
    {
        //Overload
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(ref int a ,ref int b)
        {
            return a + b;
        }

        public static double Add(double a ,double b)
        {
            return a + b;
        }
    }
}   