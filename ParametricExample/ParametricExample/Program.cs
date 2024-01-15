//值参数；      引用参数；   

using System;

namespace ParametricExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            int y = 10;
            int z = 10;
            stu1.AddOne(y);
            stu1.AddOne(ref z);
            Console.WriteLine("By Value:{0}",y);
            Console.WriteLine("By Ref:{0}",z);
            //===========================================
            Student stu2 = new Student() { Name = "Tim" };
            Student stu3 = new Student() { Name = "Tim" };

            Program.SomeMethod(stu2);
            Console.WriteLine(stu2.Name);
            Program.SomeMethod(ref stu3);
            Console.WriteLine(stu3.Name);
        }
        static void SomeMethod(Student stu)
        {
            stu = new Student() { Name = "Tom" };
            Console.WriteLine(stu.Name);
        }
        static void SomeMethod(ref Student stu)
        {
            stu = new Student() { Name = "Tom" };
            Console.WriteLine(stu.Name);
        }
    }

    class Student 
    {
        public string Name { get; set; }

        public void AddOne (int x)
        {
            x += 1;
            Console.WriteLine(x);
        }
        public void AddOne(ref int x)
        {
            x += 1;
            Console.WriteLine(x);
        }

    }
}   