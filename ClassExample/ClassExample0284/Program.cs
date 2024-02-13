/*接口、依赖反转、单元测试*/

using System;

namespace ClassExample0284 {
    class Program {
        static void Main(string[] args) {
            var powerSupply = new PowerSupply();
            var deskFan = new DeskFan(powerSupply);
            System.Console.WriteLine(deskFan.Work());
        }
    }

    public interface IPowerSupply {
        int GetPower();
    }

    public class PowerSupply : IPowerSupply {
        public int GetPower() {
            return 100;
        }
    }

    public class DeskFan {
        private IPowerSupply _powerSupply;
        public DeskFan(IPowerSupply powerSupply) {
            _powerSupply = powerSupply;
        }

        public string Work() {
            int power = _powerSupply.GetPower();
            if (power <= 0) {
                return "Won't work";
            }else if (power < 100) {
                return "Slow";
            }else if (power < 200) {
                return "Work fine";
            }else {
                return "Warning!";
            }
        }
    }
}