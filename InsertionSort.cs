using System;

class Program
{
    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] numbers = { 5, 2, 9, 1, 5, 6 };

        InsertionSort(numbers);

        Console.WriteLine(string.Join(", ", numbers));
    }
}