/*委托的高级使用
    *多播（multicast）委托
    *隐式异步调用
        *同步与异步的简介
            *中英文的语言差异
            *同步：你做完了我（在你的基础上）接着做
            *异步：咱们两个同时做（相当于汉语中的“同步进行”）
        *同步调用与异步调用的对比
            *每一个运行的程序是一个进程（process）
            *每个进程可以有一个或多个线程（thread）
            *同步调用是在同一线程内
            *异步调用的底层机理是多线程
            *串行==同步==单线程，并行==异步==多线程
        *隐式多线程V.S.显式多线程
            *直接同步调用：使用方法名
            *间接同步调用使用单播/多播委托的Invoke方法
            *隐式异步调用：使用委托的BeginInvoke
            *显示异步调用：使用Thread或Task
    *应该适时地使用接口（interface）取代一些对委托的使用
        *Java完全地使用接口取代了委托的功能，即Java没有与C#中委托相对应的功能实体
*/


using System;
using System.Threading;

namespace DelegateUseHigh{
    class Program{
        static void Main(string[] args){
            Student stu1 = new Student(){ID = 1, PenColor = ConsoleColor.Red};
            Student stu2 = new Student(){ID = 2, PenColor = ConsoleColor.Yellow};
            Student stu3 = new Student(){ID = 3, PenColor = ConsoleColor.Blue};
            
            // stu1.DoHomework();
            // stu2.DoHomework();
            // stu3.DoHomework();      //直接同步调用

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.ForegroundColor = ConsoleColor.Cyan;
            //     System.Console.WriteLine("Main thread {0}.",i);
            //     Thread.Sleep(100);
            // }                       //直接同步调用


            // Action act1 = new Action(stu1.DoHomework);
            // Action act2 = new Action(stu2.DoHomework);
            // Action act3 = new Action(stu3.DoHomework);      //间接同步调用

            // // act1.BeginInvoke(null,null);
            // // act2.BeginInvoke(null,null);
            // // act3.BeginInvoke(null,null);        //隐式异步调用的BeginInvoke（）方法已不被支持

            // // act1();
            // // act2();
            // // act3();              //单播委托

            // act1 += act2;
            // act1 += act3;
            // act1.Invoke();         //多播委托   //间接同步调用

            /*显式异步调用*/
            // Thread thread1 = new Thread(new ThreadStart(stu1.DoHomework));
            // Thread thread2 = new Thread(new ThreadStart(stu1.DoHomework));
            // Thread thread3 = new Thread(new ThreadStart(stu1.DoHomework));

            // thread1.Start();
            // thread2.Start();
            // thread3.Start();

            Task task1 = new Task(new Action(stu1.DoHomework));
            Task task2 = new Task(new Action(stu2.DoHomework));
            Task task3 = new Task(new Action(stu3.DoHomework));
            task1.Start();
            task2.Start();
            task3.Start();
        }
    }

    class Student{
        public int ID {get;set;}
        public ConsoleColor PenColor {get;set;}  

        public void DoHomework(){
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                System.Console.WriteLine("Student {0} diong homework {1} hour(s).",this.ID,i);
                Thread.Sleep(1000);
            }
        }
    }
}