/*
 * 操作符
 */
using System;

namespace CSharpOperator
{
    class Program
    {
        static int Main()
        {
            Persion persion1 = new Persion("XiaoMing");
            Persion persion2 = new Persion("XiaoHong");

            //List<Persion> nation = Persion.GetMarry(persion1,persion2);
            List<Persion> nation = persion1+persion2;

            foreach (Persion p in nation)
            {
                Console.WriteLine(p.Name);
            }

            /*
             * 一些操作符
             */
            //System.IO.File.Create("D:\\Users\\11853\\Desktop\\CSharpOperator.txt");
            var student = new { num = 1, Name = "LiMing" };
            Console.WriteLine(student.Name);
            return 0;
        }
    }

    class Persion
    {
        public string Name;

        public Persion() { Name = "null"; }
        public Persion (string initName)
        {
            if (!string.IsNullOrEmpty(initName))
            {
                this.Name = initName;
            }
            else
            {
                throw new ArgumentException("initName cannot be null or empty");
            }
        }

        //CSharp中的操作符就是函数的简记法
        //public static List<Persion> GetMarry(Persion p1,Persion p2)
        public static List<Persion> operator + (Persion p1,Persion p2)
        {
            List<Persion> people = new List<Persion>();
            people.Add(p1);
            people.Add(p2);
            for(int i = 0;i<11;i++)
            {
                Persion child = new Persion();
                child.Name = p1.Name + "&" + p2.Name + "'s child";
                people.Add(child);
            }
            return people;
        }
    }
}