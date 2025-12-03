using System;
using System.Collections.Generic;
using System.Linq;

public class LINQExamples
{
    // 1. Selecting / Projection
    public static void SquareNumbers()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        var squared = numbers.Select(n => n * n);

        Console.WriteLine("Squared Numbers:");
        foreach (var num in squared)
        {
            Console.WriteLine(num);
        }
    }

    // 2. Filtering (Where)
    public static void FilterPremiumBooks()
    {
        List<Book> books = new List<Book>
        {
            new Book { Title = "C# Basics", Price = 850 },
            new Book { Title = "ASP.NET Core", Price = 1200 },
            new Book { Title = "LINQ Mastery", Price = 1500 },
            new Book { Title = "Java Programming", Price = 950 }
        };

        var premiumBooks = books.Where(b => b.Price > 1000);

        Console.WriteLine("\nBooks priced above Rs. 1000:");
        foreach (var b in premiumBooks)
        {
            Console.WriteLine($"{b.Title} - Rs. {b.Price}");
        }
    }

    // 3. Sorting (OrderBy)
    public static void SortStudents()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Sujal" },
            new Student { Name = "Kriti" },
            new Student { Name = "Bibek" },
            new Student { Name = "Anita" },
            new Student { Name = "Rohit" }
        };

        var sorted = students.OrderBy(s => s.Name);

        Console.WriteLine("\nSorted Students:");
        foreach (var s in sorted)
        {
            Console.WriteLine(s.Name);
        }
    }
}


// Models required
public class Book
{
    public string Title { get; set; }
    public double Price { get; set; }
}

public class Student
{
    public string Name { get; set; }
}
