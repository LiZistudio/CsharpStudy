using System;

namespace ClassExample
{
    class Program{
        static void Main(string[] args){
            // Student student = new Student("Authur",01);
            // student.Report();
            Type t = typeof(Student);
            object o = Activator.CreateInstance(t,"Author",01);
            //System.Console.WriteLine(o.GetType().Name);
            //Student stu = (Student)o;
            Student stu = o as Student;
            System.Console.WriteLine(stu.Name);

            System.Console.WriteLine(Student.Amount);
        }
    }

    class Student {
        public static int Amount {get;set;}
        static Student() {
            Amount = 100;
        }
        public Student(string name,int id) {
            this.Name = name;
            this.ID = id;
        }
        // ~Student() {
        //     System.Console.WriteLine("Free");
        // }

        public string Name { get; set; }
        public int ID { get; set; }
        public void Report(){
            System.Console.WriteLine($"I'm #{this.ID} student,my name is {this.Name}.");
        }
    }
}