using System;

namespace Demo
{
    class Program
    {
        //public static void PrintArray(int[] values)
        //{
        //    foreach (int item in values)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}

        public static Action Fun01()
        {
            //Action action = Print; 
            //Action action delegate () { Console.WriteLine("Hello World"); }; 
            Action action = () => Console.WriteLine(value: "Hello World");
            return action;
        }
        public static void PrintList(List<int> values)
        {
            foreach (int item in values)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        //public static int Fun01()
        //{
        //    return 1;
        //}

        public static string Fun02(int number)
        {
            return $"Number: {number}";
        }

        public static void PrintList(List<string> values)
        {
            foreach (var item in values)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        //public static void PrintArray(string[] values)
        //{
        //    foreach (string item in values)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}

        //public static void PrintList(List<int> values)
        //{
        //    foreach (int item in values)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}

        public static List<int> FindOddNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 != 0).ToList();
        }
        public delegate int StringFuncDelegate(string s);

        static void Main(string[] args)
        {
            #region DelegateOverview
            // Delegate: C# Feature 
            // C# Pure OOP 
            // Functional Programming 
            // Event-Driven Programming 
            // Java Pure OOP 
            #endregion

            #region DelegateEX1
            //StringFuncDelegate X;
            //X = StringFunctions.GetCountOfUpperCaseChars;
            //StringFuncDelegate X; 
            //X = StringFunctions.GetCountOfUpperCaseChars; 
            //StringFuncDelegate X = new StringFuncDelegate(StringFunctions.GetCountOfUpper
            //StringFuncDelegate X = StringFunctions.GetCountOfUpperCaseChars; // Syntax Sugar 
            //X += StringFunctions.GetCountOfLowerCaseChars;

            //int Count = X.Invoke(s: "Hello World");// Syntax Sugar 
            //Console.WriteLine(Count);
            #endregion

            #region DelegateEX2
            //int[] Numbers = { 9, 8, 7, 1, 2, 3, 6, 5, 4 };
            //PrintArray(Numbers);
            //SortingAlgorithms.BubbleSortAscending(Numbers); // Sorting Ascending 
            //SortingAlgorithms.BubbleSortAscending(Numbers); // Sorting Ascending 
            //PrintArray(Numbers);

            //int[] arr1 = { 64, 25, 12, 22, 11 };
            //int[] arr2 = { 64, 25, 12, 22, 11 };

            //SortingAlgorithms.BubbleSort(arr1, SortingConditions.CompareGtr);
            //Console.WriteLine("Sorted in Ascending Order:");
            //PrintArray(arr1);

            //SortingAlgorithms.BubbleSort(arr2, SortingConditions.CompareLess);
            //Console.WriteLine("Sorted in Descending Order:");
            //PrintArray(arr2);
            #endregion

            #region DelegateEX2WithGeneric
            //string[] arr2 = { "Ahmed", "Ali", "Mona", "Elsayed", "Mohamed" };
            //SortingAlgorithms.BubbleSort(arr2, SortingConditions.CompareGtr);
            //Console.WriteLine("String Array Sorted in Ascending Order:");
            //PrintArray(arr2);

            //SortingAlgorithms.BubbleSort(arr2, SortingConditions.CompareLess);
            //Console.WriteLine("String Array Sorted in Descending Order:");
            //PrintArray(arr2);
            #endregion

            #region DelegateEX3
            //List<int> Numbers = Enumerable.Range(1, 100).ToList();

            //List<int> OddNumbers = SortingConditions.FindOddNumbers(Numbers);

            //List<int> EvenNumbers = SortingConditions.FindEvenNumbers(Numbers);

            //Console.WriteLine("All Numbers:");
            //PrintList(Numbers);

            //Console.WriteLine("Odd Numbers:");
            //PrintList(OddNumbers);

            //Console.WriteLine("Even Numbers:");
            //PrintList(EvenNumbers);
            #endregion

            #region DelegateExample3WithGeneric
            //List<string> words = new List<string> { "Ahmed", "Saad", "Karam", "Youssef", "Mohamed", "Ali", "Omar" };

            //List<string> OddLengthStrings = SortingConditions.FindOddLengthStrings(words);

            //List<string> EvenLengthStrings = SortingConditions.FindEvenLengthStrings(words);

            //Console.WriteLine("All Strings:");
            //PrintList(words);

            //Console.WriteLine("Strings with Odd Length:");
            //PrintList(OddLengthStrings);

            //Console.WriteLine("Strings with Even Length:");
            //PrintList(EvenLengthStrings);
            #endregion

            #region BuiltinDelegates


            //    // Built-in Delegate 
            //    // Predicate, Func, Action 
            //    // Predicate 
            //    //ConditionFuncDelegate<int> X = Condittons Funtions.CheckEven;
            //    // Predicate
            //    // Predicate<T> is a delegate that takes a parameter of type T and returns a bool.
            //    Predicate<int> predicate = SortingConditions.CheckEven;
            //    bool result = predicate.Invoke(1); // This will check if 1 is even
            //    Console.WriteLine(result); // Output: False (since 1 is odd)

            //    // Func
            //    // Func<T> is a delegate that takes a parameter of type T and returns a value of type TResult.
            //    Func<int> func = Fun01;
            //    int value = func.Invoke();
            //    Console.WriteLine(value); // Output: 1 (since Fun01 returns 1)

            //    // Func<T1, TResult> is a delegate that takes one parameter and returns a result.
            //    Func<int, string> func1 = Fun02;
            //    string result1 = func1.Invoke(5); // Passes 5 as input to Fun02
            //    Console.WriteLine(result1); // Output: "Number: 5"
            //}
            #endregion

            #region Anonymous Method&&Lambda Expression
            //// Using an anonymous method with Action
            //Action<int, int> add = delegate (int a, int b)
            //{
            //    Console.WriteLine(a + b);
            //};
            //add(5, 10);  // Output: 15
            //             // Using a lambda expression with Action
            //Action<int, int> add = (a, b) => Console.WriteLine(a + b);
            //add(5, 10);  // Output: 15

            //// Using a lambda expression with Func
            //Func<int, int, int> multiply = (a, b) => a * b;
            //int result = multiply(5, 10);
            //Console.WriteLine(result);  // Output: 50

            #endregion

            #region C# KeyWord Var

            //// C# Keyword 
            //// C# 3.0 
            //// var 
            //var X = "Hewllo";
            ////X = 12; 
            ////var predicate Condittons Funtions.CheckDivisableBy4;
            #endregion

            #region ReturnFun
            //var action = Fun01(); 
            //action. Invoke(); 
            //Fun01()();
            #endregion
        }
    }
    }

