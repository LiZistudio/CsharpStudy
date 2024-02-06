using System;
using MyLib;

namespace ClassExample0253 {
    class Program {
        static void Main(string[] args) {
            Vehicle vehicle = new Vehicle();
            vehicle.Owner = "Authur";
            System.Console.WriteLine(vehicle.Owner);
        }
    }

}