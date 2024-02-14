/*接口隔离、反射、特性、依赖注入*/

using System;
using System.Collections;

namespace InterfaceExample2902 {
    class Program {
        static void Main(string[] args) {
            int[] array1 = {1,2,3,4,5};
            ArrayList array2 = new ArrayList{1,2,3,4,5};
            System.Console.WriteLine(Sum(array1));
            System.Console.WriteLine(Sum(array2));
//---------------------------------------------------------------
            var array3 = new ReadOnlyCollection(array1);
            foreach (var i in array3) {
                System.Console.WriteLine(i);
            }
            System.Console.WriteLine(Sum(array3));
        }

        static int Sum(IEnumerable nums) {
            int sum = 0;
            foreach (int i in nums) {
                sum += i;
            }
            return sum;
        }
    }

    class ReadOnlyCollection : IEnumerable {
        private int[] _array;

        public ReadOnlyCollection(int[] array) {
            _array = array;
        }
        public IEnumerator GetEnumerator() {
            return new Enumerator(this);
        }

        public class Enumerator : IEnumerator
        {
            private ReadOnlyCollection _collection;
            private int _head;
            public Enumerator(ReadOnlyCollection collection) {
                _collection = collection;
                _head = -1;
            }
            public object Current {
                get {
                    object o = _collection._array[_head];
                    return o;
                }
            }

            public bool MoveNext() {
                if (++_head < _collection._array.Length) {
                    return true;
                }else {
                    return false;
                }
            }

            public void Reset() {
                _head = -1;
            }
        }
    }
}