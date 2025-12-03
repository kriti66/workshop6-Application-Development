public class DiscountCalculator
{
    public delegate double DiscountStrategy(double price);

    public static double FestivalDiscount(double price) => price * 0.80;
    public static double SeasonalDiscount(double price) => price * 0.90;
    public static double NoDiscount(double price) => price;

    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
    {
        return strategy(originalPrice);
    }
}
