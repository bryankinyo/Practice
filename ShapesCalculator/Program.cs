using Library.Shapes;

class Program
{
    static void Main(string[] args)
    {
        var shapes = new List<Shapes>
        {
            new Circle(5),
            new Rectangle(4, 7)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}");
            Console.WriteLine($"Area: {shape.CalculateArea():F2}\n");
        }
    }
}