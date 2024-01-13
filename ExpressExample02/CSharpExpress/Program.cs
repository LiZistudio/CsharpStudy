namespace Express02
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //int x = 1;
                //if (x == 1)
                //{
                //    Console.WriteLine(x);
                //}
                ////hello: Console.WriteLine("hello world");
                ////goto hello;
            }
                int score = 100;
                //if (score >= 80 && score <= 100)
                //{
                //    Console.WriteLine("A");
                //}
                //else if (score >= 60)
                //{
                //    Console.WriteLine("B");
                //}
                //else if (score >= 40)
                //{
                //    Console.WriteLine("C");
                //}
                //else if (score >= 0)
                //{
                //    Console.WriteLine("D");
                //}
                //else
                //{
                //    Console.WriteLine("Input Error!"); 
                //}
                switch (score/10)
            {
                case 10:
                    if (score==100)
                    {
                        goto case 8;
                    }
                    else
                    {
                        goto default;
                    }
                case 8:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("B");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("C");
                    break;
                case 0:
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("D");
                    break;
                default: 
                    Console.WriteLine("Input Error!");
                    break;
            }
            Console.WriteLine("===========================");
            int res = 0;
            try
            {
                res = Calculator.Add("9999999999999999999", "0");
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            Console.WriteLine(res);
        }
    }

    class Another
    {
        public static void MyFun()
        {
            Level level = Level.low;
            switch (level)
            {
                case Level.low:
                    break;
                case Level.mid:
                    break;
                case Level.high:
                    break;
                default:
                    break;
            }
        }
        private enum Level
        {
            low,
            mid,
            high,
        }
    }
    class Calculator
    {
        public static int Add (string str1,string str2)
        {
            int num1 = 0;
            int num2 = 0;
            bool hasError = false;

            try
            {
                num1 = int.Parse(str1);
                num2 = int.Parse(str2);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
                Console.WriteLine("输入的参数中有null值");
                Console.WriteLine("参数有误！");
                hasError = true;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                Console.WriteLine("输入的参数中有非数子形式的值");
                Console.WriteLine("参数有误！");
                hasError= true;
            }
            catch (OverflowException oe)
            {
                //Console.WriteLine(oe.Message);
                //Console.WriteLine("输入的值过大");
                //Console.WriteLine("参数有误！");
                hasError = true;
                throw oe;       //抛出异常，让调用者去处理
            }
            finally
            {
                Console.WriteLine("释放资源");
                if (hasError)
                {
                    Console.WriteLine("发生了错误");
                }
                else 
                {
                    Console.WriteLine("正常"); 
                }
            }

            int result = num1 + num2;
            return result;
        }
    }
}