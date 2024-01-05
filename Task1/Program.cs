var rectangle = new Rectangle();
rectangle.Length = Convert.ToDouble(Console.ReadLine());
rectangle.Width = Convert.ToDouble(Console.ReadLine());

var circle = new Circle();
circle.Radius = Convert.ToDouble(Console.ReadLine());
 
public abstract class Shape
{
    public string Description { get; set; }
    public abstract double CalculateArea();
    public abstract void PrintDescription();
}
public class Rectangle : Shape
{
    public double Length;
    public double Width;
    public override double CalculateArea()
    {
        return Width*Length;
    }
    public override void PrintDescription()
    {
        System.Console.WriteLine($"Description = {Description}");
    }
}
public class Circle : Shape
{
    public double Radius;
    public override double CalculateArea()
    {
        return 3.14*Math.Pow(Radius,2);
    }
    public override void PrintDescription()
    {
        System.Console.WriteLine($"Description = {Description}");
    }
}