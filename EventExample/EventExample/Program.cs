﻿/*认识事件
*角色:使对象或者类具备通知能力的成员
*使用:用于对象或类间动作协调和消息传递
*原理:事件模型（Event Model）中的两个“5”
    *“发生->响应”中的5个部分———闹钟响了你起床、孩子饿了你做饭......这里隐含着“订阅”关系
    *“发生->响应”中的5个动作———1、我有一个事件->2、一个人或一群人关心我这个事件->3、我的这个事件发生了->
    4、关心这个事件的人会被依次通知到->5、被通知到的人根据拿到的事件信息（又被称“事件数据”、“事件参数”、“通知”）
    对时间进行响应（又称“处理事件”）。
*/

/*事件的应用
*实例演示
    *派生（继承）与扩展（extends）
*事件模型的五个组成部分
    1、事件的拥有者（event source,对象）
    2、事件成员（event,成员）
    3、事件的响应者（event subscriber,对象）
    4、事件的处理器（event handler，成员）———本质上是一个回调方法
    5、事件订阅——把事件处理器与事件关联在一起，本质上是一种以委托类型为基础的“约定”
*注意:
    *事件处理器是方法成员
    *接挂事件处理器的时候，可以使用委托实例，也可以直接使用方法名，这是个“语法糖”
    *事件处理器对事件的订阅不是随意的，匹配与否由声明事件时所使用的委托类型来检测
    *事件可以同步调用也可以异步调用
*/

using System;
using System.Timers;

namespace EventExample{
    class Program{
        static void Main(String[] args) {
            
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            Boy boy = new Boy();
            Girl girl = new Girl();

            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;
            timer.Start();
            Console.ReadLine();
        }
    }

    class Boy{
        internal void Action (object sender, ElapsedEventArgs e){
            System.Console.WriteLine("JUMP");
        }
    }

    class Girl{
            internal void Action (object sender,ElapsedEventArgs e){
                System.Console.WriteLine("Sing");
            }
    }
}