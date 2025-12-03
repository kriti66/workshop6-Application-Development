using System;
using System.Collections.Generic;
using System.Linq;

public class TourAnalysis
{
    public static void AnalyzeTours()
    {
        // List of tour bookings
        List<TourBooking> bookings = new List<TourBooking>
        {
            new TourBooking { CustomerName = "Aarav", Destination = "Dubai", Price = 15000, DurationInDay = 5, IsInternational = true },
            new TourBooking { CustomerName = "Sujal", Destination = "Pokhara", Price = 8000, DurationInDay = 3, IsInternational = false },
            new TourBooking { CustomerName = "Anita", Destination = "Thailand", Price = 20000, DurationInDay = 6, IsInternational = true },
            new TourBooking { CustomerName = "Kriti", Destination = "Chitwan", Price = 9000, DurationInDay = 2, IsInternational = false },
            new TourBooking { CustomerName = "Bibek", Destination = "Singapore", Price = 25000, DurationInDay = 4, IsInternational = true }
        };

        // 1️⃣ FILTERING
        var filteredTours = bookings.Where(t => t.Price > 10000 || t.DurationInDay > 4);

        // 2️⃣ PROJECT / TRANSFORM to a NEW LIST
        var projectedList = filteredTours.Select(t => new
        {
            CustomerName = t.CustomerName,
            Destination = t.Destination,
            Category = t.IsInternational ? "International" : "Domestic",
            Price = t.Price
        });

        // 3️⃣ SORT: Domestic first → International next → then by price
        var sortedList = projectedList
                            .OrderBy(t => t.Category)         // Domestic first (alphabetically)
                            .ThenBy(t => t.Price);           // Then by price ascending

        // 4️⃣ DISPLAY in clean format
        Console.WriteLine("---- Sorted Tour Report ----\n");

        foreach (var t in sortedList)
        {
            Console.WriteLine($"Customer: {t.CustomerName}");
            Console.WriteLine($"Destination: {t.Destination}");
            Console.WriteLine($"Category: {t.Category}");
            Console.WriteLine($"Price: Rs. {t.Price}");
            Console.WriteLine("----------------------------");
        }
    }
}


// Model class
public class TourBooking
{
    public string CustomerName { get; set; }
    public string Destination { get; set; }
    public double Price { get; set; }
    public int DurationInDay { get; set; }
    public bool IsInternational { get; set; }
}
