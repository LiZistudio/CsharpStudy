/*接口隔离、反射、特性、依赖注入*/

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Extensions.DependencyInjection;


namespace InterfaceExample2901 {
    class Program {
        static void Main(string[] args) {
            //// var driver = new Driver(new HeavyTank());
            //// driver.Drive();

            //ITank tank = new HeavyTank();
            ////================================
            //var t = tank.GetType();
            //object o = Activator.CreateInstance(t);
            //MethodInfo fireMi = t.GetMethod("Fire");
            //MethodInfo runMi = t.GetMethod("Run");
            //fireMi.Invoke(o, null);
            //runMi.Invoke(o, null);
            //-------------------------------------------------------------------------
            var sc = new ServiceCollection();
            sc.AddScoped(typeof(ITank), typeof(HeavyTank));
            sc.AddScoped(typeof(IVehicle), typeof(Car));
            sc.AddScoped<Driver>();
            var sp = sc.BuildServiceProvider();                     //注册
            //=================================================
            //ITank tank = sp.GetService<ITank>();
            //tank.Fire();
            //tank.Run();                                             //依赖注入
            var driver = sp.GetService<Driver>();
            driver.Drive();
        }
    }

    class Driver {
        private IVehicle _vehicle;
        public Driver(IVehicle vehicle) { _vehicle = vehicle; }
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
    interface ITank : IVehicle, IWeapon { } //C#中一个类只能继承自一个类，但一个接口可以继承自多个接口。

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