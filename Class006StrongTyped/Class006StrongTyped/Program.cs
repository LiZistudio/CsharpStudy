using System;
using System.Data;
using System.Numerics;
using System.Reflection;

namespace StrongTyped
{
    class Program
    {
        static void Main()
        {
            int x = 100;
            long y = 100L;
            //x = 100L;

            bool b = true;
            bool c = false;
            //b = 100;

            if (100 == x) {
                Console.WriteLine("it's OK");
            }

            /*dynamic Type*/
            dynamic myVar = 100;
            Console.WriteLine(myVar);
            myVar = "StrongType";
            Console.WriteLine(myVar);
            
            
            /*********反射*********/
            Type myType = typeof(int);
            PropertyInfo[] pinfos = myType.GetProperties();
            
            foreach (var p in pinfos) {
                Console.WriteLine(p.Name);
            }
            
            Console.WriteLine(myType.FullName);
            Console.WriteLine(myType.BaseType.FullName);

            //BadGuy bg = new BadGuy();
            //bg.BadMethod();
        }
    }

    /*class BadGuy
    {
        public void BadMethod() { 
            int x = 100;
            this.BadMethod();
        }
    }*/

}