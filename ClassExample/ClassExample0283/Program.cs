/*接口、依赖反转、单元测试*/

using System;

namespace CalssExample0283 {
    class Program {
        static void Main(string[] args) {
            IPhone nokia = new NokiaPhone();
            IPhone ericssonPhone = new EricssonPhone();
            PhoneUser phoneUser1 = new PhoneUser(nokia);
            PhoneUser phoneUser2 = new PhoneUser(ericssonPhone);

            phoneUser1.UsePhone();
            phoneUser2.UsePhone();
            
        }
    }

    class PhoneUser {
        private IPhone _phone;
        public PhoneUser(IPhone phone) { _phone = phone; }
        public void UsePhone() {
            _phone.Dail();
            _phone.PickUp();
            _phone.Send();
            _phone.Receive();

        }
    }

    interface IPhone {
        void Dail();        //拨号
        void PickUp();      //接电话
        void Send();        //发短信
        void Receive();     //接收消息
    }

    class NokiaPhone : IPhone {
        public void Dail() {
            System.Console.WriteLine("Nokia calling...");
        }

        public void PickUp() {
            System.Console.WriteLine("Hello! This is Tim!");
        }

        public void Receive() {
            System.Console.WriteLine("Nokia message ring...");
        }

        public void Send() {
            System.Console.WriteLine("Hello!");
        }
    }

    class EricssonPhone : IPhone {
        public void Dail() {
            System.Console.WriteLine("Ericsson calling ...");
        }

        public void PickUp() {
            System.Console.WriteLine("Hi!This is Tim!");
        }

        public void Receive() {
            System.Console.WriteLine("Ericsson ring...");
        }

        public void Send() {
            System.Console.WriteLine("Good evening!");
        }
    }
}