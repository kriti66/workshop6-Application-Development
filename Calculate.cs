public class Calculator
{
    // Delegate declared inside the same class
    public delegate int Calculate(int a, int b);

    // Methods for calculation
    public static int Add(int a, int b) => a + b;

    public static int Subtract(int a, int b) => a - b;
}
