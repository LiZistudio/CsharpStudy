/*事件的声明(事件是基于委托的)
    ~完整声明和简略声明

*/

using System;
using System.Security.Cryptography;
using System.Threading;

namespace EventDefine
{
    class Program {
        static void Main(string[] args){
            Customer customer = new Customer();
            Waiter waiter = new Waiter();
            customer.Order += waiter.Action;
            customer.Action();
            customer.PayTheBill();
        }
    }

    public delegate void OrderEventHandler (Customer customer,OrderEventArgs e);  //C#规定为事件声明的委托类型名称要以EventHandler为后缀

    public class Customer{
        public double Bill{get;set;}
        public void PayTheBill(){
            System.Console.WriteLine("I will pay ${0}.",this.Bill);
        }
        //--------------完整声明-------------------------------
        private OrderEventHandler orderEventHandler;    //声明委托类型字段用来存放事件处理器
        /*声明事件*/
        public event OrderEventHandler Order {
            add{
                this.orderEventHandler += value;
            }
            remove{
                 this.orderEventHandler -= value;       //事件其实是对委托字段的封装！！！
            }                                           //只保留+=、-=的功能，而隐藏了判断是否为空以及Invoke()等功能。
        }                                               //个人觉得可以类比属性是对字段的封装去理解。
        //---------------------------------------------

        //-------------简化声明（字段式声明）--------------------------------
        //public event OrderEventHandler Order;
        //---------------------------------------------

        public void WalkIn(){
            System.Console.WriteLine("Walk In the restaurant.");
        }
        public void SitDown(){
            System.Console.WriteLine("Sit down.");
        }
        public void Think(){
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Let me think...");
                Thread.Sleep(1000);
            }
            this.OnOrder("GongBaoJiDing", "large");
        }
        protected void OnOrder(string dishname,string size){        //OnOrder(On+事件名)专门为触发事件的方法
            if(this.orderEventHandler != null){
                OrderEventArgs e = new OrderEventArgs();
                e.DishName = dishname;
                e.Size = size;
                this.orderEventHandler.Invoke(this,e);
            }
        }
        public void Action(){
            Console.ReadLine();
            this.WalkIn();
            this.SitDown();
            this.Think();
        }
    }

    public class OrderEventArgs:EventArgs        //C#规定传递事件消息的类名以EventArgs为后缀
    {
        public string DishName {get;set;}
        public string Size {get;set;}
    }

    public class Waiter{
        public void Action(Customer customer,OrderEventArgs e){
            System.Console.WriteLine("I will server you the dish - {0}.",e.DishName);        
            double price = 10;
            switch (e.Size)
            {
                case "samll":
                    price = price*0.5;
                    break;
                case "large":
                    price = price*1.5;
                    break;
                default:
                    break;
            }
            customer.Bill += price;
        }  
    }
}