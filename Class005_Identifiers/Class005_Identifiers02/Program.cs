namespace Identifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int 我的变量 = 100;
            Console.WriteLine(我的变量);        //中文变量名

            int myVariable = 100;
            Console.WriteLine(myVariable);      //驼峰法命名

            int x = 100;
            long y = 100L;
            short z = 0;

            float num1 = 3.0F;
            double num2 = 4.0D;

            char c = 'a';
            string str1 = "hello";
            string str2 = null;
            bool a = false;

            //注释
            /*
             * 块注释
             * 
             * 
             */
            var name = "ok";
            var data = 5.0D;

            Console.WriteLine(data.GetType().Name);
            Console.WriteLine("***************************");
            int res2 = Calculator.Pow(2, 10);
            Console.WriteLine(res2);

            Calculator Cal = new Calculator();
            Console.WriteLine(Cal.Add(2,10));

            Console.WriteLine("今天是{0}号",Calculator.GetToday());

            Cal.PrintSum(10, 20);

            Calculator.PrintXTo1(10);

            int result = Calculator.SumFrom1ToX(100);
            Console.WriteLine(result);
        }
    }

    class Calculator
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public static int Pow(int a,int b)
        {
            int i = 0;
            int res = 1;
            for (i = 0; i < b; i++)
            {
                res = res * a;
            }
            return res;
        }

        public static String GetToday()
        {
            int day = DateTime.Now.Day;
            return day.ToString();
        }

        public void PrintSum(int a,int b)
        {
            Console.WriteLine("和为：{0}",a+b);
        }

        //递归打印从x到1
        public static void PrintXTo1(int x)
        {
            if (1 == x)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(x);
                PrintXTo1(x - 1);
            }
        }

        //递归前n项和
        public static int SumFrom1ToX(int x)
        {
            if (1 == x)
            {
                return 1;
            }
            else
            {
                int res = 0;
                res = x + SumFrom1ToX(x - 1);
                return res;
            }
        }

        public int AddFrom1TOX (int x)
        {
            int res = x*(1+x)/2;
            return res;
        }
    }
}