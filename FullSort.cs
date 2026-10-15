using System;

namespace SortingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số lượng phần tử n: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử a[{i}]: ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write($"Mảng ban đầu: ");
            PrintArray(a);

            int[] arr1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr1[i] = a[i];
            }
            BubbleSorter.bubblesort(arr1);
            Console.Write($"Bubble Sort:    ");
            PrintArray(arr1);

            int[] arr2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr2[i] = a[i];
            }
            InterchangeSorter.interchangesort(arr2);
            Console.Write($"Interchange:    ");
            PrintArray(arr2);

            int[] arr3 = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr3[i] = a[i];
            }
            SelectionSorter.selectionsort(arr3);
            Console.Write($"Selection Sort: ");
            PrintArray(arr3);

            int[] arr4 = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr4[i] = a[i];
            }
            InsertionSorter.insertionsort(arr4);
            Console.Write($"Insertion Sort: ");
            PrintArray(arr4);
        }

        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
            Console.WriteLine();
        }
    }

    public class BubbleSorter
    {
        public static void bubblesort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
    }

    public class InterchangeSorter
    {
        public static void interchangesort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }

    public class SelectionSorter
    {
        public static void selectionsort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = a[i];
                    a[i] = a[minIndex];
                    a[minIndex] = temp;
                }
            }
        }
    }

    public class InsertionSorter
    {
        public static void insertionsort(int[] a)
        {
            int n = a.Length;
            for (int i = 1; i < n; i++)
            {
                int key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }
    }
}