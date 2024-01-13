//while;    do..while;  continue;   break;  for;    foreach;
using System;

namespace ExpressExample016
{
    class Program
    {
        public static int Main(string[] args)
        {
            //int score = 0;
            ////bool canContinue = true;
            ////while (canContinue)
            ////while(true)
            ////{
            ////    Console.WriteLine("Please input first number:");
            ////    string str1 = Console.ReadLine();
            ////    int num1 = Convert.ToInt32(str1);
            ////    Console.WriteLine("Please input Second number:");
            ////    string str2 = Console.ReadLine();
            ////    int num2 = Convert.ToInt32(str2);
            ////    int res = num1 + num2;
            ////    if (res == 100)
            ////    {
            ////        score++;
            ////        Console.WriteLine("Correct!{0}+{1}={2}",num1,num2,res);
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("Error!{0}+{1}={2}",num1,num2,res);
            ////        //canContinue = false;
            ////        break;
            ////    }
            ////}
            //int res = 0;
            //int num1 = 0;
            //int num2 = 0;
            //do
            //{
            //    Console.WriteLine("Please input first number:");
            //    string str1 = Console.ReadLine();
            //    if (str1.ToLower() == "end")
            //    {
            //        break;
            //    }
            //    try
            //    {
            //        num1 = Convert.ToInt32(str1);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("参数有误");
            //        continue;
            //    }
            //    Console.WriteLine("Please input Second number:");
            //    string str2 = Console.ReadLine();
            //    if (str2.ToLower() == "end")
            //    {
            //        break;
            //    }
            //    try
            //    {
            //        num2 = Convert.ToInt32(str2);
            //    }
            //    catch
            //    {
            //        Console.WriteLine("参数有误");
            //        continue;
            //    }
            //    res = num1 + num2;
            //    if (res == 100)
            //    {
            //        score++;
            //        Console.WriteLine("Correct!{0}+{1}={2}", num1, num2, res);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error!{0}+{1}={2}", num1, num2, res);
            //        break;
            //    }
            //} //while (res == 100);
            //while (true);

            //Console.WriteLine("得分:{0}", score);


            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("hello");
            //}

            //for ( ; ; )
            //{
            //    Console.WriteLine("123");
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("{0}X{1}={2}\t",i,j,i*j);
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1;j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            int[] arr = new int[10] {1,2,3,4,5,6,7,8,9,10};

            foreach (var i in arr)
            {
                Console.WriteLine("{0}", i);
            }

            return 0;
        }
    }
}
