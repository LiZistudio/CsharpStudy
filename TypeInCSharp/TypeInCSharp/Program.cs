using System;
using System.Reflection.Emit;

namespace TypeInCSharp {
    class Program
    {
        static int Main(string[] args)
        {
            Type myType = typeof(Type);
            Console.WriteLine(myType.FullName);
            Console.WriteLine(myType.IsClass);

            var myVar = 100L;
            Console.WriteLine(myVar.GetType().Name);
            var myVar2 = 100;
            Console.WriteLine(myVar2.GetType().Name);
            long myVar3 = 100;
            Console.WriteLine(myVar3.GetType().Name);
            int myVar4 = 100;
            //myVar4 = "myvar";
            Console.WriteLine(myVar4.GetType().Name);

            dynamic myVar5 = 100;
            myVar5 = "myvar";
            Console.WriteLine(myVar5);

            short myVar6 = 100;
            Console.WriteLine(myVar6);

            student.Amount = 0;
            student Stu1 = new student();
            Stu1.SetAge(25);
            Console.WriteLine(Stu1.GetAge());

            return 0;
        }
    }

    class student {
        public static int Amount;
        private short Age;
        public string Name;

        public int GetAge()
        {
            return Age;
        }
        public void SetAge(short age)
        {
            if (age>=1 && age<=100)
            {
                Age = age;
            }
            else
            {
                Console.WriteLine("设置有误，请重新设置");
            }
        }

    }
}