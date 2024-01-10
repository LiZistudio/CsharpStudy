using System;

namespace ConversionExample
{
    class Program
    {
        static int Main()
        {
            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //var x = Convert.ToInt32(str1);
            //var y = Convert.ToInt32(str2);
            //Console.WriteLine(x+y);
            Console.WriteLine("===================");
            Teacher t = new Teacher();
            Human h = t;        //由子类向父类的隐式类型转换
            Animal a = h;
            a.Eat();
            //强制类型转换Cast
            Console.WriteLine(ushort.MaxValue);
            uint x = 65536;
            ushort y = (ushort)x;
            Console.WriteLine(y);
            Console.WriteLine("========================");
            String str = "123";
            var res = Convert.ToInt32(str);
            Console.WriteLine(res);
            var MyVar = 123;
            var str2 = MyVar.ToString();
            return 0;
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    class Human:Animal
    {
        public void Think()
        {
            Console.WriteLine("Who I am?");
        }
    }

    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("I teach programming");
        }
    }
}