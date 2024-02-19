/*泛型、partial类、枚举、结构体*/
//泛型与其他元素的正交性，使他无处不在。

using System;

namespace SupplementExample3001 {
    class Program {
        static void Main(string[] args) {
            Apple apple = new Apple() { Color = "Red" };
            Book book = new Book() { Name = "new book" };
            Box<Apple> box = new Box<Apple>() { Cargo = apple };
            Box<Book> box2 = new Box<Book>() { Cargo =  book };
            Console.WriteLine(box.Cargo.Color);
            Console.WriteLine(box2.Cargo.Name);
        }

        class Apple {
            public string Color { get; set; }
        }

        class Book {
            public string Name { get; set; }
        }
        class Box<TCargo> {                         //泛型类
            public TCargo Cargo { get; set; }
            //public Apple Apple { get; set; }
            //public Book Book { get; set; }      //成员膨胀
        }
    }
}