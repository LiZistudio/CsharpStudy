
using System;

namespace ClassExample027 {
    class Program {
        static void Main(string[] args) {
            int[] arr = {5,7,3,1,90,34,2,21,4,4546,56,787,3453};
            //int[] arr = {1,2,3,4,5,6,7,8,9};
            QuickSort(arr,0,arr.Length-1);
            foreach (var item in arr) {
                System.Console.Write("{0} ",item);
            }
        }

        public static void QuickSort (int[] arr, int left, int right) {
            if (left >= right) return;
            int start = left;
            int end = right;
            int tag = arr[start];
            while ( left < right ){
                while ( right > left && arr[right] >= tag ) {
                    right -= 1;
                }
                if ( left < right ) {
                    arr[left] = arr[right];
                    left += 1;
                }
                while ( right > left && arr[left] < tag ) {
                    left += 1;
                }
                if ( left < right ) {
                    arr[right] = arr[left];
                    right -= 1;
                }
            }
            arr[left] = tag;
            QuickSort(arr, start, left-1);
            QuickSort(arr, right+1, end);
        }
    }
}