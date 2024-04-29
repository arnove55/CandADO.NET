// See https://aka.ms/new-console-template for more information
class A
{
    public virtual string atr
    {
        get { return "hello"; }
    }
}
class B : A
{
    public override string atr
    {
        get { return "hii"; }
    }
}

class overridingproperty
{
    public static void Main(String[] args)
    {
        B b=new B();
        Console.WriteLine(b.atr);
    }
}
