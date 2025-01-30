//internal class SortingConditions
//{
//    public static bool CompareGtr(int X, int Y)
//    {
//        return X > Y;
//    }

//    public static bool CompareLess(int X, int Y)
//    {
//        return X < Y;
//    }

//}
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    internal class SortingConditions
    {
        public static bool CompareGtr(string A, string B)
        {
            return string.Compare(A, B) > 0;
        }

        public static bool CompareLess(string A, string B)
        {
            return string.Compare(A, B) < 0;
        }

        public static List<int> FindOddNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 != 0).ToList();
        }

        public static List<int> FindEvenNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).ToList();
        }

        public static List<string> FindOddLengthStrings(List<string> strings)
        {
            return strings.Where(s => s.Length % 2 != 0).ToList();
        }

        public static List<string> FindEvenLengthStrings(List<string> strings)
        {
            return strings.Where(s => s.Length % 2 == 0).ToList();
        }

        public static bool CheckEven(int number)
        {
            return number % 2 == 0; // Returns true if the number is even, false otherwise
        }

      

    }
}





