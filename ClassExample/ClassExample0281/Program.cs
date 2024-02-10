/*接口、依赖反转、单元测试*/
// >接口与单元测试
//     >接口的产生：自底向上（重构），自顶向下（设计）
//     >C#中接口的实现（隐式、显示、多借口）
//     >语言对面向对象设计的内建支持：依赖反转、接口隔离、开闭原则、、、、、、

using System;
using System.Collections;

namespace ClassExample0281 {
    class Program {
        static void Main(string[] args) {
            int[] nums1 = new int[] {1,2,3,4,5};
            ArrayList nums2 = new ArrayList {1,2,3,4,5};
            System.Console.WriteLine("add:{0}",Sum(nums1));
            System.Console.WriteLine("avg:{0}",Avg(nums1));
            System.Console.WriteLine("add:{0}",Sum(nums2));
            System.Console.WriteLine("avg:{0}",Avg(nums2));
        }

        // static int Sum(int[] nums) {
        //     int sum = 0;
        //     foreach (var item in nums) sum += item;
        //     return sum;
        // }

        // static double Avg(int[] nums) {
        //     int sum = 0;
        //     double avg = 0;
        //     foreach (var item in nums) sum += item;
        //     avg = sum/nums.Length;
        //     return avg;
        // }

        static int Sum(IEnumerable nums) {
            int sum = 0;
            foreach (int item in nums) sum += item;
            return sum;
        }

        static double Avg(IEnumerable nums) {
            int sum = 0;
            double avg = 0;
            int count = 0;
            foreach (int item in nums) {
                sum += item;
                count++;
            }
            avg = sum/count;
            return avg;
        }
    }
}