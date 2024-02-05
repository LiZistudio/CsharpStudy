/*类的声明与访问级别*/
/*public && internal:   *public可以将一个class从Assembly暴露给其他Assembly使用，
                        internal只能将class限制在本Assembly中使用。*/

using System;
using MyLib;

namespace ClassExample024{
    class Program{
         static void Main(string[] args){
            MyLib.Calculator calculator = new MyLib.Calculator();
            var result = calculator.Add(6.6,8.8);
            System.Console.WriteLine(result);
         }

        //  class Student {        //成员类

        //  }      
    }
}

//------------------------------
// namespace MyNS {
//     class Program{

//     }
// }

//默认在Global名称空间内。（不会这样做）
// class Computer{
    
// }