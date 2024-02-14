/*接口隔离、反射、特性、依赖注入*/

using System;

namespace InterfaceExample2901 {
    class Program {
        static void Main(string[] args) {
            var driver = new Driver(new HeavyTank());
            driver.Drive();
        }
    }

    class Driver {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle) { _vehicle = vehicle;}
        public void Drive() {
            _vehicle.Run();
        }
    }
    interface IVehicle {
        void Run();
    }

    class Car : IVehicle {
        public void Run() {
            System.Console.WriteLine("Car is running...");
        }
    }

    class Truck : IVehicle {
        public void Run() {
            System.Console.WriteLine("Truck is running ...");
        }
    }

    interface IWeapon {
        void Fire();
    }
    interface ITank : IVehicle , IWeapon {      //C#中一个类只能继承自一个类，但一个接口可以继承自多个接口。
    }

    class LightTank : ITank {
        public void Fire() {
            System.Console.WriteLine("Boom!");
        }
        public void Run() {
            System.Console.WriteLine("Ka ka ka ...");
        }
    }
    class MediumTank : ITank {
        public void Fire() {
            System.Console.WriteLine("Boom!!");
        }
        public void Run() {
            System.Console.WriteLine("Ka! ka! ka! ...");
        }
    }

    class HeavyTank : ITank {
        public void Fire() {
            System.Console.WriteLine("Boom!!!");
        }
        public void Run() {
            System.Console.WriteLine("Ka!! ka!! ka!! ...");
        }
    }
}