namespace Quelich.DataStructures;

public class MergeSortAlgorithm
{
    void Merge(int[] arr, int l, int m, int r)
    {
        int i,
            j,
            k;
        int lSize = m - l + 1;
        int rSize = r - m;
        int[] L = new int[lSize];
        int[] R = new int[rSize];

        for (i = 0; i < lSize; ++i)
            L[i] = arr[l + i];

        for (j = 0; j < rSize; ++j)
            R[j] = arr[m + 1 + j];

        i = 0;
        j = 0;
        k = l;
        while (i < lSize && j < rSize)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                i++;
            }
            else
            {
                arr[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < lSize)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        while (j < rSize)
        {
            arr[k] = R[j];
            j++;
            k++;
        }

        
    }

    public void MergeSort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;
            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);
            Merge(arr, l, m, r);
        }
    }
}
