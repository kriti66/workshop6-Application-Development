public class Rectangle
{
    private double length;
    private double breadth;

    // Expression-bodied properties
    public double Length
    {
        get => length;
        set => length = value;
    }

    public double Breadth
    {
        get => breadth;
        set => breadth = value;
    }

    // Expression-bodied methods
    public double GetArea() => length * breadth;

    // NEW: Perimeter Method (also expression-bodied)
    public double GetPerimeter() => 2 * (length + breadth);

    public string ShowDetails() =>
        $"Length: {length}, Breadth: {breadth}";
}
