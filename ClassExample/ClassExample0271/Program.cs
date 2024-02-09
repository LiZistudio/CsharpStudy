using System;

namespace ClassExample0271 {
    class Program {
        static void Main(string[] args) {
            Vehical v1 = new Car();
            v1.Run();
            Vehical v2 = new Truck();
            v2.Run();            
            Vehical raceCar = new RaceCar();     //因为“继承”、“重写（虚函数）”、“抽象类、抽象函数（纯虚函数）”而表现出的【多态】
            raceCar.Run();
            raceCar.Stop();
            raceCar.Fill();
        }
    }


    interface IVehical {
        void Stop();
        void Fill();
        void Run();
    }
    abstract class Vehical : IVehical {
        public void Stop() {
            System.Console.WriteLine("Stopped.");
        }

        public void Fill() {
            System.Console.WriteLine("Pay and fill.");
        }

        public abstract void Run();
    }
    class Car : Vehical {
        public override void Run(){
            System.Console.WriteLine("Car is running...");
        }
    }

    class Truck : Vehical {
        public override void Run(){
            System.Console.WriteLine("Turck is running...");
        }
    }

    class RaceCar : Vehical {
        public override void Run() {
            System.Console.WriteLine("RaceCar is running...");
        }
    }
}

/*为作基类而生的“抽象类”与“开放/关闭原则”*/

// >什么是接口和抽象类
//     >接口和抽象类都是“软件工程产物”
//     >具体类->抽象类->接口：越来越抽象，内部实现的东西越来越少
//     >抽象类是未完全实现逻辑的类（可以有字段和非public成员，他们代表了“具体逻辑”）
//     >抽象类为复用而生：专门作为基类来使用，也具有解耦功能
//     >封装确定的，开放不确定的，推迟到合适的子类中去实现
//     >接口是完全为实现逻辑的“类”（“纯虚类”；只有函数成员；成员全部public）
//     >接口为解耦而生：“高内聚，低耦合”，方便单元测试
//     >接口是一个“协约”，早已为工业生产所熟知（有分工必有协作，有协作必有协约）
//     >他们都不能实例化，只能用来声明变量，引用具体类（concrete class）的实例
