using System;


namespace FunctionMethod{
    class Program{
        static int Main()
        {
            Console.WriteLine("MethodAndFunction");
            Console.WriteLine(MyMethod.Add(6.66,8.88));
            Console.WriteLine("***************************");
            Calculator MyCalculator = new Calculator();
            double Result = MyCalculator.GetCircleArea(2);
            double Result2 = MyCalculator.GetBallVolume(2);
            double Result3 = MyCalculator.GetCylinderVolume(2,10);
            double Result4 = MyCalculator.GetConeVolume(2, 10);
            Console.WriteLine("圆面积:{0};球体积:{1};圆柱体积:{2};圆锥体积:{3}",Result,Result2,Result3,Result4);
            return 0;
        }
    }

    class MyMethod
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
    }
    class Calculator
    {
        public double GetCircleArea(double r)
        {
            return double.Pi* r*r;
        }
        public double GetBallVolume(double r)
        {
            return 4*double.Pi*r*r*r/3;
        }
        //public double GetCylinderVolume(double r,double h)
        //{
        //    return double.Pi * r * r * h;
        //}
        public double GetCylinderVolume(double r, double h)
        {
            return GetCircleArea(r)*h;
        }
        //public double GetConeVolume(double r, double h)
        //{
        //    return double.Pi*r * r * h/3;
        //}
        public double GetConeVolume(double r, double h)
        {
            return GetCylinderVolume(r,h) / 3;
        }
    }
}