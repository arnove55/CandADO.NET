// See https://aka.ms/new-console-template for more information
class shape
{
    public virtual double? Calculatearea()
    {
        return null;
    }
}
class Rectangle : shape
{
    public double h { get; set; }
    public double w { get; set; }

    public override double? Calculatearea()
    {
        return h*w;
    }
}
class Circle : shape
{
    public double r { get; set; }

    public override double? Calculatearea()
    {
        return Math.PI * r * r;
    }
}

class nullablewithoverride
{
    public static void Main(String[] args)
    {
        Rectangle r=new Rectangle { h=5,w=5};
        Circle c = new Circle { r = 2.2 };

        Console.WriteLine($"Area of rectangle:{r.Calculatearea()}");
        Console.WriteLine($"Area of circle:{c.Calculatearea()}");
        Console.ReadKey();

    }
}