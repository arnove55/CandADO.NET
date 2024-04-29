// See https://aka.ms/new-console-template for more information
class A
{
    public virtual void show(int a, int b)
    {
        Console.WriteLine(a + b);
    }
   
    public void show(int c,int d,int e)
    {
        Console.WriteLine(c+d+e);
    }
   
}

class B : A
{
    public override void show(int a, int b)
    {
        base.show(a, b);
        Console.WriteLine(b-a);
    }
}


class polymorphism
{
    public static void Main(String[] args)
    {
        B a = new B();
        A b = new B();

        b.show(1, 1, 1);
        a.show(1, 1);
        b.show(2, 1);
        Console.ReadKey();
        
    }
}