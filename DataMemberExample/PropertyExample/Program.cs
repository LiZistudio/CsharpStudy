//属性；   索引器；    常量；

using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            try
            {
                stu1.Age = 30;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //索引器
            stu1["Math"] = 90;
            var mathScore = stu1["Math"];
            Console.WriteLine(mathScore==null);
            Console.WriteLine(mathScore);

            //常量
            Console.WriteLine(WASPEC.WebsiteURL);
        }
    }

    class Student
    {
        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 20 && value <= 120)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("参数有误");
                }
            }
        }

        private static int amount;
        public static int Amount
        {
            get {return  amount;}
            set
            {
                if(value >= 0 && value <= 100)
                {
                    Student.amount = value;
                }
                else
                {
                    throw new Exception("Error");
                }
            }
        }

        public string Name { get; set; }


        //索引器
        private Dictionary<string,int> scoreDictionary = new Dictionary<string,int>();
        public int? this[string subject]
        {
            get 
            { 
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    return this.scoreDictionary[subject];
                }
                else
                {
                    return null;
                }
            }
            set 
            {
                if (value.HasValue == false)
                {
                    throw new Exception("Score cannot be null.");
                }
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    this.scoreDictionary[subject] = value.Value;
                }
                else
                {
                    this.scoreDictionary.Add(subject, value.Value);
                }
            }
        }
    }

    class WASPEC
    {
        public const string WebsiteURL = "http://www.waspec.org";
    }
}