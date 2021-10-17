using System;

namespace Algorithms {

    internal class BubbleSort {
        public static void Main (string[] args) {
            var input_array = new int[] { 20, 35, -15, 7, 55, 1, -22 };
        }

        public IComparable<T> BubbleSort (IComparable<T>[] array) {
            var unsortedPartitionIndex = array.Length - 1;
            var temp = 0;
            for (var j = unsortedPartitionIndex; j > 0; j--) {
                for (var i = 0; i < array.length - 1; i++) {
                    if (array[i] > array[i + 1]) {
                        temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
                unsortedPartitionIndex--;
            }
            return array;
        }
    }
}