// See https://aka.ms/new-console-template for more information
interface shape
{
    abstract double CalculateArea();
    abstract double CalculatePerameter();
}

class Rectange : shape
{
    public double h { get; set; }
    public double w { get; set; }

    public double CalculateArea()
    {
        return h * w;
    }

    public double CalculatePerameter()
    {
        return (w + h) / 2;
    }
}

class Circle : shape
{
    public double r { get; set; }
    public double CalculateArea()
    {
        return Math.PI * r * r;
    }
    public double CalculatePerameter()
    {
        return 2*Math.PI * r;
    }
}

class interfacep2
{
    public static void Main(String[] args)
    {
        Rectange r=new Rectange { h=2,w=2};
        Circle c=new Circle { r=2};
        Console.WriteLine($"Arae circle:{c.CalculateArea()}");
        Console.WriteLine($"Perameter circle:{c.CalculatePerameter()}");
        Console.WriteLine($"Area rectangle:{r.CalculatePerameter()}");
        Console.WriteLine($"Perameter:{r.CalculateArea()}");
        Console.ReadKey();
    }
}