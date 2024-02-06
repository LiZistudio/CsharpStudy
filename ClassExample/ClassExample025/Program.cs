namespace ClassExample025{
    class Program{
        static void Main(string[] args) {
            // Type t = typeof(Car);
            // Type tb = t.BaseType;
            // System.Console.WriteLine(tb.FullName);      //打印:ClassExample025.Vehicle

//------------------------------------------------------------------------------
            // Car car = new Car();
            // System.Console.WriteLine(car is Object);

            // Vehicle vehicle = new Car();
            // Object o1 = new Vehicle();
            // Object o2 = new Car();          //“是一个”（is a ）
//------------------------------------------------------------------------------
            // RaceCar raceCar = new RaceCar();
            // raceCar.Owner = "vehicle";      //子类对父类的成员"全盘继承"，一直向下传递(实例构造器不被继承)
            // Type t = raceCar.GetType();
            // System.Console.WriteLine(t.FullName);
//------------------------------------------------------------------------------
            Car car = new Car();
            System.Console.WriteLine(car.Owner);
            car.ShowOwner();
        }
    }

    //sealed关键字->"封闭类"
    /*sealed*/ class Vehicle : Object{
        public Vehicle(string owner) {
            this.Owner = owner;
        }
        public string Owner { get; set; }
    }

    class Car : Vehicle {
        public Car():base("N/A") {          //子类不会继承父类的实例构造器
            this.Owner = "Car Owner";
        }

        public void ShowOwner() {
            System.Console.WriteLine(base.Owner);       //Car Owner
        }
    }

    // class RaceCar : Car {

    // }
    //C#中一个类最多只能有一个基类，但可以有多个基接口
    //子类的访问级别不能超过父类
}