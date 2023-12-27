using NamespaceClass;

namespace NamespaceClass
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("落霞与孤鹜齐飞，秋水共长天一色");
            double result1 = NewSpace.Add(6.6, 8.8);
            double result2 = NewSpace.Sub(6.6, 8.8);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            
            return 0;
        }
    }

}