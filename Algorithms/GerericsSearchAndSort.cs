namespace Algorithms
{
    internal partial class AnagramDetectionS


    {
        class GerericsSearchAndSort

    {
        static void BubbleSort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void MergeSort<T>(T[] arr) where T : IComparable<T>
        {
            MergeSort(arr, 0, arr.Length - 1);
        }

        static void MergeSort<T>(T[] arr, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(arr, left, middle);
                MergeSort(arr, middle + 1, right);

                Merge(arr, left, middle, right);
            }
        }

        static void Merge<T>(T[] arr, int left, int middle, int right) where T : IComparable<T>
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            T[] leftArray = new T[n1];
            T[] rightArray = new T[n2];

            Array.Copy(arr, left, leftArray, 0, n1);
            Array.Copy(arr, middle + 1, rightArray, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (leftArray[i].CompareTo(rightArray[j]) <= 0)
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }
        }

        static void InsertionSort<T>(T[] arr) where T : IComparable<T>
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                T key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(key) > 0)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 64, 34, 25, 12, 22, 11, 90 };
            double[] arr2 = { 3.14, 2.718, 1.618, 0.577, 1.732, 2.236 };
            string[] arr3 = { "banana", "apple", "cherry", "grape", "pear" };

            Console.WriteLine("Original arrays:");
            PrintArray(arr1);
            PrintArray(arr2);
            PrintArray
    



}
    }


