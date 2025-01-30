///*using System;

//namespace Demo
//{
//    public delegate bool SortingFuncDelegate(int A, int B);

//    internal class SortingAlgorithms
//    {

//        public static void BubbleSortAscending(int[] Arr, SortingFuncDelegate refrence)
//        {
//            if (Arr?.Length > 0)
//            {
//                for (int i = 0; i < Arr.Length - 1; i++)
//                {
//                    for (int j = 0; j < Arr.Length - 1 - i; j++)
//                    {
//                        if (SortingConditions.CompareGtr(Arr[j], Arr[j+1]))
//                        {
//                            Swap(ref Arr[j], ref Arr[j + 1]);
//                        }
//                    }
//                }
//            }
//        }

//        public static void BubbleSortDescending(int[] Arr)
//        {
//            if (Arr?.Length > 0)
//            {
//                for (int i = 0; i < Arr.Length - 1; i++)
//                {
//                    for (int j = 0; j < Arr.Length - 1 - i; j++)
//                    {
//                        if (SortingConditions.CompareLess(Arr[j], Arr[j + 1]))
//                        {
//                            Swap(ref Arr[j], ref Arr[j + 1]);
//                        }
//                    }
//                }
//            }
//        }

//        public static void Swap(ref int a, ref int b)
//        {
//            int temp = a;
//            a = b;
//            b = temp;
//        }
//    }
//}
//*/





//using System;
//namespace Demo
//{
//    public delegate bool SortingFuncDelegate(int A, int B);

//    internal class SortingAlgorithms
//    {
//        public static void BubbleSort(int[] Arr, SortingFuncDelegate compare)
//        {
//            if (Arr?.Length > 0)
//            {
//                for (int i = 0; i < Arr.Length - 1; i++)
//                {
//                    for (int j = 0; j < Arr.Length - 1 - i; j++)
//                    {
//                        if (compare.Invoke(Arr[j], Arr[j + 1]))
//                        {
//                            Swap(ref Arr[j], ref Arr[j + 1]);
//                        }
//                    }
//                }
//            }
//        }

//        public static void Swap(ref int a, ref int b)
//        {
//            int temp = a;
//            a = b;
//            b = temp;
//        }
//    }

//    }


using System;

namespace Demo
{
    public delegate bool SortingFuncDelegate(string A, string B);

    internal class SortingAlgorithms
    {
        public static void BubbleSort(int[] Arr, SortingFuncDelegate compare)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length - 1; i++)
                {
                    for (int j = 0; j < Arr.Length - 1 - i; j++)
                    {
                        if (compare.Invoke(Arr[j].ToString(), Arr[j + 1].ToString()))
                        {
                            Swap(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }

        public static void BubbleSort(string[] Arr, SortingFuncDelegate compare)
        {
            if (Arr?.Length > 0)
            {
                for (int i = 0; i < Arr.Length - 1; i++)
                {
                    for (int j = 0; j < Arr.Length - 1 - i; j++)
                    {
                        if (compare.Invoke(Arr[j], Arr[j + 1]))
                        {
                            Swap(ref Arr[j], ref Arr[j + 1]);
                        }
                    }
                }
            }
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
    }
}