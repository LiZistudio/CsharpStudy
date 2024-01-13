//语句

namespace Express
{
    class Program
    {
        static void Main()
        {
            int[] x = { 1, 2, 3 };
            int[,] y = new int[2,3] {{ 1, 2, 3},{ 4, 5, 6 }};
            
            double result = Calculator.GetCylinderVolume(2D,10D);
            Console.WriteLine(result);

            string input = Console.ReadLine();
            try
            {
                double score = Convert.ToDouble(input);
                if (score >= 60)
                {
                    Console.WriteLine("congratulation！你及格了。");
                }
                else
                {
                    Console.WriteLine("Sorry!你没及格。");
                }
            }
            catch
            {
                Console.WriteLine("Failed!");
            }
        }
    }

    class Calculator
    {
        public static double GetCylinderVolume(double r, double h) 
        {
            double Area = 3.14*r*r;
            double volume = Area*h;
            return volume;
        }
    }
}
