/*接口、依赖反转、单元测试*/

using System;

namespace ClassExample0282 {
    class Program {
        static void Main(string[] args) {
            Engine engine = new Engine();
            Car car = new Car(engine);
            car.Run(6);
            System.Console.WriteLine("The Car's speed is {0} and engine's RPM is {1}.",car.Speed,engine.RPM);
        }
    }

    class Engine {
        public int RPM { get; private set; }
        public void Work(int gas) {
            this.RPM = 1000*gas;
        }
    }

    class Car {
        private Engine _engine;
        public Car(Engine engine) {
            _engine = engine;
        }

        public int Speed { get; private set; }
        public void Run(int gas) {
            _engine.Work(gas);
            this.Speed = _engine.RPM/100;
        }
    }
}