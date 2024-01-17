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

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            Box box1 = wrapFactory.WrapProduct(func1);
            Box box2 = wrapFactory.WrapProduct(func2);

            System.Console.WriteLine(box1.Product.Name);
            System.Console.WriteLine(box2.Product.Name);

        }
    }

    class Product{
        public string Name{get;set;}
    }
    class Box{
        public Product Product {get;set;}
    }
    class WrapFactory{
        public Box WrapProduct (Func<Product> getProduct) {
            Box box = new Box();
            Product product = getProduct();
            box.Product = product;
            return box;
        }
    }

    class ProductFactory{
        public Product MakePizza(){
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }

        public Product MakeToyCar(){
            Product product = new Product();
            product.Name = "Toy Car";
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