using System;

namespace DelegateTest{
    class Program{
        static void Main(string[] args){
            System.Console.WriteLine("Please Input:");
            string age = Console.ReadLine();
            int ageInt = 0;
            try
            {
                //ageInt = Convert.ToInt32(age);
                ageInt = Convert.ToInt32(age);
            }
            catch
            {
                System.Console.WriteLine("INPUT ERROR");
            }
            System.Console.WriteLine(ageInt);
        }
    }
}