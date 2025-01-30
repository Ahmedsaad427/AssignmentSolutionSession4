//Part 1

#region Part1
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<Book> books = new List<Book>
//        {
//            new Book("01033726200", "C# Programming", new string[]{"Ahmed Saad", "Karam Elsayed"}, new DateTime(2020, 1, 15), 45.99m),
//            new Book("0987654321", "Python Basics", new string[]{"Youssef Saad", "Mohamed Ali"}, new DateTime(2019, 6, 10), 39.99m)
//        };

//        LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

//        LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

//        LibraryEngine.ProcessBooks(books, delegate (Book B) { return B.ISBN; });

//        LibraryEngine.ProcessBooks(books, (B) => B.PublicationDate.ToShortDateString());
//    }
//}

#endregion

// Part 2

#region Part2
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        CustomList<int> numbers = new CustomList<int>();
//        numbers.Add(5);
//        numbers.Add(10);
//        numbers.Add(15);
//        numbers.Add(20);

//        Console.WriteLine("Exists: " + numbers.Exists(x => x == 10)); // True
//        Console.WriteLine("Find: " + numbers.Find(x => x > 10)); // 15
//        Console.WriteLine("FindAll: " + string.Join(", ", numbers.FindAll(x => x > 5))); // 10, 15, 20
//        Console.WriteLine("FindIndex: " + numbers.FindIndex(x => x == 15)); // 2
//        Console.WriteLine("FindLast: " + numbers.FindLast(x => x < 20)); // 15
//        Console.WriteLine("FindLastIndex: " + numbers.FindLastIndex(x => x < 20)); // 2
//        numbers.ForEach(x => Console.Write(x + " ")); // 5 10 15 20
//        Console.WriteLine();
//        Console.WriteLine("TrueForAll: " + numbers.TrueForAll(x => x > 0)); // True
//    }
//}

#endregion
