/*重写、多态*/
//类的继承
    //类成员的横向扩展（成员越来越多）
    //类成员的“纵向扩展”（行为改变，版本增高）
    //类成员的隐藏（不常用）
    //重写与隐藏发生的条件：函数成员，可见，签名一致
//多态
    //基于重写机制（virtual->override）
    //函数成员的具体行为（版本）由对象决定
    //回顾：C#语言的变量和对象都是有类型的，所以会有“代差”
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ClassExample0261{
    class Program{
        static void Main(string[] args) {
            var v = new Vehicle();
            v.Run();
            var c = new Car();
            c.Run();

            Vehicle rasecar = new RaseCar();        //多态
            rasecar.Run();
        }
    }

    class Vehicle {
        public virtual void Run () {
            System.Console.WriteLine("I'm runnning...");
        }
    }

    class Car:Vehicle {
        public int Speed { get; set; }
        public override void Run () {               //重写（没有virtual和override就是隐藏）
            System.Console.WriteLine("Car is runnning...");
        }
    }

    class RaseCar:Car {
        public override void Run () {
            System.Console.WriteLine("RaseCar is running...");
        }
    }
}
