using workshop6_Application_Development;

internal class Program
{
    private static void Main(string[] args)
    {
        // Creating delegate instance
        Calculator.Calculate calc;

        // Call Add()
        calc = Calculator.Add;
        Console.WriteLine("Addition = " + calc(20, 10));

        // Call Subtract()
        calc = Calculator.Subtract;
        Console.WriteLine("Subtraction = " + calc(20, 10));


        Operations.Calculate Calculate;

        calc = Operations.Add;
        Console.WriteLine("Addition = " + calc(20, 10));

        calc = Operations.Subtract;
        Console.WriteLine("Subtraction = " + calc(20, 10));


        Console.WriteLine("----------------------------------");


        // ------------------ PART 2: DISCOUNT ------------------
        Operations.DiscountStrategy discount;

        discount = Operations.FestivalDiscount;
        Console.WriteLine("Festival Discount Price = " + discount(1000));

        discount = Operations.SeasonalDiscount;
        Console.WriteLine("Seasonal Discount Price = " + discount(1000));

        discount = Operations.NoDiscount;
        Console.WriteLine("No Discount Price = " + discount(1000));



        double price = 1000;

        Console.WriteLine("---- Using Delegate Methods ----");

        Console.WriteLine("Festival Discount (20% off): " +
            DiscountCalculator.CalculateFinalPrice(
                price, DiscountCalculator.FestivalDiscount));

        Console.WriteLine("Seasonal Discount (10% off): " +
            DiscountCalculator.CalculateFinalPrice(
                price, DiscountCalculator.SeasonalDiscount));

        Console.WriteLine("No Discount: " +
            DiscountCalculator.CalculateFinalPrice(
                price, DiscountCalculator.NoDiscount));


        Console.WriteLine("\n---- Using Lambda Expression ----");

        // 30% discount using Lambda
        Console.WriteLine("Lambda 30% Discount: " +
            DiscountCalculator.CalculateFinalPrice(
                price, p => p * 0.70));

        Console.WriteLine("\nProgram Completed!");


        int[] numbers = { 2, 5, 12, 18, 7, 25, 30 };

        Console.WriteLine("Even Numbers:");
        NumberProcessor.ProcessNumbers(numbers, n => n % 2 == 0);

        Console.WriteLine("\nNumbers Greater Than 10:");
        NumberProcessor.ProcessNumbers(numbers, n => n > 10);


        LINQExamples.SquareNumbers();

        LINQExamples.FilterPremiumBooks();

        LINQExamples.SortStudents();

        TourAnalysis.AnalyzeTours();


    }
}
    