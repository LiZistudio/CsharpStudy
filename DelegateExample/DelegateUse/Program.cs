//委托的一般使用
/**实例：把方法当作参数传给另一个方法
    * 正确使用1：模板方法，“借用”指定的外部方法来产生结果
        *相当于“填空题”
        *常位于代码中部
        *委托有返回值
    *正确使用2：回调（call back）方法，调用指定的外部方法
        *相当于“流水线”
        *常位于代码末尾
        *委托无返回值
！！！委托要慎用。
*/

using System;
using System.Dynamic;

namespace DelegateUse{

    public delegate void myAction();        //自定义委托类型
    public delegate double myAct(double a,double b);        //自定义委托类型

    public delegate TResult myFunc<in T1,in T2,out TResult> (T1 arg1, T2 arg2);     //自定义泛型委托类型

    class Program{
        static void Main(string[] args){
            //--------------------------------------------------
            // Student stu1 = new Student("LiHua");
            // //stu1.Name = "LiHua";
            // System.Console.WriteLine(stu1.Name);
            //--------------------------------------------------

            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            Logger logger = new Logger();
            Action<Product> log = new Action<Product> (logger.Log);     //callBack回调方法

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            Box box1 = wrapFactory.WrapProduct(func1,log);      //将委托传给模板方法
            Box box2 = wrapFactory.WrapProduct(func2,log);

            System.Console.WriteLine(box1.Product.Name);
            System.Console.WriteLine(box2.Product.Name);
            
        }
    }

    class Logger{
        public void Log(Product product){
            System.Console.WriteLine("Product '{0}' created at {1}.Price is {2}.", product.Name,DateTime.UtcNow,product.Price);
        }
    }
    class Product{
        public string Name{get;set;}
        public double Price{get;set;}
    }
    class Box{
        public Product Product {get;set;}
    }

    //public delegate TResult myFunc <out TResult> ();
    //public delegate void myAction <in T1> (T1 arg1);
    class WrapFactory{
        public Box WrapProduct (Func<Product> getProduct,Action<Product> logCallback) {     //模板方法
            Box box = new Box();
            Product product = getProduct();
            if (product.Price>=50)
            {
                logCallback(product);       //回调委托 callBack
            }
            box.Product = product;
            return box;
        }
    }

    class ProductFactory{
        public Product MakePizza(){
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 12;
            return product;
        }

        public Product MakeToyCar(){
            Product product = new Product();
            product.Name = "Toy Car";
            product.Price = 100;
            return product;
        }
    }

    //---------------------------------------------------
    // class Student{
    //     private string name;
    //     public string Name{
    //         get{return name;}
    //         // set{
    //         //     if (value == null){
    //         //         name = "NULL";
    //         //     }else{
    //         //         name = value;
    //         //     }
    //         // }
    //     }

    //     public Student(string nameStr){
    //         name = nameStr;
    //     }

    // }
    //----------------------------------------------------
}