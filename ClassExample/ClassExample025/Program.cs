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
            // raceCar.Owner = "vehicle";      //子类对父类的成员全盘继承，一直向下传递
            // Type t = raceCar.GetType();
            // System.Console.WriteLine(t.FullName);
//------------------------------------------------------------------------------


        }
    }

    //sealed关键字->"封闭类"
    /*sealed*/ class Vehicle : Object{
        public string Owner { get; set; }
    }

    class Car : Vehicle {

    }

    // class RaceCar : Car {

    // }
    //C#中一个类最多只能有一个基类，但可以有多个基接口
    //子类的访问级别不能超过父类
}