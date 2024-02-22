/*Partial类*/
/*枚举类型和结构体*/
//枚举：
    //* 人为限定取值范围的整数；
    //* 整数值的对应；
    //* 比特位式用法；
//结构体：
    //* 值类型（可装箱、拆箱）
    //* 可实现接口，不能派生自类/结构体
    //* 不能有显式无参构造器

using System;

namespace PartialClassExample3001 {
    class Program {
        static void Main(string[] args) {
            Persion persion = new Persion();
            persion.Level = Level.Employee;
            Persion boss = new Persion();
            boss.Level = Level.Boss;
            Console.WriteLine(persion.Level<boss.Level);
            Console.WriteLine((int)Level.Manager);
            Console.WriteLine((int)Level.Boss);
            Console.WriteLine((int)Level.BigBoss);

            persion.Name = "Authur";
            persion.Skill = Skill.Drive | Skill.Cook | Skill.Teach | Skill.Program; //enum的比特位（按位或）用法
            Console.WriteLine(persion.Skill);
            Console.WriteLine(persion.Skill&Skill.Cook);

            Student student = new Student() { ID = 10, Name = "Authur", age = 30 };
            object obj = student;   //装箱
            Student student2 = (Student) obj;   //拆箱
            Console.WriteLine($"#{student2.ID}.Name:{student2.Name}.");

            student.Speak();
        }
    }

    interface ISpeak {
        void Speak();
    }

    class Persion {
        public int ID { get; set; }
        public string Name { get; set; }
        public Level Level { get; set; }
        public Skill Skill { get; set; }
    }

    enum Level {
        Employee,
        Manager,
        Boss,
        BigBoss,
    }
    enum Skill {
        Drive = 1,
        Cook = 2,
        Program = 4,
        Teach = 8,
    }

    struct Student : ISpeak {
        public Student(int id,string name) {  //C#中struct不允许有显式的无参构造器，但允许有显式的有参构造器。
            ID = id;
            Name = name;
        }
        public int ID { get; set; }
        public int age {  get; set; }
        public string Name { get; set; }

        public void Speak() {
            Console.WriteLine($"I'm #{this.ID} student {this.Name}.");
        }
    }
}