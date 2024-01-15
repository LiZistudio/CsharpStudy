
//数组参数
//* 必须是形参列表中最后一个，由params修饰。
//* 举例如下；String.Split方法

using System;

namespace ArrayParametric
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = new int[]{ 1, 2, 4, 2, 76, 7, 34, 213, 78, 12 };
            //int res = Program.CalculateSum(arr1);     //429
            int res = Program.CalculateSum(1, 2, 4, 2, 76, 7, 34, 213, 78, 12);     //params参数
            Console.WriteLine(res);     //429

            int x = 100;
            int y = 200;
            int z = x + y;
            Console.WriteLine("{0}+{1}={2}",x,y,z); //Console.WriteLine();事实上CW也使用了params（对象）数组参数，即x,y,z;

            string str = "Tim;Tom,Amy.Lisa";
            string[] result = str.Split(';', ',', '.');     //这里使用了字符数组参数
            foreach(var name in result)
            {
                Console.WriteLine(name);
            }
        }

        //static int CalculateSum(int[] intArray)

        static int CalculateSum(params int[] intArray)      //params参数
        {
            int sum = 0;
            foreach (int item in intArray)
            {
                sum += item;
            }
            return sum;
        }
    }

}
