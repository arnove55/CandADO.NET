// See https://aka.ms/new-console-template for more information
abstract class shape
{
    abstract public double Area();
    abstract public double Perameter();

}
class circle : shape
{
    public double r { get; set; }
    public override double Area()
    {
        return Math.PI * r;
    }
    public override double Perameter()
    {
        return 2*Math.PI * r;   
    }
}

class rectangle : shape
{
    public double w { get; set; }
    public double h { get; set; }

    public override double Area()
    {
        return w * h;
    }

    public override double Perameter()
    {
        return (w + h) / 2;
    }
}

class abstractclass
{
    public static void Main(String[] args)
    {
        circle c=new circle{ r=2};
        rectangle r=new rectangle { h=2,w=2 };

        shape s=new circle{ r=2};

        Console.WriteLine(s.Area());    



        Console.WriteLine($"Area of circle:{c.Area()}");

        Console.WriteLine($"perameter of circle:{c.Perameter()}");

        Console.WriteLine($"Area of rect:{r.Area()}");
        Console.WriteLine($"Perameter of rect:{r.Perameter()}");

       Console.ReadKey();
    }
}