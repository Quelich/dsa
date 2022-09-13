namespace SOLs.QArray
{
    public class QuickSort
    {
        private int[] _arr { get; set; }
        public int _length { get; private set; }
        private int _left { get; set; }
        private int _right { get; set; }
        public QuickSort(int[] arr)
        {
            _arr = arr;
            _length = arr.Length;
            _left = 0;
            _right = _length - 1;
        }

        public int[] GetSorted()
        {
            QSort(_arr, _left, _right);

            return _arr;
        }
        public void QSort(int[] arr, int left, int right)
        {

            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QSort(arr, pivot + 1, right);
                }
            }
        }

        public int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }
    }
}
