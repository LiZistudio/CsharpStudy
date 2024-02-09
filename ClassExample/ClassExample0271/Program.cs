using System;
using System.Runtime.CompilerServices;

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

    abstract class Vehical {
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