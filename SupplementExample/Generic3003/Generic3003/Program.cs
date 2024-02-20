/*泛型*/

using System;
using System.Collections.Generic;

namespace Generic3003 {
    class Program {
    //    static void Main(string[] args) {
    //        IList<int> list = new List<int>();
    //        for (int i = 0; i < 100; i++) {
    //            list.Add(i);
    //        }
    //        foreach (var i in list) {
    //            Console.Write("{0} ", i);
    //        }

    //        Func<int, int, int> func = new Func<int, int, int>(Add);
    //        Console.WriteLine(Add(1,2));
    //    }

    //    public static int Add(int a, int b) {
    //        return a + b;
    //    }
        static void Main(string[] args) {
            //IDictionary<int,string> map = new Dictionary<int,string>();
            //map[1] = "Authur";
            //map[2] = "Tim";
            //Console.WriteLine($"Student #1 is {map[1]}.Student #2 is {map[2]}.");
            int[] arr1 = {1,2,3,4,5};
            int[] arr2 = {1,2,3,4,5,6};
            double[] arr3 = {1.1,2.2,3.3,4.4,5.5,6.6};
            double[] arr4 = {1.1,2.2,3.3,4.4,5.5,6.6,7.7};
            //var res1 = Zip<int> (arr1, arr2);
            //var res2 = Zip<double> (arr3, arr4);
            var res1 = Zip(arr1, arr2);
            var res2 = Zip(arr3, arr4);
            Console.WriteLine(string.Join(",",res1));
            Console.WriteLine(string.Join(",",res2));
        }

        public static T[] Zip<T> (T[] arr1, T[] arr2) {
            int ai = 0;
            int bi = 0;
            int zi = 0;
            T[] zipped = new T[arr1.Length+arr2.Length];
            do {
                if (ai < arr1.Length) { zipped[zi++] = arr1[ai++]; }
                if (bi < arr2.Length) { zipped[(zi++)] = arr2[bi++]; }
            }while (ai < arr1.Length || bi < arr2.Length);
            return zipped;
        }
    }
}