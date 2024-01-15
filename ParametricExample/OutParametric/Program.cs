
//输出参数

using System;

namespace OutParametric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please input first number:");
            //string arg1 = Console.ReadLine();
            //double x = 0;
            //bool bl1 = double.TryParse(arg1, out x);
            //if (bl1 == false)
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}

            //Console.WriteLine("Please input second number:");
            //string arg2 = Console.ReadLine();
            //double y = 0;
            //bool bl2 = double.TryParse(arg2, out y);
            //if (bl2 == false)
            //{
            //    Console.WriteLine("Error");
            //    return;
            //}

            //Console.WriteLine("{0}+{1}={2}",x,y,x+y);

            //---------------值类型输出参数--------------------------------------
            //double x = 0;
            //string str = Console.ReadLine();
            //bool bl = DoubleParser.TryParse(str, out x);
            //if (bl == true)
            //{
            //    Console.WriteLine(x);
            //}
            //===============引用类型输出参数======================================
            Student stu1 = new Student();
            bool bl = StudentFactory.Create("LiHua", 26, out stu1);
            if (bl == false)
            {
                Console.WriteLine("Panic!");
            }
            Console.WriteLine("{0},{1}",stu1.Age,stu1.Name);
        }
    }

    //值类型输出参数
    class DoubleParser
    {
        public static bool TryParse(string input, out double result)
        {
            try
            {
                result = Convert.ToDouble(input);
                return true;
            }
            catch
            {
                Console.WriteLine("Panic! Error!");
                result = 0;
                return false;
            }
        }
    }

    class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    class StudentFactory
    {
        public static bool Create(string stuName,int stuAge,out Student student)
        {
            if (stuName != null&&(stuAge>=20&&stuAge<=80))
            {
                student = new Student();
                student.Name = stuName;
                student.Age = stuAge;
                return true;
            }
            else
            {
                student = null;
                return false;
            }
        }
    }
}