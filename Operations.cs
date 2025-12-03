public class Operations
{
    // ----- PART 1: Calculate Delegate -----
    public delegate int Calculate(int a, int b);

    public static int Add(int a, int b) => a + b;

    public static int Subtract(int a, int b) => a - b;


    // ----- PART 2: DiscountStrategy Delegate -----
    public delegate double DiscountStrategy(double price);

    public static double FestivalDiscount(double price) => price * 0.80;  // 20% off

    public static double SeasonalDiscount(double price) => price * 0.90;  // 10% off

    public static double NoDiscount(double price) => price;              // No discount




}
