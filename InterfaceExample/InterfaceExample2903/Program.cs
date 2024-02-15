/*接口隔离、反射、特性、依赖注入*/

using System;

namespace InterfaceExample2903 {
    class Program {
        static void Main(string[] args) {
            IKiller killer = new WarmKiller();
            killer.Kill();

            var gentleman = (WarmKiller)killer;
            gentleman.Love();
        }
    }

    interface IGentleman {
        void Love();

    }

    interface IKiller {
        void Kill();
    }

    class WarmKiller : IGentleman,IKiller {
        public void Love() {
            System.Console.WriteLine("I will love you for ever ...");
        }

        void IKiller.Kill() {                                       //接口的显示实现————C#独有的功能
            System.Console.WriteLine("Let me kill the enemy ...");
        }
    }
}